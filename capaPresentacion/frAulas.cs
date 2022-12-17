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
    public partial class frAulas : Form
    {
        public frAulas()
        {
            InitializeComponent();
            listarEdificios();
            mostrarAulas();
        }
        private void mostrarAulas()
        {
            cn_AulasModel tabla = new cn_AulasModel();
            dgvTableAula.DataSource = tabla.mostrarAulasTable();
        }
        private void limpiarDatos()
        {
            txtAula.Text = "";
            txtId.Text = "";
        }
        private void listarEdificios()
        {
            cd_frVisitas edificios = new cd_frVisitas();
            cbEdificios.DataSource = edificios.selectEdificio();
            cbEdificios.DisplayMember = "Edificio";
            cbEdificios.ValueMember = "Edificio";
        }
        private void btnGuardarAula_Click(object sender, EventArgs e)
        {
            string aula = txtAula.Text;
            int idEdificio = 0;

            if (cbEdificios.Text == "Edificio 1")
            {
                idEdificio = 1;
            }
            else if (cbEdificios.Text == "Edificio 2")
            {
                idEdificio = 2;
            }
            else if (cbEdificios.Text == "Edificio 3")
            {
                idEdificio = 3;
            }
            else if (cbEdificios.Text == "Edificio 4")
            {
                idEdificio = 4;
            }

            if (aula == "")
            {
                MessageBox.Show("Error al guardar \nAsegurese de ingresar todos los datos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limpiarDatos();
            }
            else
            {
                cn_AulasModel addAulaModel = new cn_AulasModel();
                var insertatEdificio = addAulaModel.insertAula(aula, idEdificio);
                if (insertatEdificio == true)
                {
                    MessageBox.Show("Aula agregada correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    mostrarAulas();
                    limpiarDatos();
                }
                else
                {
                    MessageBox.Show("Error al guardar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    limpiarDatos();
                    mostrarAulas();
                }
            }
        }

        private void btnEliminarAula_Click(object sender, EventArgs e)
        {
            int idAla = Convert.ToInt32(((string)txtId.Text).Trim());
            string Aula = txtAula.Text;
            if (Aula == "")
            {
                MessageBox.Show("Error al eliminar \nAsegurese de seleccionar un dato para eliminar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limpiarDatos();
                mostrarAulas();
            }
            else
            {
                cn_AulasModel aulaModel = new cn_AulasModel();
                var deleteEdificio = aulaModel.deleteAula(idAla, Aula);
                if (deleteEdificio == true)
                {
                    MessageBox.Show("Aula eliminada correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpiarDatos();
                    mostrarAulas();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    limpiarDatos();
                    mostrarAulas();
                }
            }
        }

        private void dgvTableAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cn_AulasModel select = new cn_AulasModel();
            int id = Convert.ToInt32(dgvTableAula.CurrentRow.Cells[0].Value);
            select.selectAulas(id);

            txtId.Text = Convert.ToString(cd_AulasCache.idAula);
            txtAula.Text = cd_AulasCache.Aula;
        }
    }
}
