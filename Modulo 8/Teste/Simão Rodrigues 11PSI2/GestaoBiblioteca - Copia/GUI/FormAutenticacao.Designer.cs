namespace GestaoBiblioteca.GUI
{
    partial class FormAutenticacao
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
            this.LabelNomeAplicacao = new System.Windows.Forms.Label();
            this.ImagemAplicacao = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Utilizador = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelFeedback = new System.Windows.Forms.Label();
            this.BotaoOk = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemAplicacao)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeAplicacao
            // 
            this.LabelNomeAplicacao.AutoSize = true;
            this.LabelNomeAplicacao.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeAplicacao.Location = new System.Drawing.Point(362, 71);
            this.LabelNomeAplicacao.Name = "LabelNomeAplicacao";
            this.LabelNomeAplicacao.Size = new System.Drawing.Size(219, 86);
            this.LabelNomeAplicacao.TabIndex = 0;
            this.LabelNomeAplicacao.Text = "label3";
            this.LabelNomeAplicacao.Click += new System.EventHandler(this.LabelNomeAplicacao_Click);
            // 
            // ImagemAplicacao
            // 
            this.ImagemAplicacao.Image = global::GestaoBiblioteca.Properties.Resources.livros;
            this.ImagemAplicacao.Location = new System.Drawing.Point(381, 203);
            this.ImagemAplicacao.Name = "ImagemAplicacao";
            this.ImagemAplicacao.Size = new System.Drawing.Size(200, 200);
            this.ImagemAplicacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemAplicacao.TabIndex = 1;
            this.ImagemAplicacao.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Utilizador";
            // 
            // Utilizador
            // 
            this.Utilizador.Location = new System.Drawing.Point(310, 476);
            this.Utilizador.Name = "Utilizador";
            this.Utilizador.Size = new System.Drawing.Size(442, 37);
            this.Utilizador.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(310, 554);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(442, 37);
            this.Password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Password";
            // 
            // LabelFeedback
            // 
            this.LabelFeedback.AutoSize = true;
            this.LabelFeedback.Location = new System.Drawing.Point(279, 652);
            this.LabelFeedback.Name = "LabelFeedback";
            this.LabelFeedback.Size = new System.Drawing.Size(71, 30);
            this.LabelFeedback.TabIndex = 5;
            this.LabelFeedback.Text = "label3";
            // 
            // BotaoOk
            // 
            this.BotaoOk.Location = new System.Drawing.Point(550, 693);
            this.BotaoOk.Name = "BotaoOk";
            this.BotaoOk.Size = new System.Drawing.Size(108, 47);
            this.BotaoOk.TabIndex = 6;
            this.BotaoOk.Text = "&OK";
            this.BotaoOk.UseVisualStyleBackColor = true;
            this.BotaoOk.Click += new System.EventHandler(this.BotaoOk_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(708, 693);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(112, 47);
            this.BotaoCancelar.TabIndex = 7;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // FormAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 798);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOk);
            this.Controls.Add(this.LabelFeedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Utilizador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagemAplicacao);
            this.Controls.Add(this.LabelNomeAplicacao);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAutenticacao";
            this.Text = "FormAutenticacao";
            this.Load += new System.EventHandler(this.FormAutenticacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemAplicacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNomeAplicacao;
        private System.Windows.Forms.PictureBox ImagemAplicacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Utilizador;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelFeedback;
        private System.Windows.Forms.Button BotaoOk;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}