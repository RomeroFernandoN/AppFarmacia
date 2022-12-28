using AppFarmaciaBackend.Datos;
using AppFarmaciaBackend.Datos.Implementación;
using AppFarmaciaBackend.Datos.Interfaz;
using AppFarmaciaBackend.Dominio;
using AppFarmaciaBackend.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaBackend.Servicios.Implementación
{
    public class Servicio : IServicio
    {
        private IFacturaDao facturaDao;
        private IEntregaDao entregaDao;
        private IInicioDao inicioDao;
        private IInsumoDao insumoDao;

        public Servicio()
        {
            facturaDao = new FacturaDao();
            entregaDao = new EntregaDao();
            inicioDao = new InicioDao();
            insumoDao = new InsumoDao();
        }
        public int ProximaFactura()
        {
            return facturaDao.ObtenerProximaFactura();
        }

        public List<Insumo> ObtenerInsumos()
        {
            return facturaDao.ObtenerInsumos();
        }

        public List<ObraSocial> ObtenerObrasSociales()
        {
            return facturaDao.ObtenerObrasSociales();
        }
        public List<Empleado> ObtenerEmpleados()
        {
            return facturaDao.ObtenerEmpleados();
        }
        public List<Sucursal> ObtenerSucursales()
        {
            return facturaDao.ObtenerSucursales();
        }

        public bool CrearFactura(Factura oFactura)
        {
            return facturaDao.CrearFactura(oFactura);
        }

        public int ProximaEntrega()
        {
            return entregaDao.ObtenerProximaEntrega();
        }

        public bool CrearEntrega(Entrega oEntrega)
        {
            return entregaDao.CrearEntrega(oEntrega);
        }

        public int ObtenerUsuario(Usuario oUsuario)
        {
            return inicioDao.ObtenerUsuario(oUsuario);
        }

        public List<Factura> ObtenerFacturas(List<Parámetro> lstParametros)
        {
            return facturaDao.ObtenerFacturas(lstParametros);
        }

        public bool EliminarFactura(int id)
        {
            return facturaDao.EliminarFactura(id);
        }

        public bool ActualizarFactura(Factura oFactura)
        {
            return facturaDao.ActualizarFactura(oFactura);
        }
        public Factura ObtenerFacturas(int idFactura)
        {
            return facturaDao.ObtenerFacturas(idFactura);
        }

        public List<DetalleFactura> ObtenerDetalles(int idFactura)
        {
            return facturaDao.ObtenerDetalles(idFactura);
        }
        public int ObtenerInsumo(string nombre)
        {
            return insumoDao.ObtenerInsumo(nombre);
        }

        public int ObtenerProximoInsumo()
        {
            return insumoDao.ObtenerProximoInsumo();
        }
        public bool InsModInsumo(Insumo oInsumo, string spNombre)
        {
            return insumoDao.InsModInsumo(oInsumo, spNombre);
        }
        public List<TipoInsumo> ObtenerTiposInsumos()
        {
            return insumoDao.ObtenerTiposInsumos();
        }

        public Insumo ObtenerInsumo(int idInsumo)
        {
            return insumoDao.ObtenerInsumo(idInsumo);
        }

        public bool DarBaja(int idInsumo)
        {
            return insumoDao.DarBaja(idInsumo);
        }

        public List<Entrega> ObtenerEntregas(List<Parámetro> lstParametros)
        {
            return entregaDao.ObtenerEntregas(lstParametros);
        }
        public bool EliminarEntrega(int id)
        {
            return entregaDao.EliminarEntrega(id);
        }
        public List<DetalleEntrega> ObtenerDetallesEntrega(int idEntrega)
        {
            return entregaDao.ObtenerDetallesEntrega(idEntrega);
        }
        public Entrega ObtenerEntrega(int idEntrega)
        {
            return entregaDao.ObtenerEntrega(idEntrega);
        }

        public bool ActualizarEntrega(Entrega oEntrega)
        {
            return entregaDao.ActualizarEntrega(oEntrega);
        }

    }
}
