﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistentGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TurnirAsistentModel.GlobalConfig.InitalizeConnectins(true, false);
                Application.Run(new Stvaranje_nagrade());
            // Application.Run(new PrijavaTurnir());
        }
    }
}
