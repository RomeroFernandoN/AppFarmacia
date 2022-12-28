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
    public partial class FormFactura : Form
    {
        private IServicio oServicio;
        private ServicioObjetos oServicioObjetos;

        private Factura oFactura;
        private bool obraSocial = false;
        private decimal monto;
        public FormFactura(FabricaServicio oFabrica)
        {
            InitializeComponent();
            oServicio = oFabrica.CrearServicio();
            oFactura = new Factura();
            oServicioObjetos = new ServicioObjetos();
        }

        private async void FormFactura_Load(object sender, EventArgs e)
        {
            await ProximaFactura();
            await CargarCampos();
            GbReceta.Enabled = false;
            Limpiar();
        }

        private async Task<int> ConsultarProximaFactura()
        {
            string url = "https://localhost:7240/proximaFactura";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            int v = JsonConvert.DeserializeObject<int>(data);

            return v;
        }

        public async Task ProximaFactura()
        {
            int proximaFactura = Convert.ToInt32(await ConsultarProximaFactura());
            if (proximaFactura > 0)
            {
                txtNroFactura.Text = proximaFactura.ToString();
            }
            else
            {
                MessageBox.Show("No se puede obtener el número de la próxima factura.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task CargarCampos()
        {
            await oServicioObjetos.CargarObrasSocialesAsync(cboObraSocial);
            await oServicioObjetos.CargarSucursalesAsync(cboSucursal);
            await oServicioObjetos.CargarEmpleadosAsync(cboEmpleado);
            await oServicioObjetos.CargarInsumosAsync(cboInsumo);
        }

        public bool ValidarReceta()
        {
            bool aux = true;
            if (obraSocial)
            {
                if (string.IsNullOrEmpty(txtNombreMed.Text))
                {
                    aux = false;
                }
                if (string.IsNullOrEmpty(txtApellidoMed.Text))
                {
                    aux = false;
                }
                if (txtMatriculaMed.Text == "")
                {
                    aux = false;
                }
                try
                {
                    if (txtMatriculaMed.Text != "")
                    {
                        int.Parse(txtMatriculaMed.Text);
                    }
                }
                catch
                {
                    aux = false;
                }
                if (string.IsNullOrEmpty(txtDianostico.Text))
                {
                    aux = false;
                }
                if (cboObraSocial.Text.Equals(String.Empty))
                {
                    aux = false;
                }
            }
            return aux;
        }

        public bool ValidarCampos()
        {
            int validar = 0;
            bool aux = true;
            //Datos cliente
            if (string.IsNullOrEmpty(txtNombreCli.Text))
            {
                validar = 1;
            }
            if (string.IsNullOrEmpty(txtApellidoCli.Text))
            {
                validar = 1;
            }
            if (txtNroDocCli.Text == "")
            {
                validar = 1;
            }
            try
            {
                if (txtNroDocCli.Text != "")
                {
                    int.Parse(txtNroDocCli.Text);
                }
            }
            catch
            {
                validar = 1;
            }

            //Datos insumos
            if (dgvInsumos.Rows.Count == 0)
            {
                validar = 2;
            }
            if (oFactura.Detalles.Count == 0)
            {
                validar = 2;
            }

            //Datos sucursal
            if (cboEmpleado.Text.Equals(String.Empty))
            {
                validar = 3;
            }
            if (cboSucursal.Text.Equals(String.Empty))
            {
                validar = 3;
            }
            if (dtpFecha.Value > DateTime.Now)
            {
                validar = 3;
            }

            if (ValidarReceta() == false)
            {
                validar = 4;
            }

            switch (validar)
            {
                case 1:
                    {
                        MessageBox.Show("Complete los datos del cliente.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = false;
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Debe tener al menos un insumo agregado.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = false;
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Complete los datos de la sucursal.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = false;
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("Complete los datos de la receta.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = false;
                        break;
                    }
            }
            return aux;
        }

        public void Limpiar()
        {
            txtNombreMed.Text = "";
            txtApellidoMed.Text = "";
            txtMatriculaMed.Text = "";
            txtDianostico.Text = "";
            cboObraSocial.SelectedIndex = -1;
            txtNombreCli.Text = "";
            txtApellidoCli.Text = "";
            txtNroDocCli.Text = "";
            cboEmpleado.SelectedIndex = -1;
            cboSucursal.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            cboInsumo.SelectedIndex = -1;
            nudCantidadInsumos.Value = 0;
            dgvInsumos.Rows.Clear();
        }

        private void GbReceta_Enter(object sender, EventArgs e)
        {

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
            if (obraSocial)
            {
                if (ValidarReceta() == false)
                {
                    MessageBox.Show("Complete los datos de la receta.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

            if (obraSocial)
            {
                if (ValidarReceta())
                {
                    oDetalle.oObraSocial = (ObraSocial)cboObraSocial.SelectedItem;
                    oDetalle.oReceta.oMedico.oPersona.Nombre = txtNombreMed.Text;
                    oDetalle.oReceta.oMedico.oPersona.Apellido = txtApellidoMed.Text;
                    oDetalle.oReceta.oMedico.Matricula = Convert.ToInt32(txtMatriculaMed.Text);
                    oDetalle.oReceta.Diagnostico = txtDianostico.Text;
                    oDetalle.oReceta.oInsumo = oInsumo;
                }
            }
            else
            {
                oDetalle.oObraSocial = null;
                oDetalle.oReceta = null;
                oDetalle.oInsumo = null;
            }
            oDetalle.oInsumo = oInsumo;
            oDetalle.Cantidad = nuevaCantidad;
            oDetalle.Precio = oInsumo.Precio;

            oFactura.AgregarDetalle(oDetalle);
            CalcularTotal(0);
            dgvInsumos.Rows.Add(new object[] { oInsumo.IdInsumo, oInsumo.Nombre, nuevaCantidad });
        }

        private async Task<bool> InsertarFactura(Factura oFactura)
        {
            string factura = JsonConvert.SerializeObject(oFactura);
            string url = "https://localhost:7240/registroFactura";
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

                    if (await InsertarFactura(oFactura))
                {
                    MessageBox.Show("Factura registrada.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Limpiar();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al crear factura.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CbObraSocial_CheckedChanged(object sender, EventArgs e)
        {
            if (CbObraSocial.Checked == true)
            {
                GbReceta.Enabled = true;
                obraSocial = true;
            }
            else
            {
                GbReceta.Enabled = false;
                obraSocial = false;
            }
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

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
