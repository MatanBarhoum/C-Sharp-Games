using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class EndGame : Form
    {
        Form1 form1 = new Form1();
        public EndGame()
        {
            InitializeComponent();
        }
         
        private void EndGame_Load(object sender, EventArgs e)
        {
            ScoreLabel.Text = String.Format("You Score: {0}", Form1.score);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Program.GameOn = false;
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Program.OpenDetailFormOnClose = false;
            Program.GameOn = true;
            Form1.score = 0;
            this.Close();
        }
    }
}
