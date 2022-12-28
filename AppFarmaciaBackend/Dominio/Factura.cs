using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Dominio
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Sucursal oSucursal { get; set; }
        public Cliente oCliente { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
        public Empleado oEmpleado { get; set; }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura oDetalle)
        {
            Detalles.Add(oDetalle);
        }
        public void EliminarDetalle(int nroDetalle)
        {
            Detalles.RemoveAt(nroDetalle);
        }
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (DetalleFactura oDetalle in Detalles)
            {
                total += oDetalle.CalcularSubTotal();
            }
            return total;
        }

        public void ModificarDetalles(int cantidad, Insumo oInsumo)
        {
            foreach(DetalleFactura oDetalle in Detalles)
            {
                if(oDetalle.oInsumo == oInsumo)
                {
                    oDetalle.Cantidad = oDetalle.Cantidad + cantidad;
                }
            }
        }
    }
}
