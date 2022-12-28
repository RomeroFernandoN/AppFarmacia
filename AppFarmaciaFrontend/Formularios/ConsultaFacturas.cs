using AppFarmaciaBackend.Datos;
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
    public partial class ConsultaFacturas : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;
        public ConsultaFacturas(FabricaServicio oFabrica)
        {
            InitializeComponent();
            oServicio = oFabrica.CrearServicio();
            this.oFabrica = oFabrica;
        }
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvFacturas.Rows.Clear();
            List<Parámetro> lstParametros = new List<Parámetro>();
            Parámetro oInicio = new Parámetro("@Desde", dtpFechaDesde.Value);
            Parámetro oFin = new Parámetro("@Hasta", dtpFechaHasta.Value);
            lstParametros.Add(oInicio);
            lstParametros.Add(oFin);
            await ConsultarFacturas(lstParametros);
        }

        private async Task ConsultarFacturas(List<Parámetro> lstParametros)
        {
            string fechas = JsonConvert.SerializeObject(lstParametros);
            string url = "https://localhost:7240/facturasSegunFecha";
            var data = await ClienteSingleton.ObtenerInstancia().PostAsync(url,fechas);
            List<Factura> lstFacturas;
            lstFacturas = JsonConvert.DeserializeObject<List<Factura>>(data);

            foreach (Factura oFactura in lstFacturas)
            {
                dgvFacturas.Rows.Add(new object[] { oFactura.IdFactura, oFactura.oCliente.oPersona.Nombre + ", " + oFactura.oCliente.oPersona.Apellido, oFactura.Fecha });
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        public void Limpiar()
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-1);
            dtpFechaHasta.Value = DateTime.Now.AddDays(+1);
            dgvFacturas.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public async Task<bool> EliminarFactura(int idFactura)
        {
            string url = "https://localhost:7240/eliminarFactura" + "?idFactura=" + idFactura.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().DeleteAsync(url);
            bool v = JsonConvert.DeserializeObject<bool>(data);

            return v;
        }

        private async void dgvFacturas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFacturas.CurrentCell.ColumnIndex == 3)
            {
                int idFactura = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["colNroFactura"].Value.ToString());
                if (await EliminarFactura(idFactura))
                {
                    MessageBox.Show("Se ha eliminado correctamente la factura.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar factura.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if(dgvFacturas.CurrentCell.ColumnIndex == 4)
            {
                int idFactura = Convert.ToInt32(dgvFacturas.CurrentRow.Cells["colNroFactura"].Value.ToString());
                Limpiar();
                new ModificarFacturas(idFactura, oFabrica).ShowDialog();
            }
        }

        private void ConsultaFacturas_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
