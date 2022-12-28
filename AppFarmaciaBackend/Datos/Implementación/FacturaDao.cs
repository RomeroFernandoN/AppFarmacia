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
    public class FacturaDao :IFacturaDao
    {
        public int ObtenerProximaFactura()
        {
            return HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMA_FACTURA", "@NRO_FACTURA");
        }

        public List<Insumo> ObtenerInsumos()
        {
            List<Insumo> listaInsumos = new List<Insumo>();
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("SP_CONSULTAR_INSUMOS", null);
            foreach(DataRow dr in dt.Rows)
            {
                int idInsumo = int.Parse(dr["id_Insumo"].ToString());
                string nombre = dr["insumo"].ToString();
                bool venta = bool.Parse(dr["venta_libre"].ToString());
                int tipoInsumo = int.Parse(dr["id_TipoInsumo"].ToString());
                decimal precio = decimal.Parse(dr["pre_unitario"].ToString());

                int tipoVenta;
                if(venta)
                {
                    tipoVenta = 1;
                }
                else
                {
                    tipoVenta = 0;
                }

                TipoInsumo oTipoInsumo = new TipoInsumo(tipoInsumo);
                Insumo oInsumo = new Insumo(idInsumo, nombre, tipoVenta, oTipoInsumo, precio);
                listaInsumos.Add(oInsumo);
            }
            return listaInsumos;
        }

        public List<ObraSocial> ObtenerObrasSociales()
        {
            List<ObraSocial> listaObrasSociales = new List<ObraSocial>();
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("SP_CONSULTAR_OBRAS_SOCIALES", null);
            foreach (DataRow dr in dt.Rows)
            {
                int idObraSocial = int.Parse(dr["id_ObraSocial"].ToString());
                string nombre = dr["nombre"].ToString();

                ObraSocial oObraSocial = new ObraSocial(idObraSocial, nombre);
                listaObrasSociales.Add(oObraSocial);
            }
            return listaObrasSociales;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("SP_CONSULTAR_EMPLEADOS", null);
            foreach (DataRow dr in dt.Rows)
            {
                int idEmpleado = int.Parse(dr["id_EmpleadoSuc"].ToString());
                string nombre = dr["nombre"].ToString();
                string apellido = dr["apellido"].ToString();

                Persona oPersona = new Persona(nombre, apellido);
                Empleado oEmpleado = new Empleado(idEmpleado, oPersona);
                listaEmpleados.Add(oEmpleado);
            }
            return listaEmpleados;
        }

        public List<Sucursal> ObtenerSucursales()
        {
            List<Sucursal> listaSucursales = new List<Sucursal>();
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("SP_CONSULTAR_SUCURSALES", null);
            foreach (DataRow dr in dt.Rows)
            {
                int idSucursal = int.Parse(dr["id_Sucursal"].ToString());
                string nombre = dr["nombre"].ToString();
                int telefono = int.Parse(dr["telefono"].ToString());
                string barrio = dr["id_Barrio"].ToString();

                Sucursal oSucursal = new Sucursal(idSucursal, nombre, telefono, barrio);
                listaSucursales.Add(oSucursal);
            }
            return listaSucursales;
        }

        public int ExisteCliente(string nombre, string apellido, int documento)
        {
            List<Parámetro> lstParametro = new List<Parámetro>();
            Parámetro parametroNombre = new Parámetro("@Nombre", nombre);
            lstParametro.Add(parametroNombre);
            Parámetro parametroApellido = new Parámetro("@Apellido", apellido);
            lstParametro.Add(parametroApellido);
            Parámetro parametroDocumento = new Parámetro("@Documento", documento);
            lstParametro.Add(parametroDocumento);

            int id = HelperDB.ObtenerInstancia().ConsultaEscalarConParametros("SP_EXISTE_CLIENTE", "@ID" , lstParametro);

            return id;
        }
        public bool CrearFactura(Factura oFactura)
        {
            bool aux = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            int nroDetalle = HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMO_DETALLE_FACTURA", "@NRO_DETALLE");
            int nroReceta = HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMA_RECETA", "@NRO_RECETA");
            int nroCliente;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdCliente;

                if (ExisteCliente(oFactura.oCliente.oPersona.Nombre, oFactura.oCliente.oPersona.Apellido, oFactura.oCliente.NroDocumento) == 0 )
                    {
                    cnn.Open();
                    t = cnn.BeginTransaction();
                    cmdCliente = new SqlCommand("SP_INSERTAR_CLIENTE", cnn, t);
                    cmdCliente.CommandType = CommandType.StoredProcedure;
                    cmdCliente.Parameters.AddWithValue("nombre", oFactura.oCliente.oPersona.Nombre);
                    cmdCliente.Parameters.AddWithValue("apellido", oFactura.oCliente.oPersona.Apellido);
                    cmdCliente.Parameters.AddWithValue("documento", oFactura.oCliente.NroDocumento);

                    SqlParameter pOut = new SqlParameter();
                    pOut.ParameterName = "@Id";
                    pOut.DbType = DbType.Int32;
                    pOut.Direction = ParameterDirection.Output;
                    cmdCliente.Parameters.Add(pOut);
                    cmdCliente.ExecuteNonQuery();
                    nroCliente = (int)pOut.Value;
                }
                else
                {
                    nroCliente = ExisteCliente(oFactura.oCliente.oPersona.Nombre, oFactura.oCliente.oPersona.Apellido, oFactura.oCliente.NroDocumento);
                    cnn.Open();
                    t = cnn.BeginTransaction();
                }

                SqlCommand cmdFactura = new SqlCommand("SP_INSERTAR_FACTURA", cnn, t);
                cmdFactura.CommandType = CommandType.StoredProcedure;
                cmdFactura.Parameters.AddWithValue("id_Factura", oFactura.IdFactura);
                cmdFactura.Parameters.AddWithValue("id_Sucursal ", oFactura.oSucursal.IdSucursal);
                cmdFactura.Parameters.AddWithValue("id_Cliente", nroCliente);
                cmdFactura.Parameters.AddWithValue("fecha", oFactura.Fecha);
                cmdFactura.Parameters.AddWithValue("@id_Empleado", oFactura.oEmpleado.IdEmpleado);
                cmdFactura.ExecuteNonQuery();

                SqlCommand cmdDetalle;

                foreach (DetalleFactura item in oFactura.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE_FACTURA", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_DetFactura", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@id_Factura", oFactura.IdFactura);
                    cmdDetalle.Parameters.AddWithValue("@id_Insumo", item.oInsumo.IdInsumo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", item.Precio);

                    if (item.oReceta != null)
                    {
                        SqlCommand cmdReceta = new SqlCommand("SP_INSERTAR_RECETA", cnn, t);
                        cmdReceta.CommandType = CommandType.StoredProcedure;
                        cmdReceta.Parameters.AddWithValue("id_Receta", nroReceta);
                        cmdReceta.Parameters.AddWithValue("nom_Medico", item.oReceta.oMedico.oPersona.Nombre);
                        cmdReceta.Parameters.AddWithValue("ape_Medico", item.oReceta.oMedico.oPersona.Apellido);
                        cmdReceta.Parameters.AddWithValue("matricula_Medico", item.oReceta.oMedico.Matricula);
                        cmdReceta.Parameters.AddWithValue("diagnostico", item.oReceta.Diagnostico);
                        cmdReceta.Parameters.AddWithValue("id_Insumo", item.oReceta.oInsumo.IdInsumo);
                        cmdReceta.ExecuteNonQuery();

                        cmdDetalle.Parameters.AddWithValue("@id_ObraSocial", item.oObraSocial.IdObraSocial);
                        cmdDetalle.Parameters.AddWithValue("@id_Receta", nroReceta);
                        nroReceta++;
                    }
                    else
                    {
                        cmdDetalle.Parameters.AddWithValue("@id_ObraSocial", SqlDbType.VarBinary).Value = System.Data.SqlTypes.SqlBinary.Null;
                        cmdDetalle.Parameters.AddWithValue("@id_Receta", SqlDbType.VarBinary).Value = System.Data.SqlTypes.SqlBinary.Null;
                    }
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


        public bool CrearFacturaSinOs(Factura oFactura)
        {
            bool aux = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            int nroDetalle = HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMO_DETALLE_FACTURA", "@NRO_DETALLE");
            int nroCliente;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdCliente;

                if (ExisteCliente(oFactura.oCliente.oPersona.Nombre, oFactura.oCliente.oPersona.Apellido, oFactura.oCliente.NroDocumento) == 0)
                {
                    cnn.Open();
                    t = cnn.BeginTransaction();
                    cmdCliente = new SqlCommand("SP_INSERTAR_CLIENTE", cnn, t);
                    cmdCliente.CommandType = CommandType.StoredProcedure;
                    cmdCliente.Parameters.AddWithValue("nombre", oFactura.oCliente.oPersona.Nombre);
                    cmdCliente.Parameters.AddWithValue("apellido", oFactura.oCliente.oPersona.Apellido);
                    cmdCliente.Parameters.AddWithValue("documento", oFactura.oCliente.NroDocumento);

                    SqlParameter pOut = new SqlParameter();
                    pOut.ParameterName = "@Id";
                    pOut.DbType = DbType.Int32;
                    pOut.Direction = ParameterDirection.Output;
                    cmdCliente.Parameters.Add(pOut);
                    cmdCliente.ExecuteNonQuery();
                    nroCliente = (int)pOut.Value;
                }
                else
                {
                    nroCliente = ExisteCliente(oFactura.oCliente.oPersona.Nombre, oFactura.oCliente.oPersona.Apellido, oFactura.oCliente.NroDocumento);
                    cnn.Open();
                    t = cnn.BeginTransaction();
                }

                SqlCommand cmdFactura = new SqlCommand("SP_INSERTAR_FACTURA", cnn, t);
                cmdFactura.CommandType = CommandType.StoredProcedure;
                cmdFactura.Parameters.AddWithValue("id_Factura", oFactura.IdFactura);
                cmdFactura.Parameters.AddWithValue("id_Sucursal ", oFactura.oSucursal.IdSucursal);
                cmdFactura.Parameters.AddWithValue("id_Cliente", nroCliente);
                cmdFactura.Parameters.AddWithValue("fecha", oFactura.Fecha);
                cmdFactura.Parameters.AddWithValue("@id_Empleado", oFactura.oEmpleado.IdEmpleado);
                cmdFactura.ExecuteNonQuery();

                SqlCommand cmdDetalle;

                foreach (DetalleFactura item in oFactura.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE_FACTURA", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_DetFactura", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@id_Factura", oFactura.IdFactura);
                    cmdDetalle.Parameters.AddWithValue("@id_Insumo", item.oInsumo.IdInsumo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", item.Precio);

                        cmdDetalle.Parameters.AddWithValue("@id_ObraSocial", SqlDbType.VarBinary).Value = System.Data.SqlTypes.SqlBinary.Null;
                        cmdDetalle.Parameters.AddWithValue("@id_Receta", SqlDbType.VarBinary).Value = System.Data.SqlTypes.SqlBinary.Null;

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
        public bool ActualizarFactura(Factura oFactura)
        {
            bool aux = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            int nroDetalle = HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMO_DETALLE_FACTURA", "@NRO_DETALLE");
            int nroReceta = HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMA_RECETA", "@NRO_RECETA");
            SqlTransaction t = null;
            int nroCliente;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdCliente;
                if (ExisteCliente(oFactura.oCliente.oPersona.Nombre, oFactura.oCliente.oPersona.Apellido, oFactura.oCliente.NroDocumento) == 0)
                {
                    cnn.Open();
                    cmdCliente = new SqlCommand("SP_INSERTAR_CLIENTE", cnn, t);
                    cmdCliente.CommandType = CommandType.StoredProcedure;
                    cmdCliente.Parameters.AddWithValue("nombre", oFactura.oCliente.oPersona.Nombre);
                    cmdCliente.Parameters.AddWithValue("apellido", oFactura.oCliente.oPersona.Apellido);
                    cmdCliente.Parameters.AddWithValue("documento", oFactura.oCliente.NroDocumento);

                    SqlParameter pOut = new SqlParameter();
                    pOut.ParameterName = "@Id";
                    pOut.DbType = DbType.Int32;
                    pOut.Direction = ParameterDirection.Output;
                    cmdCliente.Parameters.Add(pOut);
                    cmdCliente.ExecuteNonQuery();
                    nroCliente = (int)pOut.Value;
                }
                else
                {
                    nroCliente = ExisteCliente(oFactura.oCliente.oPersona.Nombre, oFactura.oCliente.oPersona.Apellido, oFactura.oCliente.NroDocumento);
                    cnn.Open();
                }

                string spModificarFactura = "SP_MODIFICA_FACTURA";
                List<Parámetro> lstActualizarFactura = new List<Parámetro>();
                lstActualizarFactura.Add(new Parámetro("@Id", oFactura.IdFactura));
                lstActualizarFactura.Add(new Parámetro("@fecha", oFactura.Fecha));
                int filasAfectadas = HelperDB.ObtenerInstancia().EjecutarSp(spModificarFactura, lstActualizarFactura);


                if (filasAfectadas > 0)
                {
                    string spEliminarDetalles = "SP_ELIMINAR_DETALLES_FACTURA";
                    List<Parámetro> lstEliminarDetalles = new List<Parámetro>();
                    lstEliminarDetalles.Add(new Parámetro("@Id", oFactura.IdFactura));
                    HelperDB.ObtenerInstancia().EjecutarSp(spEliminarDetalles, lstEliminarDetalles);
                }

                SqlCommand cmdDetalle;

                    if (cnn != null && cnn.State == ConnectionState.Closed)
                        cnn.Open();

                    foreach (DetalleFactura item in oFactura.Detalles)
                    {
                        cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE_FACTURA", cnn, t);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;
                        cmdDetalle.Parameters.AddWithValue("@id_DetFactura", nroDetalle);
                        cmdDetalle.Parameters.AddWithValue("@id_Factura", oFactura.IdFactura);
                        cmdDetalle.Parameters.AddWithValue("@id_Insumo", item.oInsumo.IdInsumo);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@precio", item.Precio);

                        if (item.oReceta != null)
                        {
                            SqlCommand cmdReceta = new SqlCommand("SP_INSERTAR_RECETA", cnn, t);
                            cmdReceta.CommandType = CommandType.StoredProcedure;
                            cmdReceta.Parameters.AddWithValue("id_Receta", nroReceta);
                            cmdReceta.Parameters.AddWithValue("nom_Medico", item.oReceta.oMedico.oPersona.Nombre);
                            cmdReceta.Parameters.AddWithValue("ape_Medico", item.oReceta.oMedico.oPersona.Apellido);
                            cmdReceta.Parameters.AddWithValue("matricula_Medico", item.oReceta.oMedico.Matricula);
                            cmdReceta.Parameters.AddWithValue("diagnostico", item.oReceta.Diagnostico);
                            cmdReceta.Parameters.AddWithValue("id_Insumo", item.oReceta.oInsumo.IdInsumo);
                            cmdReceta.ExecuteNonQuery();

                            cmdDetalle.Parameters.AddWithValue("@id_ObraSocial", item.oObraSocial.IdObraSocial);
                            cmdDetalle.Parameters.AddWithValue("@id_Receta", nroReceta);
                            nroReceta++;
                        }
                        else
                        {
                            cmdDetalle.Parameters.AddWithValue("@id_ObraSocial", SqlDbType.VarBinary).Value = System.Data.SqlTypes.SqlBinary.Null;
                            cmdDetalle.Parameters.AddWithValue("@id_Receta", SqlDbType.VarBinary).Value = System.Data.SqlTypes.SqlBinary.Null;
                        }
                        cmdDetalle.ExecuteNonQuery();
                        nroDetalle++;
                    }
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

        public List<Factura> ObtenerFacturas(List<Parámetro> lstParametros)
        {
            List<Factura> lstFacturas = new List<Factura>();

            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-FU6B6SN;Initial Catalog=Farmacia;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_CONSULTAR_FACTURAS", cnn);
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
                Factura oFactura = new Factura();

                Empleado oEmpleado = new Empleado();
                oEmpleado.oPersona.Nombre = dr["nombre_empleado"].ToString();
                oEmpleado.oPersona.Apellido = dr["apellido_empleado"].ToString();
                oEmpleado.IdEmpleado = Convert.ToInt32(dr["id_EmpleadoSuc"].ToString());

                Cliente oCliente = new Cliente();
                string nombre = dr["nombre_cliente"].ToString();
                string apellido = dr["apellido_cliente"].ToString();
                int documento = Convert.ToInt32(dr["documento"].ToString());
                oCliente.oPersona.Nombre = nombre;
                oCliente.oPersona.Apellido = apellido;
                oCliente.NroDocumento = documento;
                oFactura.oCliente = oCliente;

                Sucursal oSucursal = new Sucursal();
                oSucursal.IdSucursal = Convert.ToInt32(dr["id_Sucursal"].ToString());

                oFactura.IdFactura = int.Parse(dr["id_Factura"].ToString());
                oFactura.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                oFactura.oSucursal = oSucursal;
                oFactura.oEmpleado = oEmpleado;
                
                lstFacturas.Add(oFactura);
            }
            return lstFacturas;
        }

        public Factura ObtenerFacturas(int idFactura)
        {
            List<Parámetro> lstParametros = new List<Parámetro>();
            Factura oFactura = new Factura();
            Parámetro parametroId = new Parámetro("@Id_Factura", idFactura);
            lstParametros.Add(parametroId);

            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("sp_Consultar_Factura_id", lstParametros);

            foreach (DataRow dr in dt.Rows)
            {
                Empleado oEmpleado = new Empleado();
                oEmpleado.oPersona.Nombre = dr["nombre_empleado"].ToString();
                oEmpleado.oPersona.Apellido = dr["apellido_empleado"].ToString();
                oEmpleado.IdEmpleado = Convert.ToInt32(dr["id_EmpleadoSuc"].ToString());

                Cliente oCliente = new Cliente();
                string nombre = dr["nombre_cliente"].ToString();
                string apellido = dr["apellido_cliente"].ToString();
                int documento = Convert.ToInt32(dr["documento"].ToString());
                oCliente.oPersona.Nombre = nombre;
                oCliente.oPersona.Apellido = apellido;
                oCliente.NroDocumento = documento;
                oFactura.oCliente = oCliente;

                Sucursal oSucursal = new Sucursal();
                oSucursal.IdSucursal = Convert.ToInt32(dr["id_Sucursal"].ToString());

                oFactura.IdFactura = int.Parse(dr["id_Factura"].ToString());
                oFactura.Fecha = Convert.ToDateTime(dr["Fecha"].ToString());
                oFactura.oSucursal = oSucursal;
                oFactura.oEmpleado = oEmpleado;
            }
            return oFactura;
        }
        public List<DetalleFactura> ObtenerDetalles(int idFactura)
        {
            List<DetalleFactura> lstDetalles = new List<DetalleFactura>();
            List<Parámetro> lstParametros = new List<Parámetro>();
            Parámetro parametroId = new Parámetro("@Id", idFactura);
            lstParametros.Add(parametroId);
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("SP_CONSULTAR_DETALLES_FACTURA",lstParametros);
            foreach(DataRow dr in dt.Rows)
            {
                DetalleFactura oDetalle = new DetalleFactura();
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
                oDetalle.Precio = Convert.ToDecimal(dr["precio"].ToString());
                oDetalle.Cantidad = Convert.ToInt32(dr["cantidad"].ToString());

                lstDetalles.Add(oDetalle);
            }
            return lstDetalles;
        }
        public bool EliminarFactura(int id)
        {
            bool aux = false;
            string sp = "SP_ELIMINAR_FACTURA";
            List<Parámetro> lst = new List<Parámetro>();
            lst.Add(new Parámetro("@Id", id));
            int filasAfectadas = HelperDB.ObtenerInstancia().EjecutarSp(sp, lst);
            if(filasAfectadas > 0)
            {
                aux = true;
            }
            return aux;
        }
    }
}