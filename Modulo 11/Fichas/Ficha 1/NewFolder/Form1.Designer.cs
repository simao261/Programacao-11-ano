namespace NewFolder
{
    partial class FolderNew
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LocalizacaoPasta = new System.Windows.Forms.TextBox();
            this.BotaoBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NomePasta = new System.Windows.Forms.TextBox();
            this.BotaoCriarPasta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewFolder.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(37, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "FolderNew";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Localização:";
            // 
            // LocalizacaoPasta
            // 
            this.LocalizacaoPasta.Location = new System.Drawing.Point(203, 149);
            this.LocalizacaoPasta.Name = "LocalizacaoPasta";
            this.LocalizacaoPasta.Size = new System.Drawing.Size(409, 37);
            this.LocalizacaoPasta.TabIndex = 2;
            // 
            // BotaoBrowse
            // 
            this.BotaoBrowse.Location = new System.Drawing.Point(652, 150);
            this.BotaoBrowse.Name = "BotaoBrowse";
            this.BotaoBrowse.Size = new System.Drawing.Size(143, 36);
            this.BotaoBrowse.TabIndex = 3;
            this.BotaoBrowse.Text = "&Browse...";
            this.BotaoBrowse.UseVisualStyleBackColor = true;
            this.BotaoBrowse.Click += new System.EventHandler(this.BotaoBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Nome:";
            // 
            // NomePasta
            // 
            this.NomePasta.Location = new System.Drawing.Point(203, 200);
            this.NomePasta.Name = "NomePasta";
            this.NomePasta.Size = new System.Drawing.Size(359, 37);
            this.NomePasta.TabIndex = 5;
            // 
            // BotaoCriarPasta
            // 
            this.BotaoCriarPasta.Location = new System.Drawing.Point(203, 256);
            this.BotaoCriarPasta.Name = "BotaoCriarPasta";
            this.BotaoCriarPasta.Size = new System.Drawing.Size(139, 43);
            this.BotaoCriarPasta.TabIndex = 6;
            this.BotaoCriarPasta.Text = "&Criar Pasta";
            this.BotaoCriarPasta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Resultado:";
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(53, 401);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(771, 233);
            this.Resultado.TabIndex = 8;
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Location = new System.Drawing.Point(719, 640);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(106, 50);
            this.BotaoFechar.TabIndex = 9;
            this.BotaoFechar.Text = "&Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // FolderNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 714);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotaoCriarPasta);
            this.Controls.Add(this.NomePasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotaoBrowse);
            this.Controls.Add(this.LocalizacaoPasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FolderNew";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FolderNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LocalizacaoPasta;
        private System.Windows.Forms.Button BotaoBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomePasta;
        private System.Windows.Forms.Button BotaoCriarPasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

