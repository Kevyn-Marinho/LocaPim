namespace frmtelalogin
{
    partial class frmConsultarCarros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCarros));
            this.dtgCarros = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tztConsultarMarcaCarro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultaModeloCarro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultarPlacaCarro = new System.Windows.Forms.TextBox();
            this.btnExcluirCarro = new System.Windows.Forms.Button();
            this.btnAlterarCarro = new System.Windows.Forms.Button();
            this.btnConsultarCarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCarros
            // 
            this.dtgCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCarros.Location = new System.Drawing.Point(10, 123);
            this.dtgCarros.Name = "dtgCarros";
            this.dtgCarros.Size = new System.Drawing.Size(609, 194);
            this.dtgCarros.TabIndex = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tztConsultarMarcaCarro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtConsultaModeloCarro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtConsultarPlacaCarro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 57);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Carros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marca:";
            // 
            // tztConsultarMarcaCarro
            // 
            this.tztConsultarMarcaCarro.Location = new System.Drawing.Point(426, 21);
            this.tztConsultarMarcaCarro.Name = "tztConsultarMarcaCarro";
            this.tztConsultarMarcaCarro.Size = new System.Drawing.Size(100, 20);
            this.tztConsultarMarcaCarro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo Carro:";
            // 
            // txtConsultaModeloCarro
            // 
            this.txtConsultaModeloCarro.Location = new System.Drawing.Point(265, 24);
            this.txtConsultaModeloCarro.Name = "txtConsultaModeloCarro";
            this.txtConsultaModeloCarro.Size = new System.Drawing.Size(100, 20);
            this.txtConsultaModeloCarro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa Carro:";
            // 
            // txtConsultarPlacaCarro
            // 
            this.txtConsultarPlacaCarro.Location = new System.Drawing.Point(74, 24);
            this.txtConsultarPlacaCarro.Name = "txtConsultarPlacaCarro";
            this.txtConsultarPlacaCarro.Size = new System.Drawing.Size(111, 20);
            this.txtConsultarPlacaCarro.TabIndex = 0;
            // 
            // btnExcluirCarro
            // 
            this.btnExcluirCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirCarro.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCarro.Image")));
            this.btnExcluirCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCarro.Location = new System.Drawing.Point(409, 75);
            this.btnExcluirCarro.Name = "btnExcluirCarro";
            this.btnExcluirCarro.Size = new System.Drawing.Size(121, 37);
            this.btnExcluirCarro.TabIndex = 6;
            this.btnExcluirCarro.Text = "Excluir Carro";
            this.btnExcluirCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirCarro.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCarro
            // 
            this.btnAlterarCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarCarro.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarCarro.Image")));
            this.btnAlterarCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarCarro.Location = new System.Drawing.Point(240, 75);
            this.btnAlterarCarro.Name = "btnAlterarCarro";
            this.btnAlterarCarro.Size = new System.Drawing.Size(114, 37);
            this.btnAlterarCarro.TabIndex = 5;
            this.btnAlterarCarro.Text = "Alterar Carro";
            this.btnAlterarCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarCarro.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCarro
            // 
            this.btnConsultarCarro.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarCarro.Image")));
            this.btnConsultarCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCarro.Location = new System.Drawing.Point(53, 75);
            this.btnConsultarCarro.Name = "btnConsultarCarro";
            this.btnConsultarCarro.Size = new System.Drawing.Size(130, 37);
            this.btnConsultarCarro.TabIndex = 4;
            this.btnConsultarCarro.Text = "Consultar Carro";
            this.btnConsultarCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarCarro.UseVisualStyleBackColor = true;
            // 
            // frmConsultarCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 410);
            this.Controls.Add(this.btnExcluirCarro);
            this.Controls.Add(this.btnAlterarCarro);
            this.Controls.Add(this.btnConsultarCarro);
            this.Controls.Add(this.dtgCarros);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarCarros";
            this.Text = "Consultar Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirCarro;
        private System.Windows.Forms.Button btnAlterarCarro;
        private System.Windows.Forms.Button btnConsultarCarro;
        private System.Windows.Forms.DataGridView dtgCarros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tztConsultarMarcaCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsultaModeloCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultarPlacaCarro;
    }
}