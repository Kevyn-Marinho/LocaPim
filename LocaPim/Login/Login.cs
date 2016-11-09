using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Business;
using Model;

namespace LocaPim.Login
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private bool Logar()
        {

            UsuarioCtl control = new UsuarioCtl();
            Usuario usuario = control.Login(txtLogin.Text,txtPassword.Text);

            if (usuario !=null)
            {
                new FrmMain();
                this.Close();
            }
            
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLogin.Text))
            {
                lblMensagem.Text = "Favor preencher seu usuário.";
                return;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                lblMensagem.Text = "Favor digitar sua senha.";
                return;
            }

            if (!Logar())
            {
                lblMensagem.Text = "Usuário ou senha incorreto.";
            }
        }

        
    }
}
