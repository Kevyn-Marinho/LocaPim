using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
namespace LocaPim.Cadastro
{
    public partial class frmCadastrarFuncionario : Form
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            LocaPim.Consultar.fmrConsultar_funcionario Cons_Func = new Consultar.fmrConsultar_funcionario();
            Cons_Func.ShowDialog();
        }

        private void btnSairFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair ?", "erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
            }
        
            else
            {

            }
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            

        }
    }
}
