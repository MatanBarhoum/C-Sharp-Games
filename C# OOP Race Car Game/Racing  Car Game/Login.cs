using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racing__Car_Game.Databasee;
using System.Threading;

namespace Racing__Car_Game
{
    public partial class Login : Form
    {
        private Authenticator _authenticator;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _authenticator = new Authenticator();
            
            if(_authenticator.Authenticate(txtUsername.Text, txtPassword.Text))
            {
                var mainMenu = new MainMenu(txtUsername.Text);
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Thread newRegisterForm = new Thread(new ThreadStart(LoadRegisterForm));
            this.Hide();
            newRegisterForm.Start();
            this.Close();
        }

        private void LoadRegisterForm()
        {
            var registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
