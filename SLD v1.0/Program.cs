using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Adelante.Core.AutoMapper;

namespace Adelante
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
            AutoMapperConfiguration.Register();
            Application.Run(new Principal()); 
        }
    }
}
