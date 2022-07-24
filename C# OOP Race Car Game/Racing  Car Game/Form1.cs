using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racing__Car_Game.Engine;
using Racing__Car_Game.Databasee;
using System.Threading;

namespace Racing__Car_Game
{
    public partial class Form1 : Form
    {
        private LostHandler _lostHandler;
        Logic engine = new Logic();
        GeneratePosition generatePosition = new GeneratePosition();
        private int carSpeed = 2;
        private int TilesSpeed = 5;
        private int distanceCovered = 0;
        //private int Stage = 1;
        private int score = 0;
        private int coins = 0;
        private string _username;
        private int _currentScore;
        private int _currentCoins;
        public Form1(string username, int currentScore, int currentCoins)
        {
            InitializeComponent();
            lblKmh.Text = carSpeed.ToString() + "KM/H";
            lblScore.Text = "Score: " + score.ToString();
            lblCoins.Text = "Coins: " + coins.ToString();
            lblDistance.Text = "Distance " +  distanceCovered.ToString();
            Coin.Visible = true;
            Coin2.Visible = true;
            Coin3.Visible = true;
            Coin4.Visible = true;
            Coin5.Visible = true;
            Coin6.Visible = true;
            Coin7.Visible = true;
            Astroied.Visible = true;
            Astroied2.Visible = true;
            Astroied3.Visible = true;
            _username = username;
            _currentScore = currentScore;
            _currentCoins = currentCoins;
        }



        // User is press the up / left / right arrows key on keyboard.
        // the carSpeed will be increased by 1, and if the speed is at 120, it won't increase.
        private void UserPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                distanceCovered++;
                lblDistance.Text = distanceCovered.ToString();
                if (engine.CalculateScore(distanceCovered)) 
                {
                    score++;
                    lblScore.Text = "Score: " + score.ToString();
                }
                if (carSpeed == 80)
                {
                    carSpeed = 80;
                } else
                {
                    carSpeed++;
                    TilesMove(10);
                }
                lblKmh.Text = Convert.ToString(carSpeed) + " KM/H";
            }
            else if (e.KeyCode == Keys.Left)
            {
                Car.Left -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                Car.Left += 10;
            }
        }

        // This event triggered when the player leaving the keyboard.
        // while the carspeed is more than 2, it will decrease by 1 every 100 miliseconds using the wait function (using a timer to prevent ui freeze)
        private void UserLeftKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                while(carSpeed != 2)
                {
                    carSpeed--;
                    wait(100);
                    lblKmh.Text = Convert.ToString(carSpeed) + " KM/H";
                    distanceCovered++;
                    lblDistance.Text = distanceCovered.ToString();
                } 
            }
            else if (e.KeyCode == Keys.Left)
            {
                Car.Left -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                Car.Left += 10;
            }
        }
        
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            distanceCovered++;
            lblDistance.Text = distanceCovered.ToString();
            if (engine.CalculateScore(distanceCovered))
            {
                score++;
                lblScore.Text = "Score: " + score.ToString();
            }
            label1.Text = Car.Left.ToString();
            TilesMove(TilesSpeed);
            GeneratePosition();
            panelMovement();
            if (TouhcedCoin())
            {
                coins++;
            }
            if (Astroied.Top > 650)
            {
                Astroied.Location = new Point(engine.GenerateRandomX(), -100);
                Astroied.Top = -100;
            }
           /* if (distanceCovered > 2000)
            {
                //Stage++;
            }*/
            Lost();
        }

        private void Lost()
        {
            if(engine.UserLost(GameTimer, Car, Astroied, Astroied2, Astroied3))
            {
                var dbengine = new Databasee.Engine();
                _lostHandler = new LostHandler(dbengine);
                _lostHandler.UpdateScoreAndCoins(score, _currentScore, coins, _currentCoins, _username);
                var _gameOver = new Thread(new ThreadStart(GameOver));
                this.Hide();
                _gameOver.Start();
                this.Close();
            }
        }

        private void GameOver()
        {
            var _endGame = new EndGameForm(_username, score, coins);
            _endGame.ShowDialog();
        }

        private bool TouhcedCoin()
        {
            lblCoins.Text = "Coins: " + coins.ToString();
            engine.AddToCoinsList(Coin);
            engine.AddToCoinsList(Coin2);
            engine.AddToCoinsList(Coin3);
            engine.AddToCoinsList(Coin4);
            engine.AddToCoinsList(Coin5);
            engine.AddToCoinsList(Coin6);
            engine.AddToCoinsList(Coin7);

            return engine.CheckIfTouchedCoins(Car);
            
        }

        private void GeneratePosition()
        {
            generatePosition.AddToTilesList(Coin);
            generatePosition.AddToTilesList(Coin2);
            generatePosition.AddToTilesList(Coin3);
            generatePosition.AddToTilesList(Coin4);
            generatePosition.AddToTilesList(Coin5);
            generatePosition.AddToTilesList(Coin6);
            generatePosition.AddToTilesList(Coin7);
            generatePosition.AddToTilesList(Astroied);
            generatePosition.AddToTilesList(Astroied2);
            generatePosition.AddToTilesList(Astroied3);

            generatePosition.PopulatePositions();
        }

        private void TilesMove(int speed)
        {
            Coin.Top += speed;
            Coin2.Top += speed;
            Coin3.Top += speed;
            Coin4.Top += speed;
            Coin5.Top += speed;
            Coin6.Top += speed;
            Coin7.Top += speed;

            Astroied.Top += speed;
            Astroied2.Top += speed;
            Astroied3.Top += speed;
        }

        private void wait(int milliseconds)
        {
            engine.Wait(timer1, 100);
        }

        private void panelMovement()
        {
            engine.panelMovementLogic(panel1, carSpeed);
            engine.panelMovementLogic(panel2, carSpeed);
            engine.panelMovementLogic(panel3, carSpeed);
            engine.panelMovementLogic(panel4, carSpeed);
            engine.panelMovementLogic(panel5, carSpeed);

            //
            engine.panelMovementLogic(panel5, carSpeed);
            engine.panelMovementLogic(panel4, carSpeed);
            engine.panelMovementLogic(panel3, carSpeed);
            engine.panelMovementLogic(panel2, carSpeed);
            engine.panelMovementLogic(panel1, carSpeed);

        }

    }
}
