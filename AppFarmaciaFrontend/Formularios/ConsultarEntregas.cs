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
    public partial class ConsultarEntregas : Form
    {
        private IServicio oServicio;
        private FabricaServicio oFabrica;
        public ConsultarEntregas(FabricaServicio oFabrica)
        {
            InitializeComponent();
            oServicio = oFabrica.CrearServicio();
            this.oFabrica = oFabrica;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async Task ConsultaEntregas(List<Parámetro> lstParametros)
        {
            string fechas = JsonConvert.SerializeObject(lstParametros);
            string url = "https://localhost:7240/entregasSegunFecha";
            var data = await ClienteSingleton.ObtenerInstancia().PostAsync(url,fechas);
            List<Entrega> lstEntregas = new List<Entrega>();
            lstEntregas = JsonConvert.DeserializeObject<List<Entrega>>(data);

            foreach (Entrega oEntrega in lstEntregas)
            {
                dgvEntregas.Rows.Add(new object[] { oEntrega.IdEntrega, oEntrega.EmpleadoLogistica, oEntrega.Fecha });
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvEntregas.Rows.Clear();
            List<Parámetro> lstParametros = new List<Parámetro>();
            Parámetro oInicio = new Parámetro("@Desde", dtpFechaDesde.Value);
            Parámetro oFin = new Parámetro("@Hasta", dtpFechaHasta.Value);
            lstParametros.Add(oInicio);
            lstParametros.Add(oFin);
            await ConsultaEntregas(lstParametros);
        }

        public void Limpiar()
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-1);
            dtpFechaHasta.Value = DateTime.Now.AddDays(+1);
            dgvEntregas.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public async Task<bool> EliminarEntrega(int idEntrega)
        {
            string url = "https://localhost:7240/eliminarEntrega" + "?idEntrega=" +idEntrega.ToString();
            var data = await ClienteSingleton.ObtenerInstancia().DeleteAsync(url);
            bool v = JsonConvert.DeserializeObject<bool>(data);

            return v;
        }
        private async void dgvEntregas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntregas.CurrentCell.ColumnIndex == 3)
            {
                int idEntrega = Convert.ToInt32(dgvEntregas.CurrentRow.Cells["colNroEntrega"].Value.ToString());
                if (await EliminarEntrega(idEntrega))
                {
                    MessageBox.Show("Se ha eliminado correctamente la entrega.", "Confirmación.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al eliminar entrega.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (dgvEntregas.CurrentCell.ColumnIndex == 4)
            {
                int idEntrega = Convert.ToInt32(dgvEntregas.CurrentRow.Cells["colNroEntrega"].Value.ToString());
                Limpiar();
                new ModificarEntrega(idEntrega, oFabrica).ShowDialog();
            }
        }

        private void ConsultarEntregas_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
