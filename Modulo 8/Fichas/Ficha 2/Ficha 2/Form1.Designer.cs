namespace Ficha_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Botaok = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(284, 99);
            this.Username.MaxLength = 30;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(205, 35);
            this.Username.TabIndex = 2;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(284, 150);
            this.Password.MaxLength = 255;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(205, 35);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Botaok
            // 
            this.Botaok.Location = new System.Drawing.Point(332, 284);
            this.Botaok.Name = "Botaok";
            this.Botaok.Size = new System.Drawing.Size(109, 45);
            this.Botaok.TabIndex = 5;
            this.Botaok.Text = "Ok";
            this.Botaok.UseVisualStyleBackColor = true;
            this.Botaok.Click += new System.EventHandler(this.Botaok_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BotaoCancelar.Location = new System.Drawing.Point(447, 284);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(146, 45);
            this.BotaoCancelar.TabIndex = 6;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Botaok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BotaoCancelar;
            this.ClientSize = new System.Drawing.Size(629, 368);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.Botaok);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Botaok;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}

