namespace FileManager
{
    partial class Form1
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
            this.PathAtual = new System.Windows.Forms.TextBox();
            this.BotaoBrowse = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NumeroItens = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // PathAtual
            // 
            this.PathAtual.Location = new System.Drawing.Point(30, 36);
            this.PathAtual.Name = "PathAtual";
            this.PathAtual.Size = new System.Drawing.Size(1077, 31);
            this.PathAtual.TabIndex = 0;
            // 
            // BotaoBrowse
            // 
            this.BotaoBrowse.Location = new System.Drawing.Point(1143, 25);
            this.BotaoBrowse.Name = "BotaoBrowse";
            this.BotaoBrowse.Size = new System.Drawing.Size(144, 42);
            this.BotaoBrowse.TabIndex = 1;
            this.BotaoBrowse.Text = "&Browse...";
            this.BotaoBrowse.UseVisualStyleBackColor = true;
            this.BotaoBrowse.Click += new System.EventHandler(this.BotaoBrowse_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 100);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1257, 644);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NumeroItens
            // 
            this.NumeroItens.AutoSize = true;
            this.NumeroItens.Location = new System.Drawing.Point(30, 751);
            this.NumeroItens.Name = "NumeroItens";
            this.NumeroItens.Size = new System.Drawing.Size(70, 25);
            this.NumeroItens.TabIndex = 3;
            this.NumeroItens.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 786);
            this.Controls.Add(this.NumeroItens);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BotaoBrowse);
            this.Controls.Add(this.PathAtual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathAtual;
        private System.Windows.Forms.Button BotaoBrowse;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label NumeroItens;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

