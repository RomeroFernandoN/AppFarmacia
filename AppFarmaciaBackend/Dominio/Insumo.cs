using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Insumo
    {
        public int IdInsumo { get; set; }
        public string Nombre { get; set; }
        public int TipoVenta { get; set; }
        public TipoInsumo oTipoInsumo { get; set; }
        public decimal Precio { get; set; }

        public Insumo(int idInsumo, string nombre, int tipoVenta, TipoInsumo tipoInsumo, decimal precio)
        {
            IdInsumo = idInsumo;
            Nombre = nombre;
            TipoVenta = tipoVenta;
            oTipoInsumo = tipoInsumo;
            Precio = precio;
        }

        public Insumo()
        {
        }
    }
}
