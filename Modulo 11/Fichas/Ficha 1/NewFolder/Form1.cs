using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFolder
{
    public partial class FolderNew : Form
    {
        public FolderNew()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void FolderNew_Load(object sender, EventArgs e)
        {
            this.Text= "FolderNew";
            this.FormBorderStyle =  FormBorderStyle.FixedDialog;
            Resultado.ScrollBars = ScrollBars.Vertical;

            LocalizacaoPasta.ReadOnly = true;

        }

        /// <summary>
        /// Ver o sistema de ficheiros do computador e selecionar uma localização para criar a pasta.
         /// </summary>

        private void BotaoBrowse_Click(object sender, EventArgs e)
        {


            DialogResult resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                 LocalizacaoPasta.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        /// <summary>
        /// Fechar a aplicação.
        /// </summary>

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Criar a nova pasta.
        /// </summary>
        private void BotaoCriarPasta_Click(object sender, EventArgs e)
        {
            if ( NomePasta.Text == String.Empty || LocalizacaoPasta.Text == String.Empty)
            {
                MessageBox.Show("Especifique a localização e o nome da pasta", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pasta = Path.Combine(@LocalizacaoPasta.Text, NomePasta.Text);
            try
            {
                Directory.CreateDirectory(pasta);
            }
            catch (System.UnauthorizedAccessException)
            {
                Resultado.Text += $"Erro ao tentar criar a pasta {pasta}: o utilizador não possui permissões para executar a operação";
                return;
            }
            catch (System.IO.PathTooLongException)
            {
                Resultado.Text += $"Erro ao tentar criar a pasta {pasta}: path muito longa";
                return;
            }
            catch (IOException)
            {
                Resultado.Text += $"Erro ao tentar criar a pasta {pasta}: erro no sistema de ficheiros";
                return;
            }
            catch (Exception excecao)
            {
                Resultado.Text += $"Erro ao tentar criar a pasta {pasta}:{excecao.Message}";
                return;
            }
            Resultado.Text += $"({DateTime.Now}) Pasta Criada com Sucesso. {pasta}{System.Environment.NewLine}";
        }
    }
}

