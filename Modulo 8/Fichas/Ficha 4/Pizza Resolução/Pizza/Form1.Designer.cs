namespace Pizza
{
    partial class form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Morada = new System.Windows.Forms.TextBox();
            this.Contacto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Entradas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantidadeEntrada = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ListaPizzas = new System.Windows.Forms.ListBox();
            this.ImagemPizza = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelTotalSemIva = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelTotalComIva = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BebidaSumoComGas = new System.Windows.Forms.CheckBox();
            this.BebidaSumoSemGas = new System.Windows.Forms.CheckBox();
            this.BebidaCocaCola = new System.Windows.Forms.CheckBox();
            this.BebidaAgua = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EntregaCasa = new System.Windows.Forms.RadioButton();
            this.EntregaTakeAway = new System.Windows.Forms.RadioButton();
            this.BotaoValidar = new System.Windows.Forms.Button();
            this.BotaoAnular = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPizza)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "luigi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registo de encomendas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Nome Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "&Morada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "&Contacto:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(123, 76);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(150, 25);
            this.Nome.TabIndex = 4;
            // 
            // Morada
            // 
            this.Morada.Location = new System.Drawing.Point(123, 107);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(150, 25);
            this.Morada.TabIndex = 6;
            // 
            // Contacto
            // 
            this.Contacto.Location = new System.Drawing.Point(123, 137);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(87, 25);
            this.Contacto.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Entrada";
            // 
            // Entradas
            // 
            this.Entradas.FormattingEnabled = true;
            this.Entradas.Location = new System.Drawing.Point(123, 171);
            this.Entradas.Name = "Entradas";
            this.Entradas.Size = new System.Drawing.Size(150, 25);
            this.Entradas.TabIndex = 10;
            this.Entradas.SelectedValueChanged += new System.EventHandler(this.Entradas_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Quantidade";
            // 
            // QuantidadeEntrada
            // 
            this.QuantidadeEntrada.Location = new System.Drawing.Point(123, 208);
            this.QuantidadeEntrada.Name = "QuantidadeEntrada";
            this.QuantidadeEntrada.Size = new System.Drawing.Size(77, 25);
            this.QuantidadeEntrada.TabIndex = 12;
            this.QuantidadeEntrada.ValueChanged += new System.EventHandler(this.QuantidadeEntrada_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Pizza:";
            // 
            // ListaPizzas
            // 
            this.ListaPizzas.FormattingEnabled = true;
            this.ListaPizzas.ItemHeight = 17;
            this.ListaPizzas.Location = new System.Drawing.Point(17, 263);
            this.ListaPizzas.Name = "ListaPizzas";
            this.ListaPizzas.Size = new System.Drawing.Size(148, 72);
            this.ListaPizzas.TabIndex = 14;
            this.ListaPizzas.SelectedValueChanged += new System.EventHandler(this.ListaPizzas_SelectedValueChanged);
            // 
            // ImagemPizza
            // 
            this.ImagemPizza.Location = new System.Drawing.Point(171, 263);
            this.ImagemPizza.Name = "ImagemPizza";
            this.ImagemPizza.Size = new System.Drawing.Size(115, 100);
            this.ImagemPizza.TabIndex = 15;
            this.ImagemPizza.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(499, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total (sem iva)";
            // 
            // LabelTotalSemIva
            // 
            this.LabelTotalSemIva.AutoSize = true;
            this.LabelTotalSemIva.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalSemIva.Location = new System.Drawing.Point(533, 91);
            this.LabelTotalSemIva.Name = "LabelTotalSemIva";
            this.LabelTotalSemIva.Size = new System.Drawing.Size(67, 31);
            this.LabelTotalSemIva.TabIndex = 18;
            this.LabelTotalSemIva.Text = "€0,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(494, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 31);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total (Com iva)";
            // 
            // LabelTotalComIva
            // 
            this.LabelTotalComIva.AutoSize = true;
            this.LabelTotalComIva.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalComIva.ForeColor = System.Drawing.Color.Red;
            this.LabelTotalComIva.Location = new System.Drawing.Point(533, 174);
            this.LabelTotalComIva.Name = "LabelTotalComIva";
            this.LabelTotalComIva.Size = new System.Drawing.Size(67, 31);
            this.LabelTotalComIva.TabIndex = 20;
            this.LabelTotalComIva.Text = "€0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BebidaSumoComGas);
            this.groupBox1.Controls.Add(this.BebidaSumoSemGas);
            this.groupBox1.Controls.Add(this.BebidaCocaCola);
            this.groupBox1.Controls.Add(this.BebidaAgua);
            this.groupBox1.Location = new System.Drawing.Point(17, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 57);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bebida";
            // 
            // BebidaSumoComGas
            // 
            this.BebidaSumoComGas.AutoSize = true;
            this.BebidaSumoComGas.Location = new System.Drawing.Point(449, 20);
            this.BebidaSumoComGas.Name = "BebidaSumoComGas";
            this.BebidaSumoComGas.Size = new System.Drawing.Size(200, 21);
            this.BebidaSumoComGas.TabIndex = 3;
            this.BebidaSumoComGas.Text = "Sumo maçã (Com gás): €1,50";
            this.BebidaSumoComGas.UseVisualStyleBackColor = true;
            this.BebidaSumoComGas.CheckedChanged += new System.EventHandler(this.BebidaSumoComGas_CheckedChanged);
            // 
            // BebidaSumoSemGas
            // 
            this.BebidaSumoSemGas.AutoSize = true;
            this.BebidaSumoSemGas.Location = new System.Drawing.Point(245, 20);
            this.BebidaSumoSemGas.Name = "BebidaSumoSemGas";
            this.BebidaSumoSemGas.Size = new System.Drawing.Size(198, 21);
            this.BebidaSumoSemGas.TabIndex = 2;
            this.BebidaSumoSemGas.Text = "Sumo maçã (Sem gás): €1,50";
            this.BebidaSumoSemGas.UseVisualStyleBackColor = true;
            this.BebidaSumoSemGas.CheckedChanged += new System.EventHandler(this.BebidaSumoSemGas_CheckedChanged);
            // 
            // BebidaCocaCola
            // 
            this.BebidaCocaCola.AutoSize = true;
            this.BebidaCocaCola.Location = new System.Drawing.Point(106, 20);
            this.BebidaCocaCola.Name = "BebidaCocaCola";
            this.BebidaCocaCola.Size = new System.Drawing.Size(128, 21);
            this.BebidaCocaCola.TabIndex = 1;
            this.BebidaCocaCola.Text = "Coca-Cola: €1,90";
            this.BebidaCocaCola.UseVisualStyleBackColor = true;
            this.BebidaCocaCola.CheckedChanged += new System.EventHandler(this.BebidaCocaCola_CheckedChanged);
            // 
            // BebidaAgua
            // 
            this.BebidaAgua.AutoSize = true;
            this.BebidaAgua.Location = new System.Drawing.Point(8, 20);
            this.BebidaAgua.Name = "BebidaAgua";
            this.BebidaAgua.Size = new System.Drawing.Size(81, 21);
            this.BebidaAgua.TabIndex = 0;
            this.BebidaAgua.Text = "Água: €1";
            this.BebidaAgua.UseVisualStyleBackColor = true;
            this.BebidaAgua.CheckedChanged += new System.EventHandler(this.BebidaAgua_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EntregaCasa);
            this.groupBox2.Controls.Add(this.EntregaTakeAway);
            this.groupBox2.Location = new System.Drawing.Point(17, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 37);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Método de Entrega";
            // 
            // EntregaCasa
            // 
            this.EntregaCasa.AutoSize = true;
            this.EntregaCasa.Location = new System.Drawing.Point(124, 14);
            this.EntregaCasa.Name = "EntregaCasa";
            this.EntregaCasa.Size = new System.Drawing.Size(127, 21);
            this.EntregaCasa.TabIndex = 1;
            this.EntregaCasa.TabStop = true;
            this.EntregaCasa.Text = "Entrega Casa: €1";
            this.EntregaCasa.UseVisualStyleBackColor = true;
            this.EntregaCasa.CheckedChanged += new System.EventHandler(this.EntregaCasa_CheckedChanged);
            // 
            // EntregaTakeAway
            // 
            this.EntregaTakeAway.AutoSize = true;
            this.EntregaTakeAway.Location = new System.Drawing.Point(8, 14);
            this.EntregaTakeAway.Name = "EntregaTakeAway";
            this.EntregaTakeAway.Size = new System.Drawing.Size(110, 21);
            this.EntregaTakeAway.TabIndex = 0;
            this.EntregaTakeAway.TabStop = true;
            this.EntregaTakeAway.Text = "Take Away: €0";
            this.EntregaTakeAway.UseVisualStyleBackColor = true;
            this.EntregaTakeAway.CheckedChanged += new System.EventHandler(this.EntregaTakeAway_CheckedChanged);
            // 
            // BotaoValidar
            // 
            this.BotaoValidar.Location = new System.Drawing.Point(454, 439);
            this.BotaoValidar.Name = "BotaoValidar";
            this.BotaoValidar.Size = new System.Drawing.Size(75, 23);
            this.BotaoValidar.TabIndex = 21;
            this.BotaoValidar.Text = "Validar";
            this.BotaoValidar.UseVisualStyleBackColor = true;
            this.BotaoValidar.Click += new System.EventHandler(this.BotaoValidar_Click);
            // 
            // BotaoAnular
            // 
            this.BotaoAnular.Location = new System.Drawing.Point(535, 439);
            this.BotaoAnular.Name = "BotaoAnular";
            this.BotaoAnular.Size = new System.Drawing.Size(75, 23);
            this.BotaoAnular.TabIndex = 22;
            this.BotaoAnular.Text = "Anular";
            this.BotaoAnular.UseVisualStyleBackColor = true;
            this.BotaoAnular.Click += new System.EventHandler(this.BotaoAnular_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Location = new System.Drawing.Point(613, 439);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(75, 23);
            this.BotaoFechar.TabIndex = 23;
            this.BotaoFechar.Text = "Fechar";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 481);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoAnular);
            this.Controls.Add(this.BotaoValidar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelTotalComIva);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LabelTotalSemIva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ImagemPizza);
            this.Controls.Add(this.ListaPizzas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.QuantidadeEntrada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Entradas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Contacto);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "form1";
            this.Text = "Take Away: €0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemPizza)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Morada;
        private System.Windows.Forms.TextBox Contacto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Entradas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown QuantidadeEntrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox ListaPizzas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelTotalSemIva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LabelTotalComIva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox BebidaSumoComGas;
        private System.Windows.Forms.CheckBox BebidaSumoSemGas;
        private System.Windows.Forms.CheckBox BebidaCocaCola;
        private System.Windows.Forms.CheckBox BebidaAgua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton EntregaTakeAway;
        private System.Windows.Forms.RadioButton EntregaCasa;
        private System.Windows.Forms.Button BotaoValidar;
        private System.Windows.Forms.Button BotaoAnular;
        private System.Windows.Forms.Button BotaoFechar;
        private System.Windows.Forms.PictureBox ImagemPizza;
    }
}

