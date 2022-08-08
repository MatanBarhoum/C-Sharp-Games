using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using SpaceShipGame.Model;
namespace SpaceShipGame.Handler
{
    public class UseShield : Shield
    {
        public void PlayerUsedShield(PictureBox shield, PictureBox planet1, PictureBox planet2, PictureBox planet3, PictureBox planet4, PictureBox planet5)
        {
            List<PictureBox> planets = new List<PictureBox>();
            planets.Add(planet1);
            planets.Add(planet2);
            planets.Add(planet3);
            planets.Add(planet4);
            planets.Add(planet5);

            for (var i = 0; i < planets.Count; i++)
            {
                if (shield.Bounds.IntersectsWith(planets[i].Bounds) && planets[i].Visible == true)
                {
                    planets[i].Visible = false;
                }
            }
        }

        public void ActivateShield(PictureBox shield, PictureBox spaceCraft, PictureBox planet1, PictureBox planet2, PictureBox planet3, PictureBox planet4, PictureBox planet5)
        {
            int x = spaceCraft.Location.X;
            int y = spaceCraft.Location.Y;
            shield.Visible = true;
            shield.Location = new Point(x - 46, y - 34);
            PlayerUsedShield(shield, planet1, planet2, planet3, planet4, planet5);
        }

        public void PressedActivateShield(KeyPressEventArgs e, Timer shieldtimer)
        {
            if (e.KeyChar == ' ')
            {
                shieldtimer.Start();
            }
        }
    }
}
