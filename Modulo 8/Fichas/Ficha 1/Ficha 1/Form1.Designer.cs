namespace Ficha_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.LabelMensagem = new System.Windows.Forms.Label();
            this.butaotexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.BackColor = System.Drawing.Color.White;
            this.BotaoFechar.ForeColor = System.Drawing.Color.Black;
            this.BotaoFechar.Location = new System.Drawing.Point(228, 312);
            this.BotaoFechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(158, 68);
            this.BotaoFechar.TabIndex = 0;
            this.BotaoFechar.Text = "Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = false;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // LabelMensagem
            // 
            this.LabelMensagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMensagem.ForeColor = System.Drawing.Color.Black;
            this.LabelMensagem.Location = new System.Drawing.Point(180, 193);
            this.LabelMensagem.Name = "LabelMensagem";
            this.LabelMensagem.Size = new System.Drawing.Size(327, 105);
            this.LabelMensagem.TabIndex = 1;
            this.LabelMensagem.Text = "Programção e sistemas de informação";
            // 
            // butaotexto
            // 
            this.butaotexto.Location = new System.Drawing.Point(392, 312);
            this.butaotexto.Name = "butaotexto";
            this.butaotexto.Size = new System.Drawing.Size(155, 68);
            this.butaotexto.TabIndex = 2;
            this.butaotexto.Text = "Mudar texto";
            this.butaotexto.UseVisualStyleBackColor = true;
            this.butaotexto.Click += new System.EventHandler(this.butaotexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 481);
            this.Controls.Add(this.butaotexto);
            this.Controls.Add(this.LabelMensagem);
            this.Controls.Add(this.BotaoFechar);
            this.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.Label LabelMensagem;
        private System.Windows.Forms.Button butaotexto;
    }
}

