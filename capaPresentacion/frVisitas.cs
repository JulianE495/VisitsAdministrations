using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;
using capaNegocios;

namespace capaPresentacion
{
    public partial class frVisitas : Form
    {
        public frVisitas()
        {
            InitializeComponent();
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
            cbEdificio.Items.Clear();
            cbEdificio.Items.Add("Edificio 1");
            cbEdificio.Items.Add("Edificio 2");
            cbEdificio.Items.Add("Edificio 3");
            cbEdificio.Items.Add("Edificio 4");
            // Final - Limpiar comboBox Edificio

            // Inicio - Limpiar comboBox Carreras
            cbCarrera.Items.Clear();
            cbCarrera.Items.Add("Analítica y Ciencia de los Datos");
            cbCarrera.Items.Add("Desarrollo de Software");
            cbCarrera.Items.Add("Diseño Industrial");
            cbCarrera.Items.Add("Energías Renovables");
            cbCarrera.Items.Add("Informática Forense");
            cbCarrera.Items.Add("Inteligencia Artificial");
            cbCarrera.Items.Add("Manufactura Automatizada");
            cbCarrera.Items.Add("Manufactura de Dispositivos Médicos");
            cbCarrera.Items.Add("Mecatrónica");
            cbCarrera.Items.Add("Multimedia");
            cbCarrera.Items.Add("Redes de Información");
            cbCarrera.Items.Add("Seguridad Informática");
            cbCarrera.Items.Add("Simulaciones interactivas y Videojuegos");
            cbCarrera.Items.Add("Sonido");
            cbCarrera.Items.Add("Telecomunicaciones");
            // Final - Limpiar comboBox Carreras

            // Inicio - Limpiar comboBox MotivoDeVisita
            cbMotivoSalida.Items.Clear();
            cbMotivoSalida.Items.Add("Clases");
            cbMotivoSalida.Items.Add("Talleres");
            cbMotivoSalida.Items.Add("Conferencias");
            // Final - Limpiar comboBox MotivoDeVisita

            // Inicio - Limpiar comboBox Aula
            cbAula.Items.Clear();
            // Final - Limpiar comboBox Aula
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
            string motivoVisita = cbMotivoSalida.Text;

            byte[] image = File.ReadAllBytes(pbUserPhoto.ImageLocation);

            cp_visitModel visitModel = new cp_visitModel();
            var insertarVisita = visitModel.guardarVisita(nombre, apellido, correo, carrera, horaEntrada, horaSalida, edificio, aula, image, motivoVisita);

            if (insertarVisita == true)
            {
                MessageBox.Show("Visita guardada correctamente");
                limpiarCampos();
                pbUserPhoto.ImageLocation = "";
                pbUserPhoto.Tag = "No";
            }
            else if (pbUserPhoto.Tag == "No")
            {
                MessageBox.Show("Debe seleccionar una foto 2x2");
            }
            else
            {
                MessageBox.Show("Error al guardar");
                limpiarCampos();
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

        private void cbEdificio_TextChanged(object sender, EventArgs e)
        {
            if (cbEdificio.Text == "Edificio 1")
            {
                cbAula.Items.Clear();
                cbAula.Items.Add("1-1A");
                cbAula.Items.Add("1-1B");
                cbAula.Items.Add("1-1C");
                cbAula.Items.Add("1-2A");
                cbAula.Items.Add("1-2B");
                cbAula.Items.Add("1-2C");
            }
            else if (cbEdificio.Text == "Edificio 2")
            {
                cbAula.Items.Clear();
                cbAula.Items.Add("2-2A");
                cbAula.Items.Add("2-2B");
                cbAula.Items.Add("2-2C");
            }
            if (cbEdificio.Text == "Edificio 3")
            {
                cbAula.Items.Clear();
                cbAula.Items.Add("Taller de controles");
                cbAula.Items.Add("Taller Manufactura");
                cbAula.Items.Add("Taller CNC");
            }
            if (cbEdificio.Text == "Edificio 4")
            {
                cbAula.Items.Clear();
                cbAula.Items.Add("4-2A");
                cbAula.Items.Add("4-2B");
                cbAula.Items.Add("4-2C");
                cbAula.Items.Add("4-2D");
                cbAula.Items.Add("4-2E");
                cbAula.Items.Add("4-2F");
            }
        }

        private void cbEdificio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEdificio.Text == "Edificio 1")
            {
                cbAula.Items.Clear();
                cbAula.Items.Add("1-1A");
                cbAula.Items.Add("1-1B");
                cbAula.Items.Add("1-1C");
                cbAula.Items.Add("1-2A");
                cbAula.Items.Add("1-2B");
                cbAula.Items.Add("1-2C");
            }
            else if (cbEdificio.Text == "Edificio 2")
            {
                cbAula.Items.Clear();
                cbAula.Items.Add("2-2A");
                cbAula.Items.Add("2-2B");
                cbAula.Items.Add("2-2C");
            }
            if (cbEdificio.Text == "Edificio 3")
            {
                cbAula.Items.Clear();
                cbAula.Items.Add("Taller de controles");
                cbAula.Items.Add("Taller Manufactura");
                cbAula.Items.Add("Taller CNC");
            }
            if (cbEdificio.Text == "Edificio 4")
            {
                cbAula.Items.Clear();
                cbAula.Items.Add("4-2A");
                cbAula.Items.Add("4-2B");
                cbAula.Items.Add("4-2C");
                cbAula.Items.Add("4-2D");
                cbAula.Items.Add("4-2E");
                cbAula.Items.Add("4-2F");
            }
        }
    }
}
