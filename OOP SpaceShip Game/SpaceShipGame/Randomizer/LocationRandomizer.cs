using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace SpaceShipGame.Randomizer
{
    public class LocationRandomizer
    {
        Random random = new Random();
        private int ReturnPointX()
        {
            return random.Next(1, 565);
        }

        private int ReturnPointY()
        {
            return random.Next(-180, -100);
        }
        public void PlanetRandomizer(PictureBox planet1, PictureBox planet2, PictureBox planet3, PictureBox planet4, PictureBox planet5)
        {
            planet1.Location = new Point(ReturnPointX(), ReturnPointY());
            planet1.Visible = true;
            planet2.Location = new Point(ReturnPointX(), ReturnPointY() - 120);
            planet2.Visible = true;
            planet3.Location = new Point(ReturnPointX(), ReturnPointY() - 240);
            planet3.Visible = true;
            planet4.Location = new Point(ReturnPointX(), ReturnPointY() - 360);
            planet4.Visible = true;
            planet5.Location = new Point(ReturnPointX(), ReturnPointY() - 480);
            planet5.Visible = true;
        }
    }
}
