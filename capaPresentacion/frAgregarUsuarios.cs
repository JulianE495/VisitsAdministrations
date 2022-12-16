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
            byte[] image = File.ReadAllBytes(pbUserPhoto.ImageLocation);

            cn_addUserModel addUserModel = new cn_addUserModel();

            if (rol == "Admin")
            {
                idRol = 0;
            }
            else if(rol == "General")
            {
                idRol = 1;
            }

            var insertarUser = addUserModel.insertUser(user, pass, nombre, apellido, idRol, rol, dob, image);

            if (insertarUser == true)
            {
                MessageBox.Show("Usuario agregado correctamente");
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
    }
}
