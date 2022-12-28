using AppFarmaciaBackend.Datos.Interfaz;
using AppFarmaciaBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Datos.Implementación
{
    public class EntregaDao : IEntregaDao
    {
        public int ObtenerProximaEntrega()
        {
            return HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMA_ENTREGA", "@NRO_ENTREGA");
        }

        public bool CrearEntrega(Entrega oEntrega)
        {
            bool aux = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            int nroDetalle = HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMO_DETALLE_ENTREGA", "@NRO_DETALLE");

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdEntrega = new SqlCommand("SP_INSERTAR_ENTREGA", cnn, t);
                cmdEntrega.CommandType = CommandType.StoredProcedure;
                cmdEntrega.Parameters.AddWithValue("@id_Entrega", oEntrega.IdEntrega);
                cmdEntrega.Parameters.AddWithValue("@id_Sucursal", oEntrega.oSucursal.IdSucursal);
                cmdEntrega.Parameters.AddWithValue("@Fecha", oEntrega.Fecha);
                cmdEntrega.Parameters.AddWithValue("@Empleado_Log", oEntrega.EmpleadoLogistica);
                cmdEntrega.Parameters.AddWithValue("@id_Empleado", oEntrega.oEmpleado.IdEmpleado);
                cmdEntrega.ExecuteNonQuery();

                SqlCommand cmdDetalle;

                foreach (DetalleEntrega item in oEntrega.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE_ENTREGA", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_DetalleEntrega", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@id_Insumo", item.oInsumo.IdInsumo);
                    cmdDetalle.Parameters.AddWithValue("@id_Entrega", oEntrega.IdEntrega);
                    cmdDetalle.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    nroDetalle++;
                }
                t.Commit();
            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                aux = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return aux;
        }

        public List<Entrega> ObtenerEntregas(List<Parámetro> lstParametros)
        {
            List<Entrega> lstEntregas = new List<Entrega>();

            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-FU6B6SN;Initial Catalog=Farmacia;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("sp_Consultar_Entregas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (lstParametros != null)
            {
                foreach (Parámetro oParametro in lstParametros)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, Convert.ToDateTime(oParametro.Valor.ToString()));
                }
            }
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            

            foreach (DataRow dr in dt.Rows)
            {
                Entrega oEntrega = new Entrega();

                Empleado oEmpleado = new Empleado();
                oEmpleado.oPersona.Nombre = dr["nombre_empleado"].ToString();
                oEmpleado.oPersona.Apellido = dr["apellido_empleado"].ToString();
                oEmpleado.IdEmpleado = Convert.ToInt32(dr["id_EmpleadoSuc"].ToString());

                Sucursal oSucursal = new Sucursal();
                oSucursal.IdSucursal = Convert.ToInt32(dr["id_Sucursal"].ToString());
                oEntrega.EmpleadoLogistica = dr["empleado_Log"].ToString();
                oEntrega.IdEntrega = int.Parse(dr["id_Entrega"].ToString());
                oEntrega.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                oEntrega.oSucursal = oSucursal;
                oEntrega.oEmpleado = oEmpleado;

                lstEntregas.Add(oEntrega);
            }
            return lstEntregas;
        }
        public bool EliminarEntrega(int id)
        {
            bool aux = false;
            string sp = "SP_ELIMINAR_ENTREGA";
            List<Parámetro> lst = new List<Parámetro>();
            lst.Add(new Parámetro("@Id", id));
            int filasAfectadas = HelperDB.ObtenerInstancia().EjecutarSp(sp, lst);
            if (filasAfectadas > 0)
            {
                aux = true;
            }
            return aux;
        }
        public List<DetalleEntrega> ObtenerDetallesEntrega(int idEntrega)
        {
            List<DetalleEntrega> lstDetalles = new List<DetalleEntrega>();
            List<Parámetro> lstParametros = new List<Parámetro>();
            Parámetro parametroId = new Parámetro("@Id", idEntrega);
            lstParametros.Add(parametroId);
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("SP_CONSULTAR_DETALLES_ENTREGA", lstParametros);
            foreach (DataRow dr in dt.Rows)
            {
                DetalleEntrega oDetalle = new DetalleEntrega();
                Insumo oInsumo = new Insumo();
                oInsumo.IdInsumo = Convert.ToInt32(dr["id_Insumo"].ToString());
                oInsumo.Nombre = dr["insumo"].ToString();
                bool venta = Convert.ToBoolean(dr["venta"].ToString());

                int tipoVenta;
                if (venta)
                {
                    tipoVenta = 1;
                }
                else
                {
                    tipoVenta = 0;
                }

                oInsumo.TipoVenta = tipoVenta;
                TipoInsumo oTipoInsumo = new TipoInsumo();
                oTipoInsumo.IdTipoInsumo = Convert.ToInt32(dr["tipoInsumo"].ToString());
                oInsumo.oTipoInsumo = oTipoInsumo;
                oDetalle.oInsumo = oInsumo;
                oDetalle.Cantidad = Convert.ToInt32(dr["cantidad"].ToString());

                lstDetalles.Add(oDetalle);
            }
            return lstDetalles;
        }

        public Entrega ObtenerEntrega(int idEntrega)
        {
            List<Parámetro> lstParametros = new List<Parámetro>();
            Entrega oEntrega = new Entrega();
            Parámetro parametroId = new Parámetro("@Id_Entrega", idEntrega);
            lstParametros.Add(parametroId);

            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("sp_Consultar_Entrega_id", lstParametros);

            foreach (DataRow dr in dt.Rows)
            {
                Empleado oEmpleado = new Empleado();
                oEmpleado.oPersona.Nombre = dr["nombre_empleado"].ToString();
                oEmpleado.oPersona.Apellido = dr["apellido_empleado"].ToString();
                oEmpleado.IdEmpleado = Convert.ToInt32(dr["id_EmpleadoSuc"].ToString());

                Sucursal oSucursal = new Sucursal();
                oSucursal.IdSucursal = Convert.ToInt32(dr["id_Sucursal"].ToString());
                oEntrega.EmpleadoLogistica = dr["empleado_Log"].ToString();
                oEntrega.IdEntrega = int.Parse(dr["id_Entrega"].ToString());
                oEntrega.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                oEntrega.oSucursal = oSucursal;
                oEntrega.oEmpleado = oEmpleado;
            }
            return oEntrega;
        }

        public bool ActualizarEntrega(Entrega oEntrega)
        {
            bool aux = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            int nroDetalle = HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMO_DETALLE_ENTREGA", "@NRO_DETALLE");

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                string spModificarEntrega = "SP_MODIFICA_ENTREGA";
                List<Parámetro> lstActualizarEntrega = new List<Parámetro>();
                lstActualizarEntrega.Add(new Parámetro("@Id", oEntrega.IdEntrega));
                lstActualizarEntrega.Add(new Parámetro("@fecha", oEntrega.Fecha));
                int filasAfectadas = HelperDB.ObtenerInstancia().EjecutarSp(spModificarEntrega, lstActualizarEntrega);


                if (filasAfectadas > 0)
                {
                    string spEliminarDetalles = "sp_eliminar_detalles_entrega";
                    List<Parámetro> lstEliminarDetalles = new List<Parámetro>();
                    lstEliminarDetalles.Add(new Parámetro("@Id", oEntrega.IdEntrega));
                    HelperDB.ObtenerInstancia().EjecutarSp(spEliminarDetalles, lstEliminarDetalles);
                }

                SqlCommand cmdDetalle;

                if (cnn != null && cnn.State == ConnectionState.Closed)
                    cnn.Open();

                foreach (DetalleEntrega item in oEntrega.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE_ENTREGA", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_DetalleEntrega", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@id_Insumo", item.oInsumo.IdInsumo);
                    cmdDetalle.Parameters.AddWithValue("@id_Entrega", oEntrega.IdEntrega);
                    cmdDetalle.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    nroDetalle++;
                }

            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return aux;
        }
    }

    }
