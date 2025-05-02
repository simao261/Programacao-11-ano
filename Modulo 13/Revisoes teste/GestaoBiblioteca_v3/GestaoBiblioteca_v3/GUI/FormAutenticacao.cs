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
        /// Required designer variable.
        /// Indica se o utilizador está autenticado ou não  11
        /// </summary>
        public bool Autenticado { get; private set; } = false;
        
        /// <summary>
        /// Adicionar código ao construtor 12
        /// </summary>
        public FormAutenticacao()
        {
            InitializeComponent();
            
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        /// <summary>
        /// Load do form  13
        /// </summary>
        
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
            ImagemAplicacao.Image = GestaoBiblioteca.Properties.Resources.livros;
            
            // Posicionar controlos
            ImagemAplicacao.Left = (this.ClientSize.Width / 2) - (ImagemAplicacao.Width / 2);
            LabelNomeAplicacao.Left = (this.ClientSize.Width / 2) - (LabelNomeAplicacao.Width / 2);

            LabelFeedback.Visible = false;
            Password.UseSystemPasswordChar = true;
            this.ResumeLayout(false);

            Utilizador.MaxLength = Definicoes.NomeUtilizadorMaxLenght;
            Password.MaxLength = Definicoes.PasswordMaxLength;


        }



        /// <summary>
        /// Efectuar a autenticação 15
        /// </summary>

        private void BotaoOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Utilizador.Text) || string.IsNullOrEmpty(Password.Text))
            {
                LabelFeedback.Text = "Autenticação inválida: Os campos necessários não estão preenchidos";
                LabelFeedback.ForeColor = Color.Red;  // Define a cor do texto para vermelho
                LabelFeedback.Visible = true;
                return; // Sai da função para evitar continuar a verificar os utilizadores
            }

            bool utilizadorEncontrado = false;

            foreach (Utilizador utilizador in Program.UtilizadoresPrograma.Dados.Values)
            {
                if (utilizador.Username == Utilizador.Text && utilizador.Password == Password.Text)
                {
                    utilizadorEncontrado = true;

                    if (utilizador.Ativo)
                    {
                        Autenticado = true;
                        this.Close();
                        return; // Sai da função após autenticação bem-sucedida
                    }
                    else
                    {
                        LabelFeedback.Text = "Autenticação inválida: Este utilizador não está ativo.";
                        LabelFeedback.ForeColor = Color.Red;
                        LabelFeedback.Visible = true;
                        return; // Sai da função para evitar sobreposição de mensagens
                    }
                }
            }

            // Se nenhum utilizador foi encontrado, mostra a mensagem de erro
            if (!utilizadorEncontrado)
            {
                LabelFeedback.Text = "Autenticação inválida: username e/ou password incorretos";
                LabelFeedback.ForeColor = Color.Red;
                LabelFeedback.Visible = true;
            }

        }

        /// <summary>
        /// Cancelar  14
        /// </summary>

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            //Autenticado = false;
            this.Close();
        }

        private void FormAutenticacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Autenticado == true)
            {

            }
            else
            {
                System.Environment.Exit(0);
            }
        }
    }
}
