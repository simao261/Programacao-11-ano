using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca.GUI
{
    public partial class FormUtilizador : Form
    {
        public FormUtilizador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormUtilizador_Load(object sender, EventArgs e)
        {
            this.Text = "Criar Novo Utilizador";
            this.Mensagem.Text = "Insira os dados do novo utilizador";
            this.Utilizadorid.Text = "(por atribuir)";


            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.AcceptButton = BotaoOK;
            this.CancelButton = BotaoCancelar;

        }

        private void BotaoOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Mensagem_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
