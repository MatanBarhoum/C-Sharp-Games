using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    internal static class Program
    {
        public static bool OpenDetailFormOnClose { get; set; }
        public static bool GameOn { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenDetailFormOnClose = false;
            Application.Run(new Form1());
            while (GameOn)
            {
                if (OpenDetailFormOnClose)
                {
                    Application.Run(new EndGame());
                }
                else if (!OpenDetailFormOnClose)
                {
                    Application.Run(new Form1());
                }
            }
        }
    }
}
