using AppFarmaciaBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Datos.Interfaz
{
    public interface IInsumoDao
    {
        int ObtenerInsumo(string nombre);
        int ObtenerProximoInsumo();
        bool InsModInsumo(Insumo oInsumo, string spNombre);
        List<TipoInsumo> ObtenerTiposInsumos();
        Insumo ObtenerInsumo(int idInsumo);

        bool DarBaja(int idInsumo);
    }

}
