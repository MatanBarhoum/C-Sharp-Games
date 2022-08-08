using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceShipGame.Randomizer;
using SpaceShipGame.Handler;
using SpaceShipGame.Model;

namespace SpaceShipGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(
                new LocationRandomizer(),
                new PlanetSpeedHandler(),
                new SpaceCraftMovementHandler(),
                new DamageHandler(new Planet(), new SpaceCraft()),
                new UseShield(),
                new Shield()
                ));
        }
    }
}
