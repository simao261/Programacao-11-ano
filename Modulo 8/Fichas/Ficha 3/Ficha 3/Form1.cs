using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Apelido_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrimeiroNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Concatenar_Click(object sender, EventArgs e)
        {
             
            NomeCompleto.Text = PrimeiroNome.Text + " " + Apelido.Text;
        }
    

        private void Limpar_Click(object sender, EventArgs e)
        {
            
            PrimeiroNome.Text = "";
            Apelido.Text = "";
            NomeCompleto.Text = "";

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void NomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
