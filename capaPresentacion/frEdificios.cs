using capaDatos;
using capaNegocios;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace capaPresentacion
{
    public partial class frEdificios : Form
    {
        public frEdificios()
        {
            InitializeComponent();
            mostrarEdificios();
            limpiarDatos();
        }
        private void mostrarEdificios()
        {
            cn_EdificiosModel tabla = new cn_EdificiosModel();
            dgvTableEdificio.DataSource = tabla.mostrarEdificioTable();
        }
        private void limpiarDatos()
        {
            txtEdificio.Text = "";
            txtId.Text = "";
        }
        private void btnGuardarEdificio_Click(object sender, EventArgs e)
        {
            string edificio = txtEdificio.Text;
            if (edificio == "")
            {
                MessageBox.Show("Error al guardar \nAsegurese de ingresar todos los datos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limpiarDatos();
            }
            else
            {
                cn_EdificiosModel addEdificioModel = new cn_EdificiosModel();
                var insertatEdificio = addEdificioModel.insertEdificio(edificio);
                if (insertatEdificio == true)
                {
                    MessageBox.Show("Edificio agregado correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    mostrarEdificios();
                    limpiarDatos();
                }
                else
                {
                    MessageBox.Show("Error al guardar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    limpiarDatos();
                    mostrarEdificios();
                }
            }
        }

        private void btnEliminarEdificio_Click(object sender, EventArgs e)
        {
            int idEdificio = Convert.ToInt32(((string)txtId.Text).Trim());
            string edificio = txtEdificio.Text;
            if (edificio == "")
            {
                MessageBox.Show("Error al eliminar \nAsegurese de seleccionar un dato para eliminar.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limpiarDatos();
                mostrarEdificios();
            }
            else
            {
                cn_EdificiosModel addEdificioModel = new cn_EdificiosModel();
                var deleteEdificio = addEdificioModel.deleteEdificio(idEdificio);
                if (deleteEdificio == true)
                {
                    MessageBox.Show("Edificio eliminado correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpiarDatos();
                    mostrarEdificios();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    limpiarDatos();
                    mostrarEdificios();
                }
            }
        }

        private void dgvTableEdificio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cn_EdificiosModel select = new cn_EdificiosModel();
            int id = Convert.ToInt32(dgvTableEdificio.CurrentRow.Cells[0].Value);
            select.selectEdificios(id);

            txtId.Text = Convert.ToString(cd_EdificioCache.idEdificio);
            txtEdificio.Text = cd_EdificioCache.Edificio;
        }
    }
}
