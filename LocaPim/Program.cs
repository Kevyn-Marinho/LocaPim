﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LocaPim.Login;
namespace LocaPim
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
            //Application.Run(new LocaPim.Login.frmLogin());
            Application.Run(new LocaPim.Cadastro.frmCadastrarCliente());
        }
    }
}
