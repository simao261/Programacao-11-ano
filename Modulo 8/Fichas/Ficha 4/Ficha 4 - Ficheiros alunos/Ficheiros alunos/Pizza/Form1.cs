using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        private Encomenda encomendaCliente = new Encomenda();

        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            // A janela deverá surgir no centro do ecrã
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Text = "Dados de Encomenda";
            // Inicializar as entradas
            Entradas.Items.Add("");
            Entradas.Items.Add("Pão de alho (2 unidades): €2,50");
            Entradas.Items.Add("Pão de alho supremo (2 unidades): €3,50");
            // Impedir que o utilizador possa editar o texto da combobox
            Entradas.DropDownStyle = ComboBoxStyle.DropDownList;
            // Quantidade das entradas
            QuantidadeEntrada.Minimum = 0;
            QuantidadeEntrada.Maximum = 4;
            QuantidadeEntrada.Enabled = false;


            ListaPizzas.Items.Add("Pizza Margherita: €5,00");
            ListaPizzas.Items.Add("Pizza Camponesa: €7,00");
            ListaPizzas.Items.Add("Pizza Vegetariana: €6,80");
            // Selecionar o 1º elemento da lista
            ListaPizzas.SelectedIndex = 0;
            ImagemPizza.BorderStyle = BorderStyle.FixedSingle;
            ImagemPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            // Pré-selecionar entrega take away
            EntregaTakeAway.Checked = true;
        }

        /// <summary>
        /// Calcular e atualizar os totais com base na informação do formulário.
        /// </summary>
        private void AtualizarTotais()
        {
            encomendaCliente.CalcularTotais();
            LabelTotalSemIva.Text = $"{encomendaCliente.TotalSemIva.ToString("C")}";
            LabelTotalComIva.Text = $"{encomendaCliente.TotalComIva.ToString("C")}";
        }

        /// <summary>
        /// Mudança na entrada selecionada.
        /// </summary>
        private void Entradas_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (Entradas.SelectedItem.ToString())
            {
                case "":
                    QuantidadeEntrada.Value = 0;
                    QuantidadeEntrada.Enabled = false;
                    break;
                case "Pão de alho (2 unidades): €2,50":
                    encomendaCliente.Entrada = TipoEntrada.PaoAlho;
                    encomendaCliente.QuantidadeEntrada = 1;
                    QuantidadeEntrada.Value = 1;
                    QuantidadeEntrada.Enabled = true;
                    break;
                case "Pão de alho supremo (2 unidades): €3,50":
                    encomendaCliente.Entrada = TipoEntrada.PaoAlhoSupremo;
                    encomendaCliente.QuantidadeEntrada = 1;
                    QuantidadeEntrada.Value = 1;
                    QuantidadeEntrada.Enabled = true;
                    break;
            }
            AtualizarTotais();
        }

        /// <summary>
        /// Mudança na quantidade de entradas selecionadas.
        /// </summary>
        private void QuantidadeEntrada_ValueChanged(object sender, EventArgs e)
        {
            encomendaCliente.QuantidadeEntrada = (int)QuantidadeEntrada.Value;
            AtualizarTotais();
        }


        /// <summary>
        /// Selecionar uma pizza.
        /// </summary>
        private void ListaPizzas_SelectedValueChanged(object sender, EventArgs e)
        {
            // Determinar qual o item da lista que foi selecionado pelo utilizador
            switch (ListaPizzas.SelectedItem)
            {
                case "(selecione pizza)":
                    encomendaCliente.Pizza = TipoPizza.Nulo;
                    ImagemPizza.Image = null;
                    break;
                case "Pizza Margherita: €5,00":
                    encomendaCliente.Pizza = TipoPizza.Margherita;
                    ImagemPizza.Image = Pizza.Properties.Resources.margherita;
                    break;
                case "Pizza Camponesa: €7,00":
                    encomendaCliente.Pizza = TipoPizza.Camponesa;
                    ImagemPizza.Image = Pizza.Properties.Resources.camponesa;
                    break;
                case "Pizza Vegetariana: €6,80":
                    encomendaCliente.Pizza = TipoPizza.Vegetariana;
                    ImagemPizza.Image = Pizza.Properties.Resources.vegetariana;
                    break;
            }
            AtualizarTotais();
        }

        /// <summary>
        /// Selecionar (ou não) água.
        /// </summary>
        private void BebidaAgua_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaAgua = BebidaAgua.Checked;
            AtualizarTotais();
        }
        /// <summary>
        /// Selecionar (ou não) Coca-Cola.
        /// </summary>
        private void BebidaCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaCocaCola = BebidaCocaCola.Checked;
            AtualizarTotais();
        }
        /// <summary>
        /// Selecionar (ou não) sumo sem gás.
        /// </summary>
        private void BebidaSumoSemGas_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaSumoSemGas = BebidaSumoSemGas.Checked;
            AtualizarTotais();
        }
        /// <summary>
        /// Selecionar (ou não) sumo com gás.
        /// </summary>
        private void BebidaSumoComGas_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaSumoComGas = BebidaSumoComGas.Checked;
            AtualizarTotais();
        }

        /// <summary>
        /// Tipo de entrega: entrega take away.
        /// </summary>
        private void EntregaTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            if (EntregaTakeAway.Checked)
            {
                encomendaCliente.Entrega = MetodoEntrega.TakeAway;
                AtualizarTotais();
            }
        }
        /// <summary>
        /// Tipo de entrega: entrega em casa.
        /// </summary>
        private void EntregaCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (EntregaCasa.Checked)
            {
                encomendaCliente.Entrega = MetodoEntrega.Casa;
                AtualizarTotais();
            }
        }




        /// <summary>
        /// Limpar os dados do formulário.
        /// </summary>
        private void LimparCampos()
        {
            // Dados do cliente
            Nome.Text = string.Empty;
            Morada.Text = string.Empty;
            Contacto.Text = string.Empty;

            // Entradas
            Entradas.SelectedIndex = -1;
            QuantidadeEntrada.Value = 0;

            // Pizza
            ListaPizzas.SelectedIndex = 0;

            // Bebidas
            BebidaAgua.Checked = false;
            BebidaCocaCola.Checked = false;
            BebidaSumoSemGas.Checked = false;
            BebidaSumoComGas.Checked = false;

            // Tipo de entrega
            EntregaTakeAway.Checked = true;
        }

        private void BotaoFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Anular a encomenda.
        /// </summary>
        private void BotaoAnular_Click_1(object sender, EventArgs e)
        {
            // Confirmar que o utilizador pretende anular a encomenda
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja anular a encomenda?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                // Limpar os campos
                LimparCampos();
                // Atualizar os totais (se houver algum cálculo de total)
                AtualizarTotais();
            }
        }

        /// <summary>
        /// Validar a encomenda.
        /// </summary>
        private void BotaoValidar_Click_1(object sender, EventArgs e)
        {
            bool encomendaValida = true;
            StringBuilder mensagemErro = new StringBuilder();

            // Verificar se todos os campos pessoais estão preenchidos
            if (string.IsNullOrWhiteSpace(Nome.Text.Trim()))
            {
                mensagemErro.AppendLine("Por favor, preencha o campo Nome.");
                encomendaValida = false;
            }

            if (string.IsNullOrWhiteSpace(Morada.Text.Trim()))
            {
                mensagemErro.AppendLine("Por favor, preencha o campo Morada.");
                encomendaValida = false;
            }

            if (string.IsNullOrWhiteSpace(Contacto.Text.Trim()))
            {
                mensagemErro.AppendLine("Por favor, preencha o campo Contacto.");
                encomendaValida = false;
            }
            else if (!long.TryParse(Contacto.Text.Trim(), out _))
            {
                mensagemErro.AppendLine("Por favor, insira um número de contacto válido.");
                encomendaValida = false;
            }

            // Verificar se uma pizza foi selecionada
            if (ListaPizzas.SelectedIndex == 0)
            {
                mensagemErro.AppendLine("Por favor, selecione uma pizza.");
                encomendaValida = false;
            }

            // Exibir a mensagem de erro, se houver
            if (!encomendaValida)
            {
                MessageBox.Show(mensagemErro.ToString(), "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Encomenda válida e processada com sucesso.", "Encomenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Efetuar reset ao formulário: iniciar nova encomenda
                LimparCampos();
            }
        }
    }
}
