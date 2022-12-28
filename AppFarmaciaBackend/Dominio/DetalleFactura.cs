using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class DetalleFactura
    {
        public int? IdDetalleFactura { get; set; }
        public Receta? oReceta { get; set; }
        public Insumo oInsumo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public ObraSocial? oObraSocial { get; set; }

        public DetalleFactura()
        {
            oReceta = new Receta();
        }

        public decimal CalcularSubTotal()
        {
            return this.oInsumo.Precio * Cantidad;
        }
       
    }
}
