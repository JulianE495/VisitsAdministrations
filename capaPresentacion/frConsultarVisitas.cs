using capaDatos;
using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frConsultarVisitas : Form
    {
        public frConsultarVisitas()
        {
            InitializeComponent();
            tableDesign();
            mostrarVisits();
            listarEdificios();
        }
        private void tableDesign()
        {
            dgvTableVisits.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 53, 58);
            dgvTableVisits.BackgroundColor = Color.FromArgb(35, 33, 38);
            dgvTableVisits.BorderStyle = BorderStyle.None;
        }
        private void mostrarVisits()
        {
            cn_consultarVisits tabla = new cn_consultarVisits();
            dgvTableVisits.DataSource = tabla.MostrarVisitTable();
        }
        private void listarEdificios()
        {
            cd_frVisitas edificios = new cd_frVisitas();
            cbEdificio.DataSource = edificios.selectEdificio();
            cbEdificio.DisplayMember = "Edificio";
            cbEdificio.ValueMember = "Edificio";
        }

        private void cbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string edificio = cbEdificio.Text;
            cn_consultarVisits tabla = new cn_consultarVisits();
            dgvTableVisits.DataSource = tabla.MostrarVisitTableEdificio(edificio);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            cn_consultarVisits tabla = new cn_consultarVisits();
            dgvTableVisits.DataSource = tabla.MostrarVisitTable();

            // Inicio - Limpiar comboBox Edificio
            cbEdificio.Text = "";
            listarEdificios();
            // Final - Limpiar comboBox Edificio
        }
    }
}
