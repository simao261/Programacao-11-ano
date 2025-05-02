namespace GestaoBiblioteca
{
    partial class FormUtilizadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListaUtilizadores = new System.Windows.Forms.ListView();
            this.BotaoUtilizadores = new System.Windows.Forms.Button();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.BotaoEliminar = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão de Utilizadores";
            // 
            // ListaUtilizadores
            // 
            this.ListaUtilizadores.HideSelection = false;
            this.ListaUtilizadores.Location = new System.Drawing.Point(57, 191);
            this.ListaUtilizadores.Name = "ListaUtilizadores";
            this.ListaUtilizadores.Size = new System.Drawing.Size(1321, 425);
            this.ListaUtilizadores.TabIndex = 0;
            this.ListaUtilizadores.UseCompatibleStateImageBehavior = false;
            // 
            // BotaoUtilizadores
            // 
            this.BotaoUtilizadores.Location = new System.Drawing.Point(52, 729);
            this.BotaoUtilizadores.Name = "BotaoUtilizadores";
            this.BotaoUtilizadores.Size = new System.Drawing.Size(210, 45);
            this.BotaoUtilizadores.TabIndex = 1;
            this.BotaoUtilizadores.Text = "&Criar Utilizadores";
            this.BotaoUtilizadores.UseVisualStyleBackColor = true;
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.Location = new System.Drawing.Point(291, 729);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(210, 45);
            this.BotaoEditar.TabIndex = 2;
            this.BotaoEditar.Text = "&Editar Utilizadores";
            this.BotaoEditar.UseVisualStyleBackColor = true;
            // 
            // BotaoEliminar
            // 
            this.BotaoEliminar.Location = new System.Drawing.Point(547, 729);
            this.BotaoEliminar.Name = "BotaoEliminar";
            this.BotaoEliminar.Size = new System.Drawing.Size(222, 45);
            this.BotaoEliminar.TabIndex = 3;
            this.BotaoEliminar.Text = "&Eliminar Utilizadores";
            this.BotaoEliminar.UseVisualStyleBackColor = true;
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Location = new System.Drawing.Point(1288, 729);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(132, 45);
            this.BotaoFechar.TabIndex = 4;
            this.BotaoFechar.Text = "&Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // FormUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 836);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoEliminar);
            this.Controls.Add(this.BotaoEditar);
            this.Controls.Add(this.BotaoUtilizadores);
            this.Controls.Add(this.ListaUtilizadores);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUtilizadores";
            this.Text = "FormUtilizadores";
            this.Load += new System.EventHandler(this.FormUtilizadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaUtilizadores;
        private System.Windows.Forms.Button BotaoUtilizadores;
        private System.Windows.Forms.Button BotaoEditar;
        private System.Windows.Forms.Button BotaoEliminar;
        private System.Windows.Forms.Button BotaoFechar;
    }
}