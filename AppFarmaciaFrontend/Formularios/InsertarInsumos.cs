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
    public partial class InsertarInsumos : Form
    {
        private IServicio oServicio;
        private string insumo;
        private ServicioObjetos oServicioObjetos;
        public InsertarInsumos(FabricaServicio oFabrica)
        {
            InitializeComponent();
            oServicio = oFabrica.CrearServicio();
            oServicioObjetos = new ServicioObjetos();
        }

        public void CargarCampos()
        {
            if(cbInsertar.Checked)
            {
                gbCaracteristicas.Enabled = true;
            }
            else if(cbModificar.Checked)
            {
                cboInsumos.Enabled = true;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
            }
            else
            {
                gbCaracteristicas.Enabled = false;
                cboInsumos.Enabled =false;
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
            }
            cboInsumos.SelectedIndex = -1;
            cboTipoInsumo.SelectedIndex = -1;
        }

        public void Limpiar()
        {
            txtNombreInsumo.Text = "";
            cboTipoInsumo.SelectedIndex = -1;
            cboInsumos.SelectedIndex = -1;
            txtPrecio.Text = "";
            ckNo.Checked = false;
            ckSi.Checked = true;
        }

        public async Task CargarComboAsync()
        {
            await oServicioObjetos.CargarInsumosAsync(cboInsumos);
            await oServicioObjetos.CargarTiposInsumosAsync(cboTipoInsumo);
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
            bool validar = true;
            if (ckNo.Checked == false && ckSi.Checked == false)
            {
                validar = false;
            }
            if (cboTipoInsumo.SelectedIndex == -1)
            {
                validar = false;
            }

            if (txtPrecio.Text == "")
            {
                validar = false;
            }
            try
            {
                if (txtPrecio.Text != "")
                {
                    Convert.ToDecimal(txtPrecio.Text);
                }
            }
            catch
            {
                validar = false;
            }
            if(string.IsNullOrEmpty(txtNombreInsumo.Text))
            {
                validar = false;
            }
            return validar;
        }

        private async void InsertarInsumos_Load(object sender, EventArgs e)
        {
            Limpiar();
            await CargarComboAsync();
            CargarCampos();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            gbCaracteristicas.Enabled = true;
            int idInsumo = await ConsultarInsumoSegunNombre(insumo);
            await CompletarCampos(idInsumo);
        }

        private async Task<Insumo> ConsultarInsumoSegunId(int idInsumo)
        {
            string url = "https://localhost:7240/insumoSegunId" + "?idInsumo=" + idInsumo.ToString(); ;
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            Insumo oInsumo = JsonConvert.DeserializeObject<Insumo>(data);

            return oInsumo;
        }

        public async Task CompletarCampos(int idInsumo)
        {
            Insumo oInsumo = await ConsultarInsumoSegunId(idInsumo);
            txtNombreInsumo.Text = oInsumo.Nombre;
            txtPrecio.Text = Convert.ToString(oInsumo.Precio);
            cboTipoInsumo.SelectedIndex = oInsumo.oTipoInsumo.IdTipoInsumo - 1;
            if(oInsumo.TipoVenta == 1)
            {
                ckSi.Checked = true;
            }
            else
            {
                ckNo.Checked = false;
            }
        }

        private async Task<int> ConsultarProximoInsumo()
        {
            string url = "https://localhost:7240/proximoInsumo";
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            int v = JsonConvert.DeserializeObject<int>(data);

            return v;
        }

        private async Task<int> ConsultarInsumoSegunNombre(string nombre)
        {
            string url = "https://localhost:7240/insumoSegunNombre" + "?nombre=" + nombre;
            var data = await ClienteSingleton.ObtenerInstancia().GetAsync(url);
            int v = JsonConvert.DeserializeObject<int>(data);

            return v;
        }

        private async Task<bool> InsertarInsumo(Insumo oInsumo, string spNombre)
        {
            string insumo = JsonConvert.SerializeObject(oInsumo);
            string url = "https://localhost:7240/registrarInsumo" + "?spNombre=" + spNombre;
            var data = await ClienteSingleton.ObtenerInstancia().PostAsync(url, insumo);
            bool v = JsonConvert.DeserializeObject<bool>(data);

            return v;
        }

        private async Task<bool> ModificarInsumo(Insumo oInsumo, string spNombre)
        {
            string insumo = JsonConvert.SerializeObject(oInsumo);
            string url = "https://localhost:7240/modificarInsumo" + "?spNombre=" + spNombre;
            var data = await ClienteSingleton.ObtenerInstancia().UpdateAsync(url, insumo);
            bool v = JsonConvert.DeserializeObject<bool>(data);

            return v;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Validar() && cbModificar.Checked)
            {
                Insumo oInsumo = new Insumo();
                oInsumo.IdInsumo = await ConsultarInsumoSegunNombre(insumo);
                oInsumo.Nombre = txtNombreInsumo.Text;
                oInsumo.Precio = Convert.ToDecimal(txtPrecio.Text);
                int tipoVenta = 0;
                if (ckSi.Checked)
                {
                    tipoVenta = 1;
                }
                oInsumo.TipoVenta = tipoVenta;
                TipoInsumo oTipoInsumo = new TipoInsumo();
                oTipoInsumo.IdTipoInsumo = Convert.ToInt32(cboTipoInsumo.SelectedValue);
                oInsumo.oTipoInsumo = oTipoInsumo;


                if (await InsertarInsumo(oInsumo, "sp_modificar_insumo"))
                {
                    MessageBox.Show("Se ha actualizado correctamente.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al actualizar.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else if (Validar() && cbInsertar.Checked)
            {

                Insumo oInsumo = new Insumo();
                oInsumo.IdInsumo = await ConsultarProximoInsumo();
                oInsumo.Nombre = txtNombreInsumo.Text;
                oInsumo.Precio = Convert.ToDecimal(txtPrecio.Text);
                int tipoVenta = 0;
                if (ckSi.Checked)
                {
                    tipoVenta = 1;
                }
                oInsumo.TipoVenta = tipoVenta;

                TipoInsumo oTipoInsumo = new TipoInsumo();
                oTipoInsumo.IdTipoInsumo = Convert.ToInt32(cboTipoInsumo.SelectedValue);
                oTipoInsumo.Nombre = cboTipoInsumo.SelectedText;

                oInsumo.oTipoInsumo = oTipoInsumo;

                if (await ModificarInsumo(oInsumo, "sp_insertar_insumo"))
                {
                    MessageBox.Show("Se ha insertado correctamente.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al insertar.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void ckSi_CheckedChanged(object sender, EventArgs e)
        {
            if(ckSi.Checked)
            {
                ckNo.Checked = false;
            }
        }

        private void ckNo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckNo.Checked)
            {
                ckSi.Checked = false;
            }
        }

        private void cbInsertar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInsertar.Checked)
            {
                cbModificar.Checked = false;
                CargarCampos();
            }
        }

        private void cbModificar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModificar.Checked)
            {
                cbInsertar.Checked = false;
                CargarCampos();
            }
        }

        private void cboInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
            insumo = cboInsumos.Text;
        }

        private async Task DarBajaInsumo(int idInsumo)
        {
            string url = "https://localhost:7240/darBajaInsumo" + "?idInsumo=" + idInsumo.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().DeleteAsync(url);
            bool v = JsonConvert.DeserializeObject<bool>(data);

            if (v)
            {
                MessageBox.Show("Se ha eliminado correctamente.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al eliminar.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDarBaja_Click(object sender, EventArgs e)
        {
            Insumo oInsumo = (Insumo)cboInsumos.SelectedItem;
            int id = oInsumo.IdInsumo;
            await DarBajaInsumo(id);
        }
    }
}
