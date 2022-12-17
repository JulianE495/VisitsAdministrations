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
    public partial class frAgregarUsuarios : Form
    {
        public frAgregarUsuarios()
        {
            InitializeComponent();
            mostrarUsuario();
        }
        private void validarTexto(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void validarTextoConEspacio(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void mostrarUsuario()
        {
            cn_addUserModel tabla = new cn_addUserModel();
            dgvTableUsers.DataSource = tabla.mostarUserTable();
        }
        private void btnGuardarUser_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = cd_encryptPass.GetSHA256(txtPass.Text.Trim());
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int idRol = 0;
            string rol = cbTipoUsuario.Text;
            string dob = dtpFechaNacimiento.Text;

            if (user == "" || pass == "" || nombre == "" || apellido == "" || rol == "" || dob == "" || pbUserPhoto.Tag == "No")
            {
                MessageBox.Show("Error al guardar \nAsegurese de ingresar todos los datos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                byte[] image = File.ReadAllBytes(pbUserPhoto.ImageLocation);

                cn_addUserModel addUserModel = new cn_addUserModel();

                if (rol == "Admin")
                {
                    idRol = 0;
                }
                else if (rol == "General")
                {
                    idRol = 1;
                }

                var insertarUser = addUserModel.insertUser(user, pass, nombre, apellido, idRol, rol, dob, image);

                if (insertarUser == true)
                {
                    MessageBox.Show("Usuario agregado correctamente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    pbUserPhoto.ImageLocation = "";
                    pbUserPhoto.Tag = "No";
                    mostrarUsuario();
                }
                else if (pbUserPhoto.Tag == "No")
                {
                    MessageBox.Show("Debe seleccionar una foto 2x2", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Error al guardar", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextoConEspacio(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTextoConEspacio(e);
        }
    }
}
