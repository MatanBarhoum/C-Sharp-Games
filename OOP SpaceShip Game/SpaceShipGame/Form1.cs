using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceShipGame.Randomizer;
using SpaceShipGame.Model;
using SpaceShipGame.Handler;

namespace SpaceShipGame
{
    public partial class Form1 : Form
    {
        private readonly LocationRandomizer _locationRandomizer;
        private readonly PlanetSpeedHandler _planet;
        private readonly SpaceCraftMovementHandler _craftMovement;
        private readonly DamageHandler _damageHandler;
        private readonly UseShield _ShieldControl;
        private readonly Shield _shield;

        public int _PlayerScore = 0;
        private int shieldcounter = 0;
        private bool canUseShield { get; set; }
        private bool usedShield = false;
        public Form1(LocationRandomizer locationRandomizer, PlanetSpeedHandler planet, SpaceCraftMovementHandler craftMovement, DamageHandler damageHandler, UseShield shieldControl, Shield shield)
        {
            InitializeComponent();
            _locationRandomizer = locationRandomizer;
            _planet = planet;
            _craftMovement = craftMovement;
            _damageHandler = damageHandler;
            _ShieldControl = shieldControl;
            _shield = shield;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _locationRandomizer.PlanetRandomizer(planet1, planet2, planet3, planet4, planet5);
        }

        private void gameMainTimer_Tick(object sender, EventArgs e)
        {
            if (_damageHandler.GetHP() == 75 && usedShield == false)
            {
                canUseShield = true;
            }
            if (planet1.Top > 525 && planet2.Top > 525 && planet3.Top > 525 && planet4.Top > 525 && planet5.Top > 525)
            {
                _locationRandomizer.PlanetRandomizer(planet1, planet2, planet3, planet4, planet5);
                _PlayerScore++;
                _planet.IncreaseSpeed(_PlayerScore);
                lblSpeed.Text = "Speed: " + _planet.planetSpeed.ToString();
                lblScore.Text = "Score: " + _PlayerScore;
                _damageHandler.ShowShield(imgShield, lblShield, lblPressSpace, canUseShield);
            }
            lblhp.Text = _damageHandler.TookDamage(SpaceCraft, planet1, planet2, planet3, planet4, planet5).ToString();
            _planet.PlanetMovementHandler(planet1, planet2, planet3, planet4, planet5);


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _craftMovement.SpaceCraftMove(e, SpaceCraft);
            if (canUseShield && e.KeyChar == ' ') 
            {
                _ShieldControl.PressedActivateShield(e, ShieldActivate); // calling the timer to start (ShieldActivate_Tick)
                imgShield.Visible = false;
                lblShield.Visible = false;
                lblPressSpace.Visible = false;
                canUseShield = false;
                usedShield = true;
            }
        }

        private void ShieldActivate_Tick(object sender, EventArgs e)
        {
            shieldcounter++;
            _ShieldControl.ActivateShield(Shieldimg, SpaceCraft, planet1, planet2, planet3, planet4, planet5);
            timeSpan1.Text = shieldcounter.ToString();
            if (shieldcounter == _shield.Time)
            {
                shieldcounter = 0;
                Shieldimg.Hide();
                ShieldActivate.Stop();
                ShieldActivate.Dispose();
                usedShield = false;
            }
        }
    }
}