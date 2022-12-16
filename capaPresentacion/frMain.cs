using capaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
            loadUserData();
        }
        private Form formularioActivo = null;
        private void abrirFomularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formularioHijo);
            pnMain.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void loadUserData()
            {   
                lblUser.Text = cd_userCache.Name;
                lblRol.Text = cd_userCache.Rol;
                byte[] imgData = (byte[])cd_userCache.image;
                Image newImage = null;
                using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                {
                    ms.Write(imgData, 0, imgData.Length);
                    newImage = Image.FromStream(ms, true);
                }
                pbProfile.Image = newImage;
                pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        private void btnVisitas_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frVisitas());
        }

        private void btnConsultarVisitas_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frConsultarVisitas());
        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frAgregarUsuarios());
        }
    }
}
