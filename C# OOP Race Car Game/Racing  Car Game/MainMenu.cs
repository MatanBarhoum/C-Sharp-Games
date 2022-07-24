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
    public partial class MainMenu : Form
    {
        private MainMenuHandler _mainMenuHandler;
        private string _username;
        private int score;
        private int coins;
        public MainMenu(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            _mainMenuHandler = new MainMenuHandler();
            _mainMenuHandler.SetMainMenu(lblScore, lblCoins, _username);
            score = Convert.ToInt32(lblScore.Text);
            coins = Convert.ToInt32(lblCoins.Text);
            lblWelcome.Text = "Welcome Back, " + _username;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            var _newGame = new Thread(new ThreadStart(NewGame));
            this.Hide();
            _newGame.Start();   
            this.Close();
        }

        private void NewGame()
        {
            var newGame = new Form1(_username, score, coins);
            newGame.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
