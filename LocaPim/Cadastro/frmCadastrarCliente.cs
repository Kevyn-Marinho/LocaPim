using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Controllers.Business;

namespace LocaPim.Cadastro
{
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void carregaComboEstado()
        {
            CidadeController controller = new CidadeController();

            cmbEstado.DataSource = controller.Listar();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Endereco endereco = new Endereco();
            Cidade cidade = new Cidade();
            CidadeController cidadeCtl = new CidadeController();
            CarteiraDeMotorista cnh = new CarteiraDeMotorista();
            String dataNascimento;
            String dataEmissao;

            cliente.Nome = txtNome.Text;
            cliente.Sobrenome = txtSobrenome.Text;
            cliente.Rg = txtRG.Text;
            cliente.Cpf = txtCpf.Text;
            dataNascimento = txtDataNascimento.Text;
            dataNascimento = dataNascimento.Substring(0, 2) + "/" + dataNascimento.Substring(2, 2) + "/" + dataNascimento.Substring(4, 4);
            cliente.DataNascimento = DateTime.Parse(dataNascimento);

            cnh.Cnh = txtCnh.Text;
            cnh.Tipo = txtCategoria.Text;
            dataEmissao= txtDataNascimento.Text;
            dataEmissao = dataEmissao.Substring(0, 2) + "/" + dataEmissao.Substring(2, 2) + "/" + dataEmissao.Substring(4, 4);
            cnh.DataEmissao = DateTime.Parse(dataEmissao);
            //Colocar Data de vencimento

            cidade.NomeCidade = cmbCidade.SelectedText;
            //cidade.IdCidade = Integer.Parse(cmbCidade.SelectedValue.ToString();
            cidade = cidadeCtl.BuscaPorNome(cidade.NomeCidade);

            endereco.Cidade = cidade;
            endereco.Logradouro = txtEndereco.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Complemento = txtComplemento.Text;
            //Colocar Cep
            
            endereco.Logradouro = txtEndereco.Text;
            endereco.Numero = txtNumero.Text;
            endereco.Complemento = txtComplemento.Text;

            //cidade.NomeCidade = txtCidade.Text;

        


        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Consultar Cliente ?", "erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                LocaPim.Consultar.frmConsultarCliente CC = new Consultar.frmConsultarCliente();
                    CC.ShowDialog();
            }
        }

        private void btnSairClientes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair ?", "erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            carregaComboEstado();
        }
    }
}
