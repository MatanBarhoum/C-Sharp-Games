using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Racing__Car_Game.Databasee;
namespace Racing__Car_Game
{
    public partial class Register : Form
    {
        private RegisterHandler _registerHandler;
        public Register()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var startLoginForm = new Thread(new ThreadStart(StartLoginForm));
            this.Hide();
            startLoginForm.Start();
            this.Close();
        }

        private void StartLoginForm()
        {
            var _login = new Login();
            _login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _registerHandler = new RegisterHandler();
            _registerHandler.Register(txtUsername.Text, txtPassword.Text, txtUsername, txtPassword);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnRegister;
        }
    }
}
