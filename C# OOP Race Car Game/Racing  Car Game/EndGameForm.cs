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
    public partial class EndGameForm : Form
    {
        private EndGameHandler _endGameHandler;
        public int currentScore { get; set; }
        public int currentCoins { get; set; }

        private int score, coins;

        private string _username;
        public EndGameForm(string username, int _score, int _coins)
        {
            InitializeComponent();
            _username = username;
            score = _score;
            coins = _coins;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _endGameHandler = new EndGameHandler();
            _endGameHandler.SetValues(_username, this);
            var restartGame = new Thread(new ThreadStart(LoadGame));
            this.Hide();
            restartGame.Start();
            this.Close();
        }

        private void LoadGame()
        {
            var restartGame = new Form1(_username, currentScore, currentCoins);
            restartGame.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var _mainMenu = new Thread(new ThreadStart(LoadMainMenu));
            this.Hide();
            _mainMenu.Start();
            this.Close();
        }

        private void LoadMainMenu()
        {
            var mainMenu = new MainMenu(_username);
            mainMenu.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EndGameForm_Load(object sender, EventArgs e)
        {
            lblCoins.Text = coins.ToString();
            lblScore.Text = score.ToString();
        }
    }
}
