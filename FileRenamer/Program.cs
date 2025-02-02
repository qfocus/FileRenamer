﻿using System;
using System.Windows.Forms;
using Unity;

namespace FileRenamer.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var container = new UnityContainer())
            {
                ContainerBootstrapper.RegisterTypes(container);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(container));
            }
        }
    }
}
