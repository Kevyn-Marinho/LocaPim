namespace LocaPim
{
    partial class FrmMenuprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuprincipal));
            this.btnLocacao = new System.Windows.Forms.Button();
            this.btnCadastraCarro = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.stripPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLocacao
            // 
            this.btnLocacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocacao.Image = ((System.Drawing.Image)(resources.GetObject("btnLocacao.Image")));
            this.btnLocacao.Location = new System.Drawing.Point(200, 33);
            this.btnLocacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLocacao.Name = "btnLocacao";
            this.btnLocacao.Size = new System.Drawing.Size(88, 117);
            this.btnLocacao.TabIndex = 3;
            this.btnLocacao.Text = "Locação";
            this.btnLocacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocacao.UseVisualStyleBackColor = true;
            // 
            // btnCadastraCarro
            // 
            this.btnCadastraCarro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastraCarro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastraCarro.Image")));
            this.btnCadastraCarro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastraCarro.Location = new System.Drawing.Point(106, 33);
            this.btnCadastraCarro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastraCarro.Name = "btnCadastraCarro";
            this.btnCadastraCarro.Size = new System.Drawing.Size(88, 117);
            this.btnCadastraCarro.TabIndex = 2;
            this.btnCadastraCarro.Text = "Cadastrar Carro";
            this.btnCadastraCarro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastraCarro.UseVisualStyleBackColor = true;
            this.btnCadastraCarro.Click += new System.EventHandler(this.btnCadastraCarro_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Image = global::LocaPim.Properties.Resources.Clientes;
            this.btnCadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(12, 33);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(88, 117);
            this.btnCadastrarCliente.TabIndex = 1;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // stripPrincipal
            // 
            this.stripPrincipal.BackColor = System.Drawing.Color.Silver;
            this.stripPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stripPrincipal.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.reservaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.stripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.stripPrincipal.Name = "stripPrincipal";
            this.stripPrincipal.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.stripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.stripPrincipal.Size = new System.Drawing.Size(732, 29);
            this.stripPrincipal.TabIndex = 5;
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carrosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.funcionariosToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // carrosToolStripMenuItem
            // 
            this.carrosToolStripMenuItem.Name = "carrosToolStripMenuItem";
            this.carrosToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.carrosToolStripMenuItem.Text = "Carros";
            this.carrosToolStripMenuItem.Click += new System.EventHandler(this.carrosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem,
            this.clientesToolStripMenuItem1});
            this.consultarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.carroToolStripMenuItem.Text = "Carros";
            this.carroToolStripMenuItem.Click += new System.EventHandler(this.carroToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(126, 24);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devoluçãoToolStripMenuItem,
            this.locaçãoToolStripMenuItem});
            this.reservaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(139, 23);
            this.reservaToolStripMenuItem.Text = "Locação/Devolução";
            // 
            // devoluçãoToolStripMenuItem
            // 
            this.devoluçãoToolStripMenuItem.Name = "devoluçãoToolStripMenuItem";
            this.devoluçãoToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.devoluçãoToolStripMenuItem.Text = "Devolução";
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmMenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 456);
            this.Controls.Add(this.btnLocacao);
            this.Controls.Add(this.btnCadastraCarro);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.stripPrincipal);
            this.Name = "FrmMenuprincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuprincipal_Load);
            this.stripPrincipal.ResumeLayout(false);
            this.stripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocacao;
        private System.Windows.Forms.Button btnCadastraCarro;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.MenuStrip stripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
    }
}