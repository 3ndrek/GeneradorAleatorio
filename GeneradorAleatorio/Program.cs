﻿
using GeneradorAleatorio.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorAleatorio
{
    internal static class Program
    {
        internal static float deviation;
        internal static float mediaN;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PantallaSeleccionModo());

        }
    }
}
