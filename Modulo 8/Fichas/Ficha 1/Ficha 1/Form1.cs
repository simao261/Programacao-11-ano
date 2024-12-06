using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fechar a Aplicação
        /// </summary>
        
        private void BotaoFechar_Click(object sender, EventArgs e)
        {
           this.Close();
            
        }
        /// <summary>
        /// Acrescentar texto ao label LabelMensagem.
        /// </summary>
        
        private void butaotexto_Click(object sender, EventArgs e)
        {
            LabelMensagem.Text += " É fixe!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
