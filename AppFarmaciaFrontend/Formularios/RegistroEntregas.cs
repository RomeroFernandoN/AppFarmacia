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
    public partial class RegistroEntregas : Form
    {
        private IServicio oServicio;
        private ServicioObjetos oServicioObjetos;

        private Entrega oEntrega;
        public RegistroEntregas(FabricaServicio oFabrica)
        {
            InitializeComponent();
            oServicio = oFabrica.CrearServicio();
            oEntrega = new Entrega();
            oServicioObjetos = new ServicioObjetos();
        }

        private async void RegistroEntregas_Load(object sender, EventArgs e)
        {
            await ProximaEntrega();
            await CargarCombos();
            Limpiar();
        }

        private async Task<int> ConsultarProximaEntrega()
        {
            string url = "https://localhost:7240/proximaEntrega";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            int v = JsonConvert.DeserializeObject<int>(data);

            return v;
        }

        public async Task ProximaEntrega()
        {
            int proximaEntrega = Convert.ToInt32(await ConsultarProximaEntrega());
            if (proximaEntrega > 0)
            {
                txtNroEntrega.Text = proximaEntrega.ToString();
            }
            else
            {
                MessageBox.Show("No se puede obtener el número de la próxima entrega.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task CargarCombos()
        {
            await oServicioObjetos.CargarSucursalesAsync(cboSucursal);
            await oServicioObjetos.CargarEmpleadosAsync(cboEmpleado);
            await oServicioObjetos.CargarInsumosAsync(cboInsumo);

        }

        public void Limpiar()
        {
            cboEmpleado.SelectedIndex = -1;
            cboSucursal.SelectedIndex = -1;
            dtpFechaEntrega.Value = DateTime.Now;
            dtpFechaFabricacion.Value = DateTime.Now;
            cboInsumo.SelectedIndex = -1;
            nudCantidadInsumos.Value = 0;
            dgvInsumos.Rows.Clear();
            txtEmpleadoLogistica.Text = "";
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            if(cboInsumo.Text.Equals(String.Empty))
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
            dgvInsumos.Rows.Add(new object[] { oInsumo.IdInsumo, oInsumo.Nombre, nuevaCantidad});
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        public bool Validar()
        {
            int validar = 0;
            bool aux = true;

            if (cboEmpleado.Text.Equals(String.Empty))
            {
                validar = 1;
            }
            if (cboSucursal.Text.Equals(String.Empty))
            {
                validar = 1;
            }
            if (dtpFechaEntrega.Value > DateTime.Now)
            {
                validar = 1;
            }
            if (string.IsNullOrEmpty(txtEmpleadoLogistica.Text))
            {
                validar = 1;
            }

            if (dgvInsumos.Rows.Count == 0)
            {
                validar = 2;
            }

            if(oEntrega.Detalles.Count == 0)
            {
                validar = 2;
            }

            switch (validar)
            {
                case 1:
                    {
                        MessageBox.Show("Complete los datos de la sucursal.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = false;
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Debe tener al menos un insumo agregado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = false;
                        break;
                    }
            }
            return aux;
        }
        private async Task<bool> InsertarEntrega(Entrega oEntrega)
        {
            string entrega = JsonConvert.SerializeObject(oEntrega);
            string url = "https://localhost:7240/registroEntrega";
            var data = await ClienteSingleton.ObtenerInstancia().PostAsync(url, entrega);
            bool v = JsonConvert.DeserializeObject<bool>(data);

            return v;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                oEntrega.EmpleadoLogistica = txtEmpleadoLogistica.Text;
                oEntrega.oSucursal = (Sucursal)cboSucursal.SelectedItem;
                oEntrega.IdEntrega = Convert.ToInt32(txtNroEntrega.Text);
                oEntrega.Fecha = DateTime.Now;
                oEntrega.oEmpleado = (Empleado)cboEmpleado.SelectedItem;

                if (await InsertarEntrega(oEntrega))
                {
                    MessageBox.Show("Entrega registrada.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al crear entrega.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                oEntrega.EliminarDetalle(dgvInsumos.CurrentRow.Index);
                dgvInsumos.Rows.Remove(dgvInsumos.CurrentRow);
            }
        }
    }
}
