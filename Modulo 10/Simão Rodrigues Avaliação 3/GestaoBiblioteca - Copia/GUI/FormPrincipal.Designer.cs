namespace GestaoBiblioteca
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelTitutloAplicacao = new System.Windows.Forms.Label();
            this.LabelSubtituloAplicacao = new System.Windows.Forms.Label();
            this.BotaoUtilizadores = new System.Windows.Forms.Button();
            this.BotaoCatalogo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDaAplicacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitutloAplicacao
            // 
            this.LabelTitutloAplicacao.AutoSize = true;
            this.LabelTitutloAplicacao.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitutloAplicacao.Location = new System.Drawing.Point(385, 61);
            this.LabelTitutloAplicacao.Name = "LabelTitutloAplicacao";
            this.LabelTitutloAplicacao.Size = new System.Drawing.Size(132, 59);
            this.LabelTitutloAplicacao.TabIndex = 0;
            this.LabelTitutloAplicacao.Text = "Label";
            // 
            // LabelSubtituloAplicacao
            // 
            this.LabelSubtituloAplicacao.AutoSize = true;
            this.LabelSubtituloAplicacao.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubtituloAplicacao.Location = new System.Drawing.Point(274, 141);
            this.LabelSubtituloAplicacao.Name = "LabelSubtituloAplicacao";
            this.LabelSubtituloAplicacao.Size = new System.Drawing.Size(438, 40);
            this.LabelSubtituloAplicacao.TabIndex = 1;
            this.LabelSubtituloAplicacao.Text = "Sistema de Gestão de Bibliotecas";
            // 
            // BotaoUtilizadores
            // 
            this.BotaoUtilizadores.Location = new System.Drawing.Point(93, 547);
            this.BotaoUtilizadores.Name = "BotaoUtilizadores";
            this.BotaoUtilizadores.Size = new System.Drawing.Size(164, 38);
            this.BotaoUtilizadores.TabIndex = 4;
            this.BotaoUtilizadores.Text = "Utilizadores";
            this.BotaoUtilizadores.UseVisualStyleBackColor = true;
            // 
            // BotaoCatalogo
            // 
            this.BotaoCatalogo.Location = new System.Drawing.Point(374, 547);
            this.BotaoCatalogo.Name = "BotaoCatalogo";
            this.BotaoCatalogo.Size = new System.Drawing.Size(143, 38);
            this.BotaoCatalogo.TabIndex = 5;
            this.BotaoCatalogo.Text = "Catálogo";
            this.BotaoCatalogo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 40);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.fecharToolStripMenuItem.Text = "&Fechar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(186, 44);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDaAplicacaoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(95, 36);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // acercaDaAplicacaoToolStripMenuItem
            // 
            this.acercaDaAplicacaoToolStripMenuItem.Name = "acercaDaAplicacaoToolStripMenuItem";
            this.acercaDaAplicacaoToolStripMenuItem.Size = new System.Drawing.Size(355, 44);
            this.acercaDaAplicacaoToolStripMenuItem.Text = "Ac&erca da aplicacão";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestaoBiblioteca.Properties.Resources.catalogo;
            this.pictureBox2.Location = new System.Drawing.Point(331, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoBiblioteca.Properties.Resources.utilizadores;
            this.pictureBox1.Location = new System.Drawing.Point(81, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 654);
            this.Controls.Add(this.BotaoCatalogo);
            this.Controls.Add(this.BotaoUtilizadores);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelSubtituloAplicacao);
            this.Controls.Add(this.LabelTitutloAplicacao);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitutloAplicacao;
        private System.Windows.Forms.Label LabelSubtituloAplicacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BotaoUtilizadores;
        private System.Windows.Forms.Button BotaoCatalogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDaAplicacaoToolStripMenuItem;
    }
}

