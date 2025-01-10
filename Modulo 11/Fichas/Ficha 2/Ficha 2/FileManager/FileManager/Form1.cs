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

namespace FileManager
{
    public partial class Form1 : Form
    {
        ImageList ListaImagens = new ImageList();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "File Manager";
            PathAtual.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BotaoBrowse.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            NumeroItens.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            NumeroItens.Text = "0 itens";
            // Criar uma lista de imagens para utilização no controlo listView1
            ListaImagens.ImageSize = new Size(24, 24);
            ListaImagens.Images.Add(FileManager.Properties.Resources.pasta);
            ListaImagens.Images.Add(FileManager.Properties.Resources.ficheiro);
            // Inicialização do controlo listView1
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right |
            AnchorStyles.Bottom;
            listView1.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Tamanho", 200, HorizontalAlignment.Right);
            listView1.Columns.Add("Data de modificação", -2, HorizontalAlignment.Left);
            listView1.SmallImageList = ListaImagens;
            // Impedir que o utilizador possa criar uma nova pasta no controlo folderBrowser1
            folderBrowserDialog1.ShowNewFolderButton = false;
        }
        /// <summary>
        /// Ver o sistema de ficheiros do computador e selecionar uma localização.
        /// </summary>
        private void BotaoBrowse_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                PathAtual.Text = folderBrowserDialog1.SelectedPath;
                // Obter pastas e ficheiros da localização selecionada
                PopularListaFilesystem();
            }
        }
        /// <summary>
        /// Popular a listview com as pastas e ficheiros de uma determinada localização.
        /// </summary>
        private void PopularListaFilesystem()
        {
            string s;
            FileInfo infoFicheiro;
            DirectoryInfo infoPasta;
            List<string> ficheiros;
            List<string> pastas;
            ListViewItem itemLista;
            // Remover itens já existentes na listview (lista de pastas e ficheiros)
            listView1.Items.Clear();
            // Obter as pastas e ficheiros da localização selecionada
            pastas = new List<string>(Directory.EnumerateDirectories(folderBrowserDialog1.SelectedPath));
            ficheiros = new List<string>(Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath));
            listView1.BeginUpdate();
            // Adicionar pastas à listview
            foreach (string pasta in pastas)
            {
                s = pasta.Substring(pasta.LastIndexOf('\\') + 1);
                infoPasta = new DirectoryInfo(pasta);
                itemLista = new ListViewItem(s, 0);
                itemLista.SubItems.Add(string.Empty);
                itemLista.SubItems.Add(infoPasta.LastWriteTime.ToString());
                listView1.Items.Add(itemLista);
            }
            // Adicionar ficheiros à listview
            foreach (string ficheiro in ficheiros)
            {
                s = ficheiro.Substring(ficheiro.LastIndexOf('\\') + 1);
                infoFicheiro = new FileInfo(ficheiro);
                itemLista = new ListViewItem(s, 1);
                itemLista.SubItems.Add($"{infoFicheiro.Length / 1024} KB");
                itemLista.SubItems.Add(infoFicheiro.LastWriteTime.ToString());
                listView1.Items.Add(itemLista);
            }
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.EndUpdate();
            // Atualizar o número de itens (pastas + ficheiros)
            NumeroItens.Text = $"{listView1.Items.Count} itens";

            try
            {
                pastas = new List<string>(Directory.EnumerateDirectories(folderBrowserDialog1.SelectedPath));
                ficheiros = new List<string>(Directory.EnumerateFiles(folderBrowserDialog1.SelectedPath));
            }

            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Acesso Negado! ({ex.Message})");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Erro: a localiazção especificada pelo utilizador não foi encontrada ou não é valida");
            }
        }
    }
}
