namespace GestaoBiblioteca.GUI
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
            this.BotaoCriar = new System.Windows.Forms.Button();
            this.BotaoEditar = new System.Windows.Forms.Button();
            this.BotaoEliminar = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestâo de Utilizadores ";
            // 
            // ListaUtilizadores
            // 
            this.ListaUtilizadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaUtilizadores.HideSelection = false;
            this.ListaUtilizadores.Location = new System.Drawing.Point(19, 103);
            this.ListaUtilizadores.Name = "ListaUtilizadores";
            this.ListaUtilizadores.Size = new System.Drawing.Size(1486, 718);
            this.ListaUtilizadores.TabIndex = 0;
            this.ListaUtilizadores.UseCompatibleStateImageBehavior = false;
            this.ListaUtilizadores.SelectedIndexChanged += new System.EventHandler(this.ListaUtilizadores_SelectedIndexChanged);
            // 
            // BotaoCriar
            // 
            this.BotaoCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoCriar.Location = new System.Drawing.Point(19, 864);
            this.BotaoCriar.Name = "BotaoCriar";
            this.BotaoCriar.Size = new System.Drawing.Size(196, 48);
            this.BotaoCriar.TabIndex = 1;
            this.BotaoCriar.Text = "&Criar utilizador";
            this.BotaoCriar.UseVisualStyleBackColor = true;
            this.BotaoCriar.Click += new System.EventHandler(this.BotaoCriar_Click);
            // 
            // BotaoEditar
            // 
            this.BotaoEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoEditar.Location = new System.Drawing.Point(247, 864);
            this.BotaoEditar.Name = "BotaoEditar";
            this.BotaoEditar.Size = new System.Drawing.Size(213, 48);
            this.BotaoEditar.TabIndex = 2;
            this.BotaoEditar.Text = "&Editar utilizador";
            this.BotaoEditar.UseVisualStyleBackColor = true;
            this.BotaoEditar.Click += new System.EventHandler(this.BotaoEditar_Click);
            // 
            // BotaoEliminar
            // 
            this.BotaoEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoEliminar.Location = new System.Drawing.Point(500, 864);
            this.BotaoEliminar.Name = "BotaoEliminar";
            this.BotaoEliminar.Size = new System.Drawing.Size(249, 52);
            this.BotaoEliminar.TabIndex = 3;
            this.BotaoEliminar.Text = "&Eliminar utilizadores";
            this.BotaoEliminar.UseVisualStyleBackColor = true;
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoFechar.Location = new System.Drawing.Point(1334, 864);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(144, 48);
            this.BotaoFechar.TabIndex = 4;
            this.BotaoFechar.Text = "&Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // FormUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 924);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoEliminar);
            this.Controls.Add(this.BotaoEditar);
            this.Controls.Add(this.BotaoCriar);
            this.Controls.Add(this.ListaUtilizadores);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUtilizadores";
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.FormUtilizadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListaUtilizadores;
        private System.Windows.Forms.Button BotaoCriar;
        private System.Windows.Forms.Button BotaoEditar;
        private System.Windows.Forms.Button BotaoEliminar;
        private System.Windows.Forms.Button BotaoFechar;
    }
}