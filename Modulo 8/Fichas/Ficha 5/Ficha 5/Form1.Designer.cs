namespace Ficha_5
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
            this.LabelNome = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.TextBox();
            this.Adicionarcontacto = new System.Windows.Forms.Button();
            this.Editarcontacto = new System.Windows.Forms.Button();
            this.Eliminarcontacto = new System.Windows.Forms.Button();
            this.Limparcampos = new System.Windows.Forms.Button();
            this.ContactosRegistados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(44, 45);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(68, 25);
            this.LabelNome.TabIndex = 0;
            this.LabelNome.Text = "Nome";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(134, 42);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(258, 31);
            this.Nome.TabIndex = 1;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(44, 97);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(63, 25);
            this.labelemail.TabIndex = 2;
            this.labelemail.Text = "email";
            this.labelemail.Click += new System.EventHandler(this.labelemail_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(134, 97);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(258, 31);
            this.Email.TabIndex = 3;
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Location = new System.Drawing.Point(44, 151);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(96, 25);
            this.labeltelefone.TabIndex = 4;
            this.labeltelefone.Text = "Telefone";
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(146, 151);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(246, 31);
            this.telefone.TabIndex = 5;
            // 
            // Adicionarcontacto
            // 
            this.Adicionarcontacto.Location = new System.Drawing.Point(327, 387);
            this.Adicionarcontacto.Name = "Adicionarcontacto";
            this.Adicionarcontacto.Size = new System.Drawing.Size(117, 51);
            this.Adicionarcontacto.TabIndex = 6;
            this.Adicionarcontacto.Text = "Adicionar";
            this.Adicionarcontacto.UseVisualStyleBackColor = true;
            this.Adicionarcontacto.Click += new System.EventHandler(this.Adicionarcontacto_Click);
            // 
            // Editarcontacto
            // 
            this.Editarcontacto.Location = new System.Drawing.Point(450, 390);
            this.Editarcontacto.Name = "Editarcontacto";
            this.Editarcontacto.Size = new System.Drawing.Size(97, 50);
            this.Editarcontacto.TabIndex = 7;
            this.Editarcontacto.Text = "editar";
            this.Editarcontacto.UseVisualStyleBackColor = true;
            this.Editarcontacto.Click += new System.EventHandler(this.Editarcontacto_Click);
            // 
            // Eliminarcontacto
            // 
            this.Eliminarcontacto.Location = new System.Drawing.Point(553, 389);
            this.Eliminarcontacto.Name = "Eliminarcontacto";
            this.Eliminarcontacto.Size = new System.Drawing.Size(110, 51);
            this.Eliminarcontacto.TabIndex = 8;
            this.Eliminarcontacto.Text = "Eliminar";
            this.Eliminarcontacto.UseVisualStyleBackColor = true;
            this.Eliminarcontacto.Click += new System.EventHandler(this.Eliminarcontacto_Click);
            // 
            // Limparcampos
            // 
            this.Limparcampos.Location = new System.Drawing.Point(669, 389);
            this.Limparcampos.Name = "Limparcampos";
            this.Limparcampos.Size = new System.Drawing.Size(99, 49);
            this.Limparcampos.TabIndex = 9;
            this.Limparcampos.Text = "Limpar";
            this.Limparcampos.UseVisualStyleBackColor = true;
            this.Limparcampos.Click += new System.EventHandler(this.Limparcampos_Click);
            // 
            // ContactosRegistados
            // 
            this.ContactosRegistados.FormattingEnabled = true;
            this.ContactosRegistados.ItemHeight = 25;
            this.ContactosRegistados.Location = new System.Drawing.Point(431, 28);
            this.ContactosRegistados.Name = "ContactosRegistados";
            this.ContactosRegistados.Size = new System.Drawing.Size(326, 154);
            this.ContactosRegistados.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContactosRegistados);
            this.Controls.Add(this.Limparcampos);
            this.Controls.Add(this.Eliminarcontacto);
            this.Controls.Add(this.Editarcontacto);
            this.Controls.Add(this.Adicionarcontacto);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.LabelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Button Adicionarcontacto;
        private System.Windows.Forms.Button Editarcontacto;
        private System.Windows.Forms.Button Eliminarcontacto;
        private System.Windows.Forms.Button Limparcampos;
        private System.Windows.Forms.ListBox ContactosRegistados;
    }
}

