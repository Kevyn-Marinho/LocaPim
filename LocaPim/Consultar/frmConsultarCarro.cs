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
    public partial class frmConsultarCarro : Form
    {
        public frmConsultarCarro()
        {
            InitializeComponent();
            
        }

        private void btnCadastraCarro_Click(object sender, EventArgs e)
        {
            LocaPim.Cadastro.frmCadastraCarro f = new Cadastro.frmCadastraCarro();
            f.ShowDialog();
        }
    }
}
