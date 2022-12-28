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
    public class InsumoDao : IInsumoDao
    {
        int IInsumoDao.ObtenerInsumo(string nombre)
        {
            List<Parámetro> lstParametros = new List<Parámetro>();
            Parámetro parametro = new Parámetro("@Nombre",nombre);
            lstParametros.Add(parametro);
            int id = HelperDB.ObtenerInstancia().ConsultaEscalarConParametros("SP_BUSCAR_INSUMO","@Id",lstParametros);
            return id;
        }

        public int ObtenerProximoInsumo()
        {
            return HelperDB.ObtenerInstancia().ConsultaEscalar("SP_PROXIMO_INSUMO", "@NRO_INSUMO");
        }

        public bool InsModInsumo(Insumo oInsumo, string spNombre)
        {
            bool aux = true;
            SqlConnection cnn = HelperDB.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();

                SqlCommand cmdInsumo = new SqlCommand(spNombre, cnn, t);
                cmdInsumo.CommandType = CommandType.StoredProcedure;
                cmdInsumo.Parameters.AddWithValue("@Id", oInsumo.IdInsumo);
                cmdInsumo.Parameters.AddWithValue("@Nombre",oInsumo.Nombre );
                bool venta = false;
                if(oInsumo.TipoVenta == 1)
                {
                    venta = true;
                }
                cmdInsumo.Parameters.AddWithValue("@Tipo_Venta",venta);
                cmdInsumo.Parameters.AddWithValue("@Precio",oInsumo.Precio);
                cmdInsumo.Parameters.AddWithValue("@Tipo_Insumo", oInsumo.oTipoInsumo.IdTipoInsumo);
                cmdInsumo.ExecuteNonQuery();

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

        public List<TipoInsumo> ObtenerTiposInsumos()
        {
            List<TipoInsumo> lstTipoInsumo = new List<TipoInsumo>();
            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("sp_consultar_tipos_insumos", null);
            foreach (DataRow dr in dt.Rows)
            {
                TipoInsumo oTipoInsumo = new TipoInsumo();
                oTipoInsumo.IdTipoInsumo = int.Parse(dr["id_TipoInsumo"].ToString());
                oTipoInsumo.Nombre = dr["nombre"].ToString();

                lstTipoInsumo.Add(oTipoInsumo);
            }
            return lstTipoInsumo;
        }

        public Insumo ObtenerInsumo(int idInsumo)
        {
            Insumo oInsumo = new Insumo();
            List<Parámetro> lstParametros = new List<Parámetro>();
            Parámetro parametroId = new Parámetro("@Id_Insumo", idInsumo);
            lstParametros.Add(parametroId);

            DataTable dt = HelperDB.ObtenerInstancia().ConsultaTabla("sp_Consultar_Insumos_id", lstParametros);

            foreach (DataRow dr in dt.Rows)
            {
                oInsumo.IdInsumo = idInsumo;
                oInsumo.Nombre = dr["insumo"].ToString();
                bool venta = bool.Parse(dr["venta_libre"].ToString());
                int tipoInsumo = int.Parse(dr["id_TipoInsumo"].ToString());
                oInsumo.Precio = decimal.Parse(dr["pre_unitario"].ToString());
                int tipoVenta;
                if (venta)
                {
                    tipoVenta = 1;
                }
                else
                {
                    tipoVenta = 0;
                }
                TipoInsumo oTipoInsumo = new TipoInsumo(tipoInsumo);
                oInsumo.TipoVenta = tipoVenta;
                oInsumo.oTipoInsumo = oTipoInsumo;
            }
            return oInsumo;
        }

        public bool DarBaja(int idInsumo)
        {
            bool aux = false;
            Parámetro oParametro = new Parámetro("@Id",idInsumo);
            List<Parámetro> lstParametros = new List<Parámetro>();
            lstParametros.Add(oParametro);
            if(HelperDB.ObtenerInstancia().EjecutarSp("sp_dar_baja",lstParametros) > 0)
            {
                aux = true;
            }
            return aux;
        }
    }
}
