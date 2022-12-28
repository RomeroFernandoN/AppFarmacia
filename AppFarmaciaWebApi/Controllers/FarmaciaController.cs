using AppFarmaciaBackend.Datos;
using AppFarmaciaBackend.Dominio;
using AppFarmaciaBackend.Servicios.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppFarmaciaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmaciaController : ControllerBase
    {

        private IServicio oServicio;

        public FarmaciaController()
        {
            oServicio = new AppFarmaciaBackend.Servicios.Implementación.Servicio();
        }

        [HttpGet("/insumos")]
        public IActionResult GetInsumos()
        {
            List<Insumo> lstInsumos;
            try
            {
                lstInsumos = oServicio.ObtenerInsumos();
                return Ok(lstInsumos);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/empleados")]
        public IActionResult GetEmpleados()
        {
            List<Empleado> lstEmpleados;
            try
            {
                lstEmpleados = oServicio.ObtenerEmpleados();
                return Ok(lstEmpleados);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/sucursales")]
        public IActionResult GetSucursales()
        {
            List<Sucursal> lstSucursales;
            try
            {
                lstSucursales = oServicio.ObtenerSucursales();
                return Ok(lstSucursales);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/obrasSociales")]
        public IActionResult GetObrasSociales()
        {
            List<ObraSocial> lstObrasSociales;
            try
            {
                lstObrasSociales = oServicio.ObtenerObrasSociales();
                return Ok(lstObrasSociales);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }


        [HttpGet("/detallesFacturasSegunId")]
        public IActionResult GetDetallesFacturasSegunId(int idFactura)
        {
            List<DetalleFactura> lstDetalleFacturas;
            try
            {
                lstDetalleFacturas = oServicio.ObtenerDetalles(idFactura);
                return Ok(lstDetalleFacturas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/proximaFactura")]
        public IActionResult GetProximaFactura()
        {
            int idProximaFactura;
            try
            {
                idProximaFactura = oServicio.ProximaFactura();
                return Ok(idProximaFactura);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/proximaEntrega")]
        public IActionResult GetProximaEntrega()
        {
            int idProximaEntrega;
            try
            {
                idProximaEntrega = oServicio.ProximaEntrega();
                return Ok(idProximaEntrega);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpPost("/facturasSegunFecha")]
        public IActionResult GetFacturasSegunFecha(List<Parámetro> lstParametro)
        {
            List<Factura> lstFacturas;
            try
            {
                lstFacturas = oServicio.ObtenerFacturas(lstParametro);
                return Ok(lstFacturas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }


        [HttpGet("/facturaSegunId")]
        public IActionResult GetFacturaSegunId(int idFactura)
        {
            Factura oFactura;
            try
            {
                oFactura = oServicio.ObtenerFacturas(idFactura);
                return Ok(oFactura);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }


        [HttpGet("/insumoSegunId")]
        public IActionResult GetInsumoSegunId(int idInsumo)
        {
            Insumo oInsumo;
            try
            {
                oInsumo = oServicio.ObtenerInsumo(idInsumo);
                return Ok(oInsumo);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/insumoSegunNombre")]
        public IActionResult GetInsumoSegunNombre(string nombre)
        {
            int oInsumo;
            try
            {
                oInsumo = oServicio.ObtenerInsumo(nombre);
                return Ok(oInsumo);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/proximoInsumo")]
        public IActionResult GetProximoInsumo()
        {
            int oInsumo;
            try
            {
                oInsumo = oServicio.ObtenerProximoInsumo();
                return Ok(oInsumo);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }


        [HttpGet("/tiposInsumos")]
        public IActionResult GetTiposInsumos()
        {
            List<TipoInsumo> lstTiposInsumos;
            try
            {
                lstTiposInsumos = oServicio.ObtenerTiposInsumos();
                return Ok(lstTiposInsumos);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpPost("/entregasSegunFecha")]
        public IActionResult PostEntregasSegunFecha(List<Parámetro> lstParametro)
        {
            List<Entrega> lstEntregas;
            try
            {
                lstEntregas = oServicio.ObtenerEntregas(lstParametro);
                return Ok(lstEntregas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/detallesEntregasSegunId")]
        public IActionResult GetDetallesEntregaSegunId(int idEntrega)
        {
            List<DetalleEntrega> lstDetalleEntregas;
            try
            {
                lstDetalleEntregas = oServicio.ObtenerDetallesEntrega(idEntrega);
                return Ok(lstDetalleEntregas);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpGet("/entregaSegunId")]
        public IActionResult GetEntregaSegunId(int idEntrega)
        {
            Entrega oEntrega;
            try
            {
                oEntrega = oServicio.ObtenerEntrega(idEntrega);
                return Ok(oEntrega);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpPost("/usuario")]
        public IActionResult GetUsuario(Usuario oUsuario)
        {
            int usuario;
            try
            {
                usuario = oServicio.ObtenerUsuario(oUsuario);
                return Ok(usuario);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        /*Post*/

        [HttpPost("/registroEntrega")]
        public IActionResult PostRegistroEntrega(Entrega oEntrega)
        {
            try
            {
                if (oEntrega == null)
                {
                    return BadRequest("Datos de carrera incorrectos!");
                }

                return Ok(oServicio.CrearEntrega(oEntrega));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/actualizarEntrega")]
        public IActionResult PostActualizarEntrega(Entrega oEntrega)
        {
            try
            {
                if (oEntrega == null)
                {
                    return BadRequest("Datos de carrera incorrectos!");
                }

                return Ok(oServicio.ActualizarEntrega(oEntrega));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/registroFactura")]
        public IActionResult PostRegistroFactura(Factura oFactura)
        {
            try
            {
                if (oFactura == null)
                {
                    return BadRequest("Datos de carrera incorrectos!");
                }

                return Ok(oServicio.CrearFactura(oFactura));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/actualizarFactura")]
        public IActionResult PostActualizarFactura(Factura oFactura)
        {
            try
            {
                if (oFactura == null)
                {
                    return BadRequest("Datos de carrera incorrectos!");
                }

                return Ok(oServicio.ActualizarFactura(oFactura));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpPost("/registrarInsumo")]
        public IActionResult PostRegistrarInsumo(Insumo oInsumo, string spNombre)
        {
            try
            {
                if (oInsumo == null && spNombre == null)
                {
                    return BadRequest("Datos de carrera incorrectos!");
                }

                return Ok(oServicio.InsModInsumo(oInsumo,spNombre));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        
        /*Delete*/

        [HttpDelete("/eliminarFactura")]
        public IActionResult DelEliminarFactura(int idFactura)
        {
            bool eliminar;
            try
            {
                eliminar = oServicio.EliminarFactura(idFactura);
                return Ok(eliminar);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        [HttpDelete("/eliminarEntrega")]
        public IActionResult DelEliminarEntrega(int idEntrega)
        {
            bool eliminar;
            try
            {
                eliminar = oServicio.EliminarEntrega(idEntrega);
                return Ok(eliminar);
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego.");
            }
        }

        /*Put*/

        [HttpPut("/modificarInsumo")]
        public IActionResult PutModificarInsumo(Insumo oInsumo, string spNombre)
        {
            try
            {
                if (oInsumo == null && spNombre == null)
                {
                    return BadRequest("Datos de carrera incorrectos!");
                }

                return Ok(oServicio.InsModInsumo(oInsumo, spNombre));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpDelete("/darBajaInsumo")]
        public IActionResult PutDarBajaInsumo(int idInsumo)
        {
            try
            {
                if (idInsumo <= 0)
                {
                    return BadRequest("Datos de carrera incorrectos!");
                }

                return Ok(oServicio.DarBaja(idInsumo));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }
    }
}
