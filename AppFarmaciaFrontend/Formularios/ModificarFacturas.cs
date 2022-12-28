using AppFarmaciaBackend.Dominio;
using AppFarmaciaBackend.Servicios;
using AppFarmaciaBackend.Servicios.Interfaz;
using AppFarmaciaFrontend.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFarmaciaFrontend.Formularios
{
    public partial class ModificarFacturas : Form
    {
        private IServicio oServicio;
        private ServicioObjetos oServicioObjetos;

        private Factura oFactura;
        private int idFactura;
        private decimal monto;
        public ModificarFacturas(int idFactura, FabricaServicio oFabrica)
        {
            InitializeComponent();
            oServicio = oFabrica.CrearServicio();
            oFactura = new Factura();
            this.idFactura = idFactura;
            oServicioObjetos = new ServicioObjetos();
        }

        private async void ModificarFacturas_Load(object sender, EventArgs e)
        {
            await CargarCombos();
            await CargarCampos();
        }

        private async Task<List<DetalleFactura>> ConsultarDetallesFacturas(int idFactura)
        {

            string url = "https://localhost:7240/detallesFacturasSegunId" + "?idFactura=" + idFactura.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DetalleFactura> lstDetallesFacturas = JsonConvert.DeserializeObject<List<DetalleFactura>>(data);

            return lstDetallesFacturas;
        }

        private async Task<Factura> ConsultarFacturas(int idFactura)
        {

            string url = "https://localhost:7240/facturaSegunId" + "?idFactura=" + idFactura.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            Factura oFactura = JsonConvert.DeserializeObject<Factura>(data);

            return oFactura;
        }

        public async Task CargarCampos()
        {
            Factura oFactura = await ConsultarFacturas(this.idFactura);
            txtNroFactura.Text = oFactura.IdFactura.ToString();
            txtApellidoCli.Text = oFactura.oCliente.oPersona.Apellido.ToString();
            txtNombreCli.Text = oFactura.oCliente.oPersona.Nombre.ToString();
            txtNroDocCli.Text = oFactura.oCliente.NroDocumento.ToString();

            dtpFecha.Value = oFactura.Fecha;
            cboSucursal.SelectedIndex = Convert.ToInt32(oFactura.oSucursal.IdSucursal.ToString()) - 1;
            cboEmpleado.SelectedValue = Convert.ToInt32(oFactura.oEmpleado.IdEmpleado.ToString());

            List<DetalleFactura> lstDetalles = await ConsultarDetallesFacturas(this.idFactura);
            foreach (DetalleFactura oDetalle in lstDetalles)
            {

                Insumo oInsumo = new Insumo();
                oInsumo.IdInsumo = oDetalle.oInsumo.IdInsumo;
                oInsumo.Nombre = oDetalle.oInsumo.Nombre;
                oInsumo.TipoVenta = oDetalle.oInsumo.TipoVenta;
                oInsumo.oTipoInsumo = oDetalle.oInsumo.oTipoInsumo;
                oInsumo.Precio = oDetalle.Precio;
                
                dgvInsumosPrevios.Rows.Add(new object[] { oInsumo.IdInsumo, oInsumo.Nombre, oDetalle.Cantidad });
            }

            gpInsumosPrevios.Enabled = false;
            GbCliente.Enabled = false;
            GbSucursal.Enabled = false;
        }
        public async Task CargarCombos()
        {
            await oServicioObjetos.CargarSucursalesAsync(cboSucursal);
            await oServicioObjetos.CargarEmpleadosAsync(cboEmpleado);
            await oServicioObjetos.CargarInsumosAsync(cboInsumo);
        }
        public bool ValidarCampos()
        {
            bool aux = true;

            //Datos insumos
            if (dgvInsumos.Rows.Count == 0)
            {
                aux = false;
            }
            if (oFactura.Detalles.Count == 0)
            {
                aux = false;
            }
            if (aux == false)
            {
                MessageBox.Show("Debe tener al menos un insumo agregado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return aux;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            if (cboInsumo.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un insumo.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudCantidadInsumos.Value == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad del insumo.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nuevaCantidad = (int)nudCantidadInsumos.Value;

            if (dgvInsumos.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dgvInsumos.Rows)
                {
                    if (row.Cells["colItem"].Value != null)
                    {
                        if ((row.Cells["colItem"].Value.ToString()) == cboInsumo.SelectedValue.ToString())
                        {
                            MessageBox.Show("Se sumo la nueva cantidad al insumo cargado previamente.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            nuevaCantidad = (Convert.ToInt32(row.Cells["colCantidad"].Value.ToString()) + (int)nudCantidadInsumos.Value);
                            row.Cells["colCantidad"].Value = nuevaCantidad;
                            Insumo oIn = (Insumo)cboInsumo.SelectedItem;
                            int cantidad = (int)nudCantidadInsumos.Value;
                            oFactura.ModificarDetalles(cantidad, oIn);
                            CalcularTotal(0);
                            return;
                        }
                    }
                }
            }

            DetalleFactura oDetalle = new DetalleFactura();
            Insumo oInsumo = (Insumo)cboInsumo.SelectedItem;

                oDetalle.oObraSocial = null;
                oDetalle.oReceta = null;
                oDetalle.oInsumo = null;

            oDetalle.oInsumo = oInsumo;
            oDetalle.Cantidad = nuevaCantidad;
            oDetalle.Precio = oInsumo.Precio;

            oFactura.AgregarDetalle(oDetalle);
            CalcularTotal(0);
            dgvInsumos.Rows.Add(new object[] { oInsumo.IdInsumo, oInsumo.Nombre, nuevaCantidad });
        }

        private async Task<bool> ActualizarFactura(Factura oFactura)
        {
            string factura = JsonConvert.SerializeObject(oFactura);
            string url = "https://localhost:7240/actualizarFactura";
            var data = await ClienteSingleton.ObtenerInstancia().PostAsync(url, factura);
            bool v = JsonConvert.DeserializeObject<bool>(data);

            return v;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AppFarmaciaBackend.Dominio.Cliente oCliente = new AppFarmaciaBackend.Dominio.Cliente();
                oCliente.oPersona.Nombre = txtNombreCli.Text;
                oCliente.oPersona.Apellido = txtApellidoCli.Text;
                oCliente.NroDocumento = Convert.ToInt32(txtNroDocCli.Text);

                Sucursal oSucursal = (Sucursal)cboSucursal.SelectedItem;
                oFactura.oEmpleado = (Empleado)cboEmpleado.SelectedItem;

                oFactura.oCliente = oCliente;
                oFactura.oSucursal = oSucursal;
                oFactura.Fecha = dtpFecha.Value;

                oFactura.IdFactura = Convert.ToInt32(txtNroFactura.Text);

                if (await ActualizarFactura(oFactura))
                {
                    MessageBox.Show("Factura modificada.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al modificar factura.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInsumos.CurrentCell.ColumnIndex == 3)
            {
                oFactura.EliminarDetalle(dgvInsumos.CurrentRow.Index);
                dgvInsumos.Rows.Remove(dgvInsumos.CurrentRow);
                CalcularTotal(0);
            }
        }
        public void CalcularTotal(decimal MásCantidad)
        {
            monto = oFactura.CalcularTotal() + MásCantidad;
            txtMonto.Text = "$" + Convert.ToString(monto);
        }
    }
}
