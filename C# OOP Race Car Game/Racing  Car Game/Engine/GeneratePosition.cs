using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Racing__Car_Game.Engine
{
    public class GeneratePosition
    {
        Logic engine = new Logic();
        List<PictureBox> tilesList = new List<PictureBox>();
        public void AddToTilesList(PictureBox picture)
        {
            tilesList.Add(picture);
        }

        public void PopulatePositions()
        {
            for (var i = 0; i < tilesList.Count; i++)
            {
                if (tilesList[i].Top > 650)
                {
                    tilesList[i].Location = new Point(engine.GenerateRandomX(), engine.GenerateRandomY());
                    tilesList[i].Visible = true;
                }
            }

        }
    }
}
