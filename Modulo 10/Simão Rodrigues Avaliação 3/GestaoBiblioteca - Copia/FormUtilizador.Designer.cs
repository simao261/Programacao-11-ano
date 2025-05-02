namespace GestaoBiblioteca
{
    partial class FormUtilizador
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
            this.Mensagem = new System.Windows.Forms.Label();
            this.UtilizadorId = new System.Windows.Forms.Label();
            this.Ativo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.BotaoOK = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Mensagem
            // 
            this.Mensagem.AutoSize = true;
            this.Mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagem.Location = new System.Drawing.Point(31, 76);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(482, 42);
            this.Mensagem.TabIndex = 0;
            this.Mensagem.Text = "Insira os dados do utilizador";
            // 
            // UtilizadorId
            // 
            this.UtilizadorId.AutoSize = true;
            this.UtilizadorId.Location = new System.Drawing.Point(44, 209);
            this.UtilizadorId.Name = "UtilizadorId";
            this.UtilizadorId.Size = new System.Drawing.Size(45, 30);
            this.UtilizadorId.TabIndex = 1;
            this.UtilizadorId.Text = "ID: ";
            // 
            // Ativo
            // 
            this.Ativo.AutoSize = true;
            this.Ativo.Location = new System.Drawing.Point(970, 209);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(95, 34);
            this.Ativo.TabIndex = 3;
            this.Ativo.Text = "&Ativo";
            this.Ativo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "&Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 544);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "&Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "&Username:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(167, 304);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(688, 37);
            this.Nome.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(167, 377);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(688, 37);
            this.Email.TabIndex = 7;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(184, 461);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(688, 37);
            this.Username.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(184, 541);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(688, 37);
            this.Password.TabIndex = 11;
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(709, 792);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(121, 43);
            this.BotaoOK.TabIndex = 12;
            this.BotaoOK.Text = "&OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(905, 792);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(121, 43);
            this.BotaoCancelar.TabIndex = 13;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // FormUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 862);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOK);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ativo);
            this.Controls.Add(this.UtilizadorId);
            this.Controls.Add(this.Mensagem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUtilizador";
            this.Text = "FormUtilizador";
            this.Load += new System.EventHandler(this.FormUtilizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mensagem;
        private System.Windows.Forms.Label UtilizadorId;
        private System.Windows.Forms.CheckBox Ativo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button BotaoOK;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Label label5;
    }
}