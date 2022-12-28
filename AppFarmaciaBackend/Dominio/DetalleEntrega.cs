using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class DetalleEntrega
    {
        public int IdDetalle { get; set; }
        public Insumo oInsumo { get; set; }
        public int Cantidad {get; set; }
    }
}
