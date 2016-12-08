namespace LocaPim.Locação
{
    partial class frmConsultarLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label placa_Label;
            System.Windows.Forms.Label renavan_Label;
            System.Windows.Forms.Label fabricante_Label;
            System.Windows.Forms.Label modelo_Carro_Label;
            System.Windows.Forms.Label iDCarroLabel;
            this.grpLocaçãoInformaçaovalores = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpLocaçãoInformaçaoCarro = new System.Windows.Forms.GroupBox();
            this.cmbCarros = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.txtModeloCarro = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.grpLocaçãoInformaçaoCliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            placa_Label = new System.Windows.Forms.Label();
            renavan_Label = new System.Windows.Forms.Label();
            fabricante_Label = new System.Windows.Forms.Label();
            modelo_Carro_Label = new System.Windows.Forms.Label();
            iDCarroLabel = new System.Windows.Forms.Label();
            this.grpLocaçãoInformaçaovalores.SuspendLayout();
            this.grpLocaçãoInformaçaoCarro.SuspendLayout();
            this.grpLocaçãoInformaçaoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLocaçãoInformaçaovalores
            // 
            this.grpLocaçãoInformaçaovalores.Controls.Add(label4);
            this.grpLocaçãoInformaçaovalores.Controls.Add(this.textBox2);
            this.grpLocaçãoInformaçaovalores.Location = new System.Drawing.Point(12, 265);
            this.grpLocaçãoInformaçaovalores.Name = "grpLocaçãoInformaçaovalores";
            this.grpLocaçãoInformaçaovalores.Size = new System.Drawing.Size(614, 122);
            this.grpLocaçãoInformaçaovalores.TabIndex = 4;
            this.grpLocaçãoInformaçaovalores.TabStop = false;
            this.grpLocaçãoInformaçaovalores.Text = "Valores";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 40);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 13);
            label4.TabIndex = 164;
            label4.Text = "Valor Diária:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(72, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 163;
            // 
            // grpLocaçãoInformaçaoCarro
            // 
            this.grpLocaçãoInformaçaoCarro.Controls.Add(this.cmbCarros);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(this.textBox1);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(label3);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(this.txtPlaca);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(this.txtValorDiaria);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(placa_Label);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(renavan_Label);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(this.txtModeloCarro);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(this.txtMarca);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(fabricante_Label);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(modelo_Carro_Label);
            this.grpLocaçãoInformaçaoCarro.Controls.Add(iDCarroLabel);
            this.grpLocaçãoInformaçaoCarro.Location = new System.Drawing.Point(12, 134);
            this.grpLocaçãoInformaçaoCarro.Name = "grpLocaçãoInformaçaoCarro";
            this.grpLocaçãoInformaçaoCarro.Size = new System.Drawing.Size(614, 113);
            this.grpLocaçãoInformaçaoCarro.TabIndex = 3;
            this.grpLocaçãoInformaçaoCarro.TabStop = false;
            this.grpLocaçãoInformaçaoCarro.Text = "Informações do Carro";
            // 
            // cmbCarros
            // 
            this.cmbCarros.FormattingEnabled = true;
            this.cmbCarros.Location = new System.Drawing.Point(51, 24);
            this.cmbCarros.Name = "cmbCarros";
            this.cmbCarros.Size = new System.Drawing.Size(121, 21);
            this.cmbCarros.TabIndex = 163;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(399, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(312, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 13);
            label3.TabIndex = 162;
            label3.Text = "Disponibilidade:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(49, 70);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 11;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(225, 70);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(73, 20);
            this.txtValorDiaria.TabIndex = 12;
            // 
            // placa_Label
            // 
            placa_Label.AutoSize = true;
            placa_Label.Location = new System.Drawing.Point(6, 73);
            placa_Label.Name = "placa_Label";
            placa_Label.Size = new System.Drawing.Size(37, 13);
            placa_Label.TabIndex = 159;
            placa_Label.Text = "Placa:";
            // 
            // renavan_Label
            // 
            renavan_Label.AutoSize = true;
            renavan_Label.Location = new System.Drawing.Point(155, 73);
            renavan_Label.Name = "renavan_Label";
            renavan_Label.Size = new System.Drawing.Size(64, 13);
            renavan_Label.TabIndex = 160;
            renavan_Label.Text = "Valor Diária:";
            // 
            // txtModeloCarro
            // 
            this.txtModeloCarro.Enabled = false;
            this.txtModeloCarro.Location = new System.Drawing.Point(252, 25);
            this.txtModeloCarro.Name = "txtModeloCarro";
            this.txtModeloCarro.Size = new System.Drawing.Size(92, 20);
            this.txtModeloCarro.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(399, 26);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 10;
            // 
            // fabricante_Label
            // 
            fabricante_Label.AutoSize = true;
            fabricante_Label.Location = new System.Drawing.Point(356, 29);
            fabricante_Label.Name = "fabricante_Label";
            fabricante_Label.Size = new System.Drawing.Size(40, 13);
            fabricante_Label.TabIndex = 156;
            fabricante_Label.Text = "Marca:";
            // 
            // modelo_Carro_Label
            // 
            modelo_Carro_Label.AutoSize = true;
            modelo_Carro_Label.Location = new System.Drawing.Point(178, 29);
            modelo_Carro_Label.Name = "modelo_Carro_Label";
            modelo_Carro_Label.Size = new System.Drawing.Size(73, 13);
            modelo_Carro_Label.TabIndex = 155;
            modelo_Carro_Label.Text = "Modelo Carro:";
            // 
            // iDCarroLabel
            // 
            iDCarroLabel.AutoSize = true;
            iDCarroLabel.Location = new System.Drawing.Point(6, 29);
            iDCarroLabel.Name = "iDCarroLabel";
            iDCarroLabel.Size = new System.Drawing.Size(46, 13);
            iDCarroLabel.TabIndex = 153;
            iDCarroLabel.Text = "IDCarro:";
            // 
            // grpLocaçãoInformaçaoCliente
            // 
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.label1);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.textBox3);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.txtSobrenome);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.txtCelular);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.label15);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.txtCnh);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.label9);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.txtDataNascimento);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.label14);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.txtNome);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.txtEndereco);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.label2);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.label5);
            this.grpLocaçãoInformaçaoCliente.Controls.Add(this.label20);
            this.grpLocaçãoInformaçaoCliente.Location = new System.Drawing.Point(12, 12);
            this.grpLocaçãoInformaçaoCliente.Name = "grpLocaçãoInformaçaoCliente";
            this.grpLocaçãoInformaçaoCliente.Size = new System.Drawing.Size(614, 116);
            this.grpLocaçãoInformaçaoCliente.TabIndex = 2;
            this.grpLocaçãoInformaçaoCliente.TabStop = false;
            this.grpLocaçãoInformaçaoCliente.Text = "Informações do Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero CPF:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(4, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 94;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Enabled = false;
            this.txtSobrenome.Location = new System.Drawing.Point(318, 36);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(148, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(480, 90);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(115, 20);
            this.txtCelular.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(487, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 90;
            this.label15.Text = "Numero da CNH:";
            // 
            // txtCnh
            // 
            this.txtCnh.Enabled = false;
            this.txtCnh.Location = new System.Drawing.Point(484, 35);
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(111, 20);
            this.txtCnh.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Sobrenome";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Enabled = false;
            this.txtDataNascimento.Location = new System.Drawing.Point(4, 90);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(109, 20);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(480, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 89;
            this.label14.Text = "Celular:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(151, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(152, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(140, 90);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(332, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Endereço";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 13);
            this.label20.TabIndex = 91;
            this.label20.Text = "Data de Nascimento:";
            // 
            // frmConsultarLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 474);
            this.Controls.Add(this.grpLocaçãoInformaçaovalores);
            this.Controls.Add(this.grpLocaçãoInformaçaoCarro);
            this.Controls.Add(this.grpLocaçãoInformaçaoCliente);
            this.Name = "frmConsultarLocacao";
            this.Text = "frmConsultarLocacao";
            this.grpLocaçãoInformaçaovalores.ResumeLayout(false);
            this.grpLocaçãoInformaçaovalores.PerformLayout();
            this.grpLocaçãoInformaçaoCarro.ResumeLayout(false);
            this.grpLocaçãoInformaçaoCarro.PerformLayout();
            this.grpLocaçãoInformaçaoCliente.ResumeLayout(false);
            this.grpLocaçãoInformaçaoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLocaçãoInformaçaovalores;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpLocaçãoInformaçaoCarro;
        private System.Windows.Forms.ComboBox cmbCarros;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.TextBox txtModeloCarro;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.GroupBox grpLocaçãoInformaçaoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
    }
}