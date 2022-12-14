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
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = cd_encryptPass.GetSHA256(txtPassword.Text.Trim());
 

            if (txtUser.Text != "Username" && txtUser.TextLength > 2)
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
                        MessageBox.Show("Nombre y/o Contraseña incorrecta. \n Inténtelo de nuevo, por favor.");
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
    }
}