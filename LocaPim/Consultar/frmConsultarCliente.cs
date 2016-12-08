using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocaPim.Consultar
{
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
            txtConsultaRg.Focus();
        }

        private void btnConsultarfrmConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            

            LocaPim.Cadastro.frmCadastrarCliente C = new Cadastro.frmCadastrarCliente();
            C.ShowDialog();
                          
                }
    }
}
