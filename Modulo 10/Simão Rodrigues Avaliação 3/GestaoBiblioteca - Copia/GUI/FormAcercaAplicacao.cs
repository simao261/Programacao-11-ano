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
    public partial class FormAcercaAplicacao : Form
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        public FormAcercaAplicacao()
        {
            InitializeComponent();
           

        }

        private void FormAcercaAplicacao_Load(object sender, EventArgs e)
        {
            this.AcceptButton = BotaoOK;
            this.Text = "Acerca desta aplicação";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            LabelNomeAplicacao.Text = Definicoes.NomeAplicacao;
            LabelCopyRight.Text = "© 2024 Simão Rodrigues ";
            LinkRepositorio.Text = "https://www.google.com/?client=safari";
            LabelVersão.Text = "0.1";
        }
        /// <summary>
        /// Fechar a janela.
        /// </summary>
        private void BotaoOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Abrir a hiperligação
        /// </summary>
        private void LinkRepositorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Especificar que a hiperligação foi visitada
            LinkRepositorio.LinkVisited = true;
            // Abrir a hiperligação
            System.Diagnostics.Process.Start(LinkRepositorio.Text);
        }
    }
}
