using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LocaPim
{
    public partial class FrmMenuprincipal : Form
    {
        public FrmMenuprincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuprincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            LocaPim.Cadastro.frmCadastrarCliente frm_CD_Cliente = new Cadastro.frmCadastrarCliente();
            frm_CD_Cliente.ShowDialog();
        }

        private void btnCadastraCarro_Click(object sender, EventArgs e)
        {
            LocaPim.Cadastro.frmCadastraCarro Cd_carro = new Cadastro.frmCadastraCarro();
            Cd_carro.ShowDialog();

        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocaPim.Cadastro.frmCadastraCarro Cd_carro = new Cadastro.frmCadastraCarro();
            Cd_carro.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LocaPim.Cadastro.frmCadastrarCliente frm_CD_Cliente = new Cadastro.frmCadastrarCliente();
            frm_CD_Cliente.ShowDialog();

        }
        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocaPim.Consultar.frmConsultarCarro Cs_Carro = new Consultar.frmConsultarCarro();
            Cs_Carro.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LocaPim.Consultar.frmConsultarCliente Cs_Cliente = new Consultar.frmConsultarCliente();
            Cs_Cliente.ShowDialog();
            
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocaPim.Cadastro.frmCadastrarFuncionario CD_Func = new Cadastro.frmCadastrarFuncionario();
            CD_Func.ShowDialog();
        }
    }
}
