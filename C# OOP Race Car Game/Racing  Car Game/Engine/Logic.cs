using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Racing__Car_Game.Engine
{
    public class Logic
    {
        Random random = new Random();
        List<PictureBox> CoinsList = new List<PictureBox>();
        public int GenerateRandomX()
        {
            var randnum = random.Next(1, 426);
            return randnum;            
        }

        public int GenerateRandomY()
        {
            var randnum = random.Next(-200, -100);
            return randnum;
        }

        public void panelMovementLogic(Panel panel, int carSpeed) 
        {
            if (panel.Top > 610)
            {
                panel.Top = 610;
            }
            else
            {
                panel.Top += carSpeed;
            }

            if (panel.Top > 610)
            {
                panel.Top = -100;
            }
        }

        public void Wait(Timer timer, int miliseconds)
        {
            if (miliseconds == 0 || miliseconds < 0) return;

            timer.Interval = miliseconds;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += (s, e) =>
            {
                timer.Enabled = false;
                timer.Stop();
            };

            while (timer.Enabled)
            {
                Application.DoEvents();
            }
        }

        public void AddToCoinsList(PictureBox picture)
        {
            CoinsList.Add(picture);
        } 

        public bool CheckIfTouchedCoins(PictureBox car)
        {
            for (var i = 0; i < CoinsList.Count; i++)
            {
                if (car.Bounds.IntersectsWith(CoinsList[i].Bounds))
                {
                    CoinsList[i].Visible = false;
                    return true;

                }
            }
            return false;
        }

        public bool UserLost(Timer GameTimer, PictureBox Car, PictureBox Astroied, PictureBox Astroied2, PictureBox Astroied3)
        {
            if (Car.Bounds.IntersectsWith(Astroied.Bounds) || Car.Bounds.IntersectsWith(Astroied2.Bounds) || Car.Bounds.IntersectsWith(Astroied3.Bounds))
            {
                GameTimer.Stop();
                return true;
            }

            else if (Car.Left <= 0 || Car.Left > 440)
            {
                GameTimer.Stop();
                return true;
            }
            return false;
        }

        public void CheckRequirements(bool TouhcedCoin, int coins, int stage, int distanceCovered, PictureBox Astroied)
        {
            if (TouhcedCoin)
            {
                coins++;
            }
            if (Astroied.Top > 650)
            {
                Astroied.Location = new Point(this.GenerateRandomX(), -100);
                Astroied.Top = -100;
            }
            if (distanceCovered > 2000)
            {
                stage++;
            }
        }

        public bool CalculateScore(int distanceCovered)
        {
            if (distanceCovered % 50 == 0 && distanceCovered != 0)
            {
                return true;
            }
            return false; // if not.
        }
    }
}
