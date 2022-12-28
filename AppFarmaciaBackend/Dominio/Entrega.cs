using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Entrega
    {
        public int IdEntrega { get; set; }
        public Sucursal oSucursal { get; set; }
        public DateTime Fecha { get; set; }
        public string EmpleadoLogistica { get; set; }

        public List<DetalleEntrega> Detalles { get; set; }

        public Empleado oEmpleado { get; set; }

        public Entrega()
        {
            Detalles = new List<DetalleEntrega>();
        }

        public void AgregarDetalle(DetalleEntrega oDetalle)
        {
            Detalles.Add(oDetalle);
        }

        public void EliminarDetalle(int nroDetalle)
        {
            Detalles.RemoveAt(nroDetalle);
        }

    }
}
