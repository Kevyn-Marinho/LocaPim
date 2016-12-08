using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Business;
//using MetroFramework.Forms;

namespace LocaPim.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
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
                new FrmMenuprincipal();
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") && (txtSenha.Text == ""))

            {
                FrmMenuprincipal frm2 = new FrmMenuprincipal();
                frm2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário e Senha incorretos!", "erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
