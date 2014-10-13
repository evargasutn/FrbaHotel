using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DOM;
using FrbaHotel.ABM_de_Rol;

namespace FrbaHotel
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
            //Application.Run(new Inicial());
            Application.Run(new FormRol());
        }
    }
}
