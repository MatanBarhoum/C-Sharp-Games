using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SpaceShipGame.Model;

namespace SpaceShipGame.Handler
{
    public class PlanetSpeedHandler : Planet
    {
        public void PlanetMovementHandler(PictureBox planet1, PictureBox planet2, PictureBox planet3, PictureBox planet4, PictureBox planet5)
        {
            if (planet1.Top > 525 && planet2.Top > 525 && planet3.Top > 525 && planet4.Top > 525 && planet5.Top > 525)
            {
                planet1.Top = -100;
                planet2.Top = -100;
                planet3.Top = -100;
                planet4.Top = -100;
                planet5.Top = -100;
            }
            planet1.Top += planetSpeed;
            planet2.Top += planetSpeed;
            planet3.Top += planetSpeed;
            planet4.Top += planetSpeed;
            planet5.Top += planetSpeed;
        }

        public void IncreaseSpeed(int playerScore)
        {
            if (playerScore % 5 == 0 && playerScore > 0)
            {
                planetSpeed += 2;
            }
        }
    }
}
