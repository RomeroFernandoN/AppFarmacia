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
    public partial class ModificarEntrega : Form
    {
        private IServicio oServicio;
        private ServicioObjetos oServicioObjetos;

        private Entrega oEntrega;
        private int idEntrega;
        public ModificarEntrega(int idEntrega, FabricaServicio oFabrica)
        {
            InitializeComponent();
            oServicio = oFabrica.CrearServicio();
            oEntrega = new Entrega();
            this.idEntrega = idEntrega;
            oServicioObjetos = new ServicioObjetos();
        }

        public async Task CargarCampos()
        {
            Entrega oEntrega = await ConsultarEntregas(this.idEntrega);
            txtNroEntrega.Text = oEntrega.IdEntrega.ToString();
            txtEmpleadoLogistica.Text = oEntrega.EmpleadoLogistica.ToString();

            dtpFechaEntrega.Value = oEntrega.Fecha;
            cboSucursal.SelectedValue = Convert.ToInt32(oEntrega.oSucursal.IdSucursal.ToString());
            cboEmpleado.SelectedValue = Convert.ToInt32(oEntrega.oEmpleado.IdEmpleado.ToString());

            List<DetalleEntrega> lstDetalles = await ConsultarDetallesEntrega(this.idEntrega);
            foreach (DetalleEntrega oDetalle in lstDetalles)
            {

                Insumo oInsumo = new Insumo();
                oInsumo.IdInsumo = oDetalle.oInsumo.IdInsumo;
                oInsumo.Nombre = oDetalle.oInsumo.Nombre;
                oInsumo.TipoVenta = oDetalle.oInsumo.TipoVenta;
                oInsumo.oTipoInsumo = oDetalle.oInsumo.oTipoInsumo;

                dgvInsumosPrevios.Rows.Add(new object[] { oInsumo.IdInsumo, oInsumo.Nombre, oDetalle.Cantidad });
            }

            gpInsumosPrevios.Enabled = false;
            GbSucursal.Enabled = false;
        }

        public async Task CargarCombos()
        {
            await oServicioObjetos.CargarSucursalesAsync(cboSucursal);
            await oServicioObjetos.CargarEmpleadosAsync(cboEmpleado);
            await oServicioObjetos.CargarInsumosAsync(cboInsumo);
        }

        private async Task<List<DetalleEntrega>> ConsultarDetallesEntrega(int idEntrega)
        {

            string url = "https://localhost:7240/detallesEntregasSegunId" + "?idEntrega=" + idEntrega.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            List<DetalleEntrega> lstDetallesEntregas = JsonConvert.DeserializeObject<List<DetalleEntrega>>(data);

            return lstDetallesEntregas;
        }

        private async Task<Entrega> ConsultarEntregas(int idEntrega)
        {

            string url = "https://localhost:7240/entregaSegunId" + "?idEntrega=" + idEntrega.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            Entrega oEntrega = JsonConvert.DeserializeObject<Entrega>(data);

            return oEntrega;
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

            if (dtpFechaFabricacion.Value == DateTime.Now)
            {
                MessageBox.Show("Debe ingresar fecha de fabricación.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            return;
                        }
                    }
                }
            }

            DetalleEntrega oDetalle = new DetalleEntrega();
            Insumo oInsumo = (Insumo)cboInsumo.SelectedItem;

            oDetalle.oInsumo = oInsumo;
            oDetalle.Cantidad = nuevaCantidad;

            oEntrega.Detalles.Add(oDetalle);
            dgvInsumos.Rows.Add(new object[] { oInsumo.IdInsumo, oInsumo.Nombre, nuevaCantidad });
        }

        public bool Validar()
        {
            bool aux = true;

            //Datos insumos
            if (dgvInsumos.Rows.Count == 0)
            {
                aux = false;
            }
            if (oEntrega.Detalles.Count == 0)
            {
                aux = false;
            }
            if (aux == false)
            {
                MessageBox.Show("Debe tener al menos un insumo agregado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return aux;
        }

        public void Limpiar()
        {
            dtpFechaFabricacion.Value = DateTime.Now;
            cboInsumo.SelectedIndex = -1;
            nudCantidadInsumos.Value = 0;
            dgvInsumos.Rows.Clear();
        }

        private async Task<bool> ActualizarEntrega(Entrega oEntrega)
        {
            string entrega = JsonConvert.SerializeObject(oEntrega);
            string url = "https://localhost:7240/actualizarEntrega";
            var data = await ClienteSingleton.ObtenerInstancia().PostAsync(url, entrega);
            bool v = JsonConvert.DeserializeObject<bool>(data);

            return v;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                oEntrega.EmpleadoLogistica = txtEmpleadoLogistica.Text;
                oEntrega.oSucursal = (Sucursal)cboSucursal.SelectedItem;
                oEntrega.IdEntrega = Convert.ToInt32(txtNroEntrega.Text);
                oEntrega.Fecha = DateTime.Now;
                oEntrega.oEmpleado = (Empleado)cboEmpleado.SelectedItem;

                if (await ActualizarEntrega(oEntrega))
                {
                    MessageBox.Show("Entrega modificada.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                    txtNroEntrega.Text = Convert.ToString(oServicio.ProximaEntrega());
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al modificar entrega.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private async void ModificarEntrega_Load(object sender, EventArgs e)
        {
            Limpiar();
            await CargarCombos();
            await CargarCampos();
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInsumos.CurrentCell.ColumnIndex == 3)
            {
                oEntrega.EliminarDetalle(dgvInsumos.CurrentRow.Index);
                dgvInsumos.Rows.Remove(dgvInsumos.CurrentRow);
            }
        }
    }
}



