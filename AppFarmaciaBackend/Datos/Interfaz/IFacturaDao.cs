using AppFarmaciaBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Datos.Interfaz
{
    public interface IFacturaDao
    {
        int ObtenerProximaFactura();
        List<Insumo> ObtenerInsumos();
        List<ObraSocial> ObtenerObrasSociales();
        List<Empleado> ObtenerEmpleados();
        List<Sucursal> ObtenerSucursales();
        bool CrearFactura(Factura oFactura);
        bool CrearFacturaSinOs(Factura oFactura);
        List<Factura> ObtenerFacturas(List<Parámetro >lstParametros);
        bool EliminarFactura(int id);
        bool ActualizarFactura(Factura oFactura);
        Factura ObtenerFacturas(int idFactura);
        List<DetalleFactura> ObtenerDetalles(int idFactura);
    }
}
