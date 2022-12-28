using AppFarmaciaBackend.Datos;
using AppFarmaciaBackend.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Servicios.Interfaz
{
    public interface IServicio
    {
        int ProximaFactura(); 
        List<Insumo> ObtenerInsumos(); 
        List<ObraSocial> ObtenerObrasSociales();  
        List<Empleado> ObtenerEmpleados(); 
        List<Sucursal> ObtenerSucursales();  
        bool CrearFactura(Factura oFactura); 
        bool ActualizarFactura(Factura oFactura); 
        List<DetalleFactura> ObtenerDetalles(int idFactura);  

        int ProximaEntrega(); 
        bool CrearEntrega(Entrega oEntrega); 
        int ObtenerUsuario(Usuario usuario); 
        List<Factura> ObtenerFacturas(List<Parámetro> lstParametros);  
        bool EliminarFactura(int id); 
        Factura ObtenerFacturas(int idFactura); 

        int ObtenerInsumo(string nombre); 
        int ObtenerProximoInsumo(); 
        bool InsModInsumo(Insumo oInsumo, string spNombre); 
        List<TipoInsumo> ObtenerTiposInsumos(); 
        Insumo ObtenerInsumo(int idInsumo);
        bool DarBaja(int idInsumo);

        List<Entrega> ObtenerEntregas(List<Parámetro> lstParametros); 
        bool EliminarEntrega(int id); 
        List<DetalleEntrega> ObtenerDetallesEntrega(int idEntrega);
        Entrega ObtenerEntrega(int idEntrega); 
        bool ActualizarEntrega(Entrega oEntrega);
    }
}
