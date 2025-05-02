namespace GestaoBiblioteca.GUI
{
    partial class FormAcercaAplicacao
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelNomeAplicacao = new System.Windows.Forms.Label();
            this.LabelVersão = new System.Windows.Forms.Label();
            this.LabelCopyRight = new System.Windows.Forms.Label();
            this.LinkRepositorio = new System.Windows.Forms.LinkLabel();
            this.BotaoOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoBiblioteca.Properties.Resources.livros;
            this.pictureBox1.Location = new System.Drawing.Point(45, 127);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LabelNomeAplicacao
            // 
            this.LabelNomeAplicacao.AutoSize = true;
            this.LabelNomeAplicacao.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeAplicacao.Location = new System.Drawing.Point(367, 151);
            this.LabelNomeAplicacao.Name = "LabelNomeAplicacao";
            this.LabelNomeAplicacao.Size = new System.Drawing.Size(166, 65);
            this.LabelNomeAplicacao.TabIndex = 1;
            this.LabelNomeAplicacao.Text = "label2";
            // 
            // LabelVersão
            // 
            this.LabelVersão.AutoSize = true;
            this.LabelVersão.Location = new System.Drawing.Point(378, 257);
            this.LabelVersão.Name = "LabelVersão";
            this.LabelVersão.Size = new System.Drawing.Size(71, 30);
            this.LabelVersão.TabIndex = 2;
            this.LabelVersão.Text = "label1";
            // 
            // LabelCopyRight
            // 
            this.LabelCopyRight.AutoSize = true;
            this.LabelCopyRight.Location = new System.Drawing.Point(373, 321);
            this.LabelCopyRight.Name = "LabelCopyRight";
            this.LabelCopyRight.Size = new System.Drawing.Size(71, 30);
            this.LabelCopyRight.TabIndex = 3;
            this.LabelCopyRight.Text = "label1";
            // 
            // LinkRepositorio
            // 
            this.LinkRepositorio.AutoSize = true;
            this.LinkRepositorio.Location = new System.Drawing.Point(373, 383);
            this.LinkRepositorio.Name = "LinkRepositorio";
            this.LinkRepositorio.Size = new System.Drawing.Size(109, 30);
            this.LinkRepositorio.TabIndex = 4;
            this.LinkRepositorio.TabStop = true;
            this.LinkRepositorio.Text = "linkLabel1";
            this.LinkRepositorio.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkRepositorio_LinkClicked);
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(914, 498);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(101, 42);
            this.BotaoOK.TabIndex = 5;
            this.BotaoOK.Text = "OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            this.BotaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // FormAcercaAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 552);
            this.Controls.Add(this.BotaoOK);
            this.Controls.Add(this.LinkRepositorio);
            this.Controls.Add(this.LabelCopyRight);
            this.Controls.Add(this.LabelVersão);
            this.Controls.Add(this.LabelNomeAplicacao);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAcercaAplicacao";
            this.Text = "FormAcercaAplicacao";
            this.Load += new System.EventHandler(this.FormAcercaAplicacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelNomeAplicacao;
        private System.Windows.Forms.Label LabelVersão;
        private System.Windows.Forms.Label LabelCopyRight;
        private System.Windows.Forms.LinkLabel LinkRepositorio;
        private System.Windows.Forms.Button BotaoOK;
    }
}