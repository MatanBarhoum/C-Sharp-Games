using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SpaceShipGame.Model;

namespace SpaceShipGame.Handler
{
    public class SpaceCraftMovementHandler : SpaceCraft
    {
        public void SpaceCraftMove(KeyPressEventArgs e, PictureBox spaceCraft)
        {
            if (e.KeyChar == 'w')
            {
                spaceCraft.Top -= spaceCraftSpeed;
            }
            else if (e.KeyChar == 's')
            {
                spaceCraft.Top += spaceCraftSpeed;
            }
            else if (e.KeyChar == 'a')
            {
                spaceCraft.Left -= spaceCraftSpeed;
            }
            else if (e.KeyChar == 'd')
            {
                spaceCraft.Left += spaceCraftSpeed;
            }
        }
    }
}
