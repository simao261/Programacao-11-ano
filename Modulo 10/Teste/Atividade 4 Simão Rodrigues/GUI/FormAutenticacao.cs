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
    public partial class FormAutenticacao : Form
    {
        /// <summary>
        /// Indica se o utilizador está autenticado ou não.
        /// </summary>
        public bool Autenticado { get; private set; } = false;  
        public FormAutenticacao()
        {
            InitializeComponent();

            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void FormAutenticacao_Load(object sender, EventArgs e)
        {

            this.SuspendLayout();
            this.AcceptButton = BotaoOk;
            this.CancelButton = BotaoCancelar;
            this.Text = "Autenticação";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            LabelNomeAplicacao.Text = Definicoes.NomeAplicacao;
            // Posicionar controlos
            ImagemAplicacao.Left = (this.ClientSize.Width / 2) - (ImagemAplicacao.Width / 2);
            LabelNomeAplicacao.Left = (this.ClientSize.Width / 2) - (LabelNomeAplicacao.Width / 2);
            LabelFeedback.Visible = false;
            Password.UseSystemPasswordChar = true;
            this.ResumeLayout(false);
        }
        /// <summary>
        /// Efetuar a autenticação.
        /// </summary>
        private void BotaoOk_Click(object sender, EventArgs e)
        {
            Autenticado = true;
            this.Close();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelNomeAplicacao_Click(object sender, EventArgs e)
        {

        }
    }
    
}
