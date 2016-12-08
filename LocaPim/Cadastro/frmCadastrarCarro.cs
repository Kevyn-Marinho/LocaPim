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
    public partial class frmCadastraCarro : Form
    {
        public frmCadastraCarro()
        {
            InitializeComponent();
        }

        private void frmCadastraCarro_Load(object sender, EventArgs e)
        {
            carregarModeloCarro();
        }

        private void btnConsultarCarro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Consultar Carro?", "erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                LocaPim.Consultar.frmConsultarCarro Con = new Consultar.frmConsultarCarro();
                Con.ShowDialog();
            }  
        }

        private void btnSairCadCarros_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair ?", "erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
            }

         }

        private void btnSalvarCarro_Click(object sender, EventArgs e)
        {
           Carro carro = new Model.Carro();
           

        }

        private void carregarModeloCarro() {
               




        }
}
}
