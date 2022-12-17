using capaDatos;
using capaNegocios;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace capaPresentacion
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = cd_encryptPass.GetSHA256(txtPassword.Text.Trim());
 

            if (txtUser.Text != "Username")
            {
                if (txtPassword.Text != "Password")
                {
                    UserModel user = new UserModel();

                    var validLogin = user.LoginUser(txtUser.Text, pass);
                    if (validLogin == true)
                    {
                        frMain inicio = new frMain();
                        MessageBox.Show("Bienvenido " + cd_userCache.LoginName + ", " + cd_userCache.Name);
                        inicio.Show();
                        inicio.FormClosed += Logout;
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Nombre y/o Contraseña incorrecta. \nInténtelo de nuevo, por favor.");
                        txtPassword.Text = "Contraseña";
                        txtPassword.UseSystemPasswordChar = false;
                        txtPassword.Focus();
                    }
                }
                else MessageBox.Show("Ingrese una contraseña, por favor.");
            }
            else MessageBox.Show("Ingrese un usuario, por favor.");
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            if (cd_userCache.IdRol == 0)
            {

            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Text = "Password";
            txtPassword.UseSystemPasswordChar = false;
            txtUser.Text = "Username";
            this.Show();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnShowPass.Visible = false;
                btnHidePass.Visible = true;
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
                btnShowPass.Visible = true;
                btnHidePass.Visible = false;
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }
    }
}