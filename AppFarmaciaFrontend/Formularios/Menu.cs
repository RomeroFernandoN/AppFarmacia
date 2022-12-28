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
    public partial class Menu : Form
    {
        private IServicio oServicio;
        public Usuario oUsuario;
        public RegistroEntregas oEntrega;
        public FormFactura oFactura;
        public InsertarInsumos oInsumo;
        public ConsultaFacturas oConsultaFactura;
        public ConsultarEntregas oConsultaEntrega;
        public FabricaServicio oFabrica;
        public Menu(FabricaServicio oFabrica)
        {
            InitializeComponent();
            oServicio = oFabrica.CrearServicio();
            oEntrega = new RegistroEntregas(oFabrica);
            oFactura = new FormFactura(oFabrica);
            oInsumo = new InsertarInsumos(oFabrica);
            oConsultaFactura = new ConsultaFacturas(oFabrica);
            oConsultaEntrega = new ConsultarEntregas(oFabrica);
            this.oFabrica = oFabrica;
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oInsumo.IsDisposed)
            {
                oInsumo = new InsertarInsumos(this.oFabrica);
            }
            oInsumo.Show();
        }

        private void realizarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oFactura.IsDisposed)
            {
                oFactura = new FormFactura(this.oFabrica);
            }
            oFactura.Show();
        }

        private void registrarEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oEntrega.IsDisposed)
            {
                oEntrega = new RegistroEntregas(this.oFabrica);
            }
            oEntrega.Show();
        }

        private void listadoFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oConsultaFactura.IsDisposed)
            {
                oConsultaFactura = new ConsultaFacturas(this.oFabrica);
            }
            oConsultaFactura.Show();
        }

        public void Limpiar()
        {
            cboCargo.SelectedIndex = -1;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
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

            if (cboCargo.SelectedIndex == -1)
            {
                validar = false;
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                validar = false;
            }
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                validar = false;
            }
            return validar;
        }
        private async Task<int> ConsultarUsuario(Usuario oUsuario)
        {
            string usuario = JsonConvert.SerializeObject(oUsuario);
            string url = "https://localhost:7240/usuario";
            var data = await ClienteSingleton.ObtenerInstancia().PostAsync(url, usuario);
            int v = JsonConvert.DeserializeObject<int>(data);

            return v;
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            int cargo = 0;
            if (Validar())
            {
                if (cboCargo.SelectedItem.ToString() == "Administrador")
                {
                    cargo = 1;
                }
                else if (cboCargo.SelectedItem.ToString() == "Vendedor")
                {
                    cargo = 2;
                }
                else if (cboCargo.SelectedItem.ToString() == "Cliente")
                {
                    cargo = 3;
                }
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                oUsuario = new Usuario(cargo, usuario, contraseña);

                if (cargo == 1)
                {
                    if (Convert.ToInt32(await ConsultarUsuario(oUsuario)) == 1)
                    {
                        menuStrip1.Enabled = true;
                        Ocultar();
                        lblCompletar.Text = "Cargo: Administrador.";
                        lblUsu.Text = "Usuario: " + usuario + ".";
                    }
                }
                else
                 {
                     MessageBox.Show("Error al iniciar sesión.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Ocultar()
        {
            txtContraseña.Visible = false;
            txtUsuario.Visible = false;
            cboCargo.Visible = false;
            btnCancelar.Visible = false;
            btnIngresar.Visible = false;
            lblCargo.Visible = false;
            lblContraseña.Visible = false;
            lblUsuario.Visible = false;
        }
        private void listadoEntregasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(oConsultaEntrega.IsDisposed)
            {
                oConsultaEntrega = new ConsultarEntregas(this.oFabrica);
            }
            oConsultaEntrega.Show();
        }
    }
}
