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

    
    public partial class FormUtilizadores : Form
    {
        public FormUtilizadores()
        {
            InitializeComponent();
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormUtilizadores_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.CancelButton = BotaoFechar;
            this.Text = "Utilizadores";

            this.MinimumSize = new Size(816, 384);
            
            this.SizeGripStyle = SizeGripStyle.Show;


            // inicializar a ListView ListaUtilizadores
            ListaUtilizadores.View = View.Details;
            ListaUtilizadores.FullRowSelect = true;
            // Acrescentar as colunas à lista de utilizadores
            ListaUtilizadores.Columns.Add("Ativo", 50, HorizontalAlignment.Center);
            ListaUtilizadores.Columns.Add("ID", 240, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Username", 150, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Nome", 160, HorizontalAlignment.Left);
            ListaUtilizadores.Columns.Add("Email", -2, HorizontalAlignment.Left);

            

            // Popular a lista de utilizadores com dados
            PopularListaUtilizadores();

           

            this.ResumeLayout(false);
        }
        /// <summary>
        //! Inserir na lista de utilizadores, todos os utilizadores armazenados no sistema.
        /// </summary>

        private void PopularListaUtilizadores()
        {
            foreach (Utilizador u in Program.UtilizadoresPrograma.Dados.Values)
            {
                ListViewItem item = new ListViewItem(new string[] { (u.Ativo) ?  "Sim" : "Não" ,
                    u. ID. ToString(), u.Username, u.Nome, u. Email }); 
                ListaUtilizadores.Items.Add(item);


            }
                
        }



        /// <summary>
        /// Editar os dados de um utilizador.
        /// </summary>
        private void BotaoEditar_Click(object sender, EventArgs e)
        {
            FormUtilizador frmUtilizador = new FormUtilizador();
            frmUtilizador.ShowDialog();
            frmUtilizador.Dispose();
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Criar um novo utilizador.
        /// </summary>
        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            FormUtilizador frmUtilizador = new FormUtilizador();
            frmUtilizador.ShowDialog();
            frmUtilizador.Dispose();
        }

        private void BotaoEliminar_Click(object sender, EventArgs e)
        {
            // Verificar se o utilizador selecionou um elemento da lista
            if (ListaUtilizadores.SelectedItems.Count > 0)
            {
                int id;

                // Obter o ID do utilizador selecionado
                // (verificar se foi obtido um id (número inteiro) válido)
                if (Int32.TryParse(ListaUtilizadores.SelectedItems[0].SubItems[1].Text, out id))
                {
                    // A partir do id do utilizador, obter o nome e o username
                    string nome = Program.UtilizadoresPrograma.Dados[id].Nome;
                    string username = Program.UtilizadoresPrograma.Dados[id].Username;

                    // Confirmar esta operação
                    string msg = $"Confirma a remoção do utilizador selecionado?\n\nUtilizador: {nome}\nUsername: {username}";
                    if (MessageBox.Show(msg, "Eliminar Utilizador", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        // Executar a operação eliminar e obter o resultado da operação
                        ResultadoOperacao resultado = Program.UtilizadoresPrograma.Eliminar(id);

                        if (resultado == ResultadoOperacao.OK)
                        {
                            // Atualizar a lista de utilizadores
                            ListaUtilizadores.Items.Clear();
                            PopularListaUtilizadores();

                            MessageBox.Show("Registo eliminado com sucesso", "Eliminar Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Mostrar feedback caso tenha ocorrido um erro
                            MessageBox.Show("Ocorreu um erro ao tentar eliminar o utilizador", "Eliminar Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }
    }
}
