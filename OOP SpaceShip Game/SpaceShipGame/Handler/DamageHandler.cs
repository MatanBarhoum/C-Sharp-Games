using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SpaceShipGame.Model;

namespace SpaceShipGame.Handler
{
    public class DamageHandler
    {
        private readonly Planet _planet;
        private readonly SpaceCraft _craft;
        private bool beenHit = false;

        public DamageHandler(Planet planet, SpaceCraft craft)
        {
            _planet = planet;
            _craft = craft;
        }

        public int TookDamage(PictureBox spaceCraft, PictureBox planet1, PictureBox planet2, PictureBox planet3, PictureBox planet4, PictureBox planet5)
        {
            List<PictureBox> SpaceCraftList = new List<PictureBox>();
            SpaceCraftList.Add(planet1);
            SpaceCraftList.Add(planet2);
            SpaceCraftList.Add(planet3);
            SpaceCraftList.Add(planet4);
            SpaceCraftList.Add(planet5);

            for (var i = 0; i < SpaceCraftList.Count; i++)
            {
                if (spaceCraft.Bounds.IntersectsWith(SpaceCraftList[i].Bounds) && beenHit == false && SpaceCraftList[i].Visible == true)
                {
                    _craft.hp -= _planet.planetDamage;
                    SpaceCraftList[i].Visible = false;
                }
            }
            return _craft.hp;
        }

        public void ShowShield(PictureBox shield, Label lblShield, Label lblPressSpace, bool canUseShield)
        {
            if (canUseShield)
            {
                lblShield.Visible = true;
                lblPressSpace.Visible = true;
                shield.Visible = true;
            }
        }

        public int GetHP()
        {
            return _craft.hp;
        }
    }
}
