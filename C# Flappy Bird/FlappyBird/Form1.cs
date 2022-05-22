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
    public partial class Form1 : Form
    {
        int pipeSpeed = 4;
        int gravity = 8;
        public static int score = 0;
        public static bool gameison = true;
        public Form1()
        {
            InitializeComponent();
        }


        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void gameTimerTick(object sender, EventArgs e)
        {
                
                flappyBird.Top += gravity;
                Pipe.Left -= pipeSpeed;
                PipeDown.Left -= pipeSpeed;

                if (Pipe.Left < -150)
                {
                    Pipe.Left = 600;
                }
                if (PipeDown.Left < -180)
                {
                    PipeDown.Left = 500;
                    score++;
                    LabelScore.Text = string.Format("Score: {0}", score);
                    label1.Text = pipeSpeed.ToString();
                }

                if (flappyBird.Bounds.IntersectsWith(Pipe.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(PipeDown.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(ground.Bounds))
                {
                    gameison = false;
                    EndGame();
                }
                if (score % 5 == 0 && score != 0)
                {
                    pipeSpeed++ ;
                }
                
            {

            } 
            
        }

        private void EndGame()
        {
            gameTimer.Stop();
            Program.GameOn = true;
            Program.OpenDetailFormOnClose = true;
            this.Close();
        }
    }
}
