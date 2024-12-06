namespace Ficha_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrimeiroNome = new System.Windows.Forms.TextBox();
            this.Apelido = new System.Windows.Forms.TextBox();
            this.NomeCompleto = new System.Windows.Forms.TextBox();
            this.Concatenar = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Primeiro nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Nome completo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Apelido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PrimeiroNome
            // 
            this.PrimeiroNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimeiroNome.Location = new System.Drawing.Point(294, 67);
            this.PrimeiroNome.Name = "PrimeiroNome";
            this.PrimeiroNome.Size = new System.Drawing.Size(478, 31);
            this.PrimeiroNome.TabIndex = 1;
            this.PrimeiroNome.TextChanged += new System.EventHandler(this.PrimeiroNome_TextChanged);
            // 
            // Apelido
            // 
            this.Apelido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Apelido.Location = new System.Drawing.Point(294, 122);
            this.Apelido.Name = "Apelido";
            this.Apelido.Size = new System.Drawing.Size(478, 31);
            this.Apelido.TabIndex = 3;
            this.Apelido.TextChanged += new System.EventHandler(this.Apelido_TextChanged);
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomeCompleto.Enabled = false;
            this.NomeCompleto.Location = new System.Drawing.Point(294, 174);
            this.NomeCompleto.Name = "NomeCompleto";
            this.NomeCompleto.Size = new System.Drawing.Size(478, 31);
            this.NomeCompleto.TabIndex = 5;
            this.NomeCompleto.TextChanged += new System.EventHandler(this.NomeCompleto_TextChanged);
            // 
            // Concatenar
            // 
            this.Concatenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Concatenar.Location = new System.Drawing.Point(378, 317);
            this.Concatenar.Name = "Concatenar";
            this.Concatenar.Size = new System.Drawing.Size(154, 44);
            this.Concatenar.TabIndex = 6;
            this.Concatenar.Text = "&Concatenar";
            this.Concatenar.UseVisualStyleBackColor = true;
            this.Concatenar.Click += new System.EventHandler(this.Concatenar_Click);
            // 
            // Limpar
            // 
            this.Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Limpar.Location = new System.Drawing.Point(550, 322);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(139, 39);
            this.Limpar.TabIndex = 7;
            this.Limpar.Text = "&Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Fechar.Location = new System.Drawing.Point(704, 322);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(103, 44);
            this.Fechar.TabIndex = 8;
            this.Fechar.Text = "&Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 373);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Concatenar);
            this.Controls.Add(this.NomeCompleto);
            this.Controls.Add(this.Apelido);
            this.Controls.Add(this.PrimeiroNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concatenar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrimeiroNome;
        private System.Windows.Forms.TextBox Apelido;
        private System.Windows.Forms.TextBox NomeCompleto;
        private System.Windows.Forms.Button Concatenar;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Fechar;
    }
}

