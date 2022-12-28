using AppFarmaciaBackend.Datos;
using AppFarmaciaBackend.Dominio;
using AppFarmaciaFrontend.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFarmaciaFrontend.Formularios
{
    public class ServicioObjetos
    {
        public async Task CargarInsumosAsync(ComboBox cboInsumo)
        {
            string url = "https://localhost:7240/insumos";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Insumo> lst = JsonConvert.DeserializeObject<List<Insumo>>(data);
            cboInsumo.DataSource = lst;
            cboInsumo.ValueMember = "IdInsumo";
            cboInsumo.DisplayMember = "Nombre";
        }

        public async Task CargarSucursalesAsync(ComboBox cboSucursal)
        {
            string url = "https://localhost:7240/sucursales";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Sucursal> lst = JsonConvert.DeserializeObject<List<Sucursal>>(data);
            cboSucursal.DataSource = lst;
            cboSucursal.ValueMember = "IdSucursal";
            cboSucursal.DisplayMember = "Nombre";
        }

        public async Task CargarEmpleadosAsync(ComboBox cboEmpleado)
        {
            string url = "https://localhost:7240/empleados";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<Empleado> lst = JsonConvert.DeserializeObject<List<Empleado>>(data);
            cboEmpleado.DataSource = lst;
            cboEmpleado.ValueMember = "IdEmpleado";
            cboEmpleado.DisplayMember = "oPersona";
        }
        public async Task CargarObrasSocialesAsync(ComboBox cboObraSocial)
        {
            string url = "https://localhost:7240/obrasSociales";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<ObraSocial> lst = JsonConvert.DeserializeObject<List<ObraSocial>>(data);
            cboObraSocial.DataSource = lst;
            cboObraSocial.ValueMember = "IdObraSocial";
            cboObraSocial.DisplayMember = "Nombre";
        }

        public async Task CargarTiposInsumosAsync(ComboBox cboTipoInsumo)
        {
            string url = "https://localhost:7240/tiposInsumos";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<TipoInsumo> lst = JsonConvert.DeserializeObject<List<TipoInsumo>>(data);
            cboTipoInsumo.DataSource = lst;
            cboTipoInsumo.ValueMember = "IdTipoInsumo";
            cboTipoInsumo.DisplayMember = "Nombre";
        }

        public async Task<List<DetalleFactura>> CargarDetallesFacturasAsync()
        {
            string url = "https://localhost:7240/detallesFacturasSegunId";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DetalleFactura> lst = JsonConvert.DeserializeObject<List<DetalleFactura>>(data);
            return lst;
        }
    }
}
