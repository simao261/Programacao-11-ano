namespace GestaoBiblioteca.GUI
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
            this.ID = new System.Windows.Forms.Label();
            this.Utilizadorid = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.BotaoOK = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mensagem
            // 
            this.Mensagem.AutoSize = true;
            this.Mensagem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensagem.Location = new System.Drawing.Point(12, 26);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(130, 54);
            this.Mensagem.TabIndex = 0;
            this.Mensagem.Text = "label1";
            this.Mensagem.Click += new System.EventHandler(this.Mensagem_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 102);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(39, 30);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID:";
            // 
            // Utilizadorid
            // 
            this.Utilizadorid.AutoSize = true;
            this.Utilizadorid.Location = new System.Drawing.Point(57, 102);
            this.Utilizadorid.Name = "Utilizadorid";
            this.Utilizadorid.Size = new System.Drawing.Size(71, 30);
            this.Utilizadorid.TabIndex = 2;
            this.Utilizadorid.Text = "label6";
            this.Utilizadorid.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(739, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 34);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "&Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Nome:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(111, 181);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(723, 37);
            this.Nome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "&Email:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(111, 269);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(723, 37);
            this.Email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "&Username:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(153, 348);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(681, 37);
            this.Username.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "&Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(153, 437);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(681, 37);
            this.Password.TabIndex = 11;
            // 
            // BotaoOK
            // 
            this.BotaoOK.Location = new System.Drawing.Point(551, 515);
            this.BotaoOK.Name = "BotaoOK";
            this.BotaoOK.Size = new System.Drawing.Size(112, 49);
            this.BotaoOK.TabIndex = 12;
            this.BotaoOK.Text = "&OK";
            this.BotaoOK.UseVisualStyleBackColor = true;
            this.BotaoOK.Click += new System.EventHandler(this.BotaoOK_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(719, 515);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(115, 49);
            this.BotaoCancelar.TabIndex = 13;
            this.BotaoCancelar.Text = "&Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // FormUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 576);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoOK);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Utilizadorid);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Mensagem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUtilizador";
            this.Text = "FormUtilizador";
            this.Load += new System.EventHandler(this.FormUtilizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mensagem;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Utilizadorid;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button BotaoOK;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}