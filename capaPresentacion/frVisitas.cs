using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;
using capaNegocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace capaPresentacion
{
    public partial class frVisitas : Form
    {
        public frVisitas()
        {
            InitializeComponent();
            listarEdificios();
            listarAulas();
            listarCarreras();
            listarMotivoVisita();
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            cbCarrera.Text = "";
            dtpHoraEntrada.Text = "";
            dtpHoraSalida.Text = "";
            // Inicio - Limpiar comboBox Edificio
            listarEdificios();
            // Final - Limpiar comboBox Edificio

            // Inicio - Limpiar comboBox Aula
            listarAulas();
            // Fin - Limpiar comboBox Aula

            // Inicio - Limpiar comboBox Carreras
            listarCarreras();
            // Final - Limpiar comboBox Carreras

            // Inicio - Limpiar comboBox MotivoDeVisita
            listarMotivoVisita();
            // Final - Limpiar comboBox MotivoDeVisita
        }
        private void listarEdificios()
        {
            cd_frVisitas edificios = new cd_frVisitas();
            cbEdificio.DataSource = edificios.selectEdificio();
            cbEdificio.DisplayMember = "Edificio";
            cbEdificio.ValueMember = "Edificio";
          
        }
        private void listarAulas()
        {
            int idEdificio = 1;
            if (cbEdificio.Text == "Edificio 1")
            {
                idEdificio = 1;
            }
            else if (cbEdificio.Text == "Edificio 2")
            {
                idEdificio = 2;
            }
            else if (cbEdificio.Text == "Edificio 3")
            {
                idEdificio = 3;
            }
            else if (cbEdificio.Text == "Edificio 4")
            {
                idEdificio = 4;
            }

            cp_visitModel visitModel = new cp_visitModel();
            cbAula.DataSource = visitModel.listarAulas(idEdificio);
            cbAula.DisplayMember = "Aula";
            cbAula.ValueMember = "Aula";
        }
        private void listarCarreras()
        {
            cd_frVisitas carreras = new cd_frVisitas();
            cbCarrera.DataSource = carreras.selectCarrera();
            cbCarrera.DisplayMember = "Carrera";
            cbCarrera.ValueMember = "Carrera";
        }

        private void listarMotivoVisita()
        {
            cd_frVisitas motivoVisitas = new cd_frVisitas();
            cbMotivoVisita.DataSource = motivoVisitas.selectMotivoVisita();
            cbMotivoVisita.DisplayMember = "Motivo";
            cbMotivoVisita.ValueMember = "Motivo";
        }
        private void validarTexto(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                e.Handled = true;
                return;
            }
        }
        public static bool validarEmail(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { 
                    return true; 
                }
                else 
                { 
                    return false; 
                }
            }
            else
            {
                return false;
            }
        }
            private void btnGuardarVisita_Click(object sender, EventArgs e)
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string correo = txtCorreo.Text;
                string carrera = cbCarrera.Text;
                string horaEntrada = dtpHoraEntrada.Text;
                string horaSalida = dtpHoraSalida.Text;
                string edificio = cbEdificio.Text;
                string aula = cbAula.Text;
                string motivoVisita = cbMotivoVisita.Text;
                if (nombre == "" || apellido == "" || correo == "" || carrera == "" || horaEntrada == "" || horaSalida == "" || edificio == "" || aula == "" || motivoVisita == "")
                {
                    MessageBox.Show("Error al guardar \nAsegurese de llenar todos los datos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    limpiarCampos();
                }
                else
                {
                    byte[] image = File.ReadAllBytes(pbUserPhoto.ImageLocation);

                    cp_visitModel visitModel = new cp_visitModel();
                    var insertarVisita = visitModel.guardarVisita(nombre, apellido, correo, carrera, horaEntrada, horaSalida, edificio, aula, image, motivoVisita);

                    if (insertarVisita == true)
                    {
                        MessageBox.Show("Visita guardada correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        limpiarCampos();
                        pbUserPhoto.ImageLocation = "";
                        pbUserPhoto.Tag = "No";
                    }
                    else if (pbUserPhoto.Tag == "No")
                    {
                        MessageBox.Show("Debe seleccionar una foto 2x2", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        limpiarCampos();
                    }
                }
            

            
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchIMG = new OpenFileDialog();
            searchIMG.Filter = "Images(.jpg,.png)|*.png;*.jpg";

            if (searchIMG.ShowDialog() == DialogResult.OK)
            {
                pbUserPhoto.ImageLocation = searchIMG.FileName;
                pbUserPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pbUserPhoto.Tag = "Si";
            }
        }
        
        private void cbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarAulas();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            string Email = txtCorreo.Text;
            if (validarEmail(Email) == false)
            {
                MessageBox.Show("El Email Ingresado no se encuentra en el Formato Correcto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtCorreo.Focus();
            }
        }
    }
}
