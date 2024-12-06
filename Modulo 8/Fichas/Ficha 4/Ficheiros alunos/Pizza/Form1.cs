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
    public partial class h : Form
    {
        private Encomenda encomendaCliente = new Encomenda();

        public h()
        {
            InitializeComponent();
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Validar a encomenda.
        /// </summary>
        private void BotaoValidar_Click(object sender, EventArgs e)
        {
            bool encomendaValida = true;

            // Verificar se os campos pessoais estão preenchidos
            if (string.IsNullOrEmpty(Nome.Text) || string.IsNullOrEmpty(Morada.Text) || string.IsNullOrEmpty(Contacto.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos pessoais (Nome, Morada, Contacto).", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                encomendaValida = false;
            }

            // Verificar se uma pizza foi selecionada
            if (ListaPizzas.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, selecione uma pizza.", "Seleção de Pizza", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                encomendaValida = false;
            }

            // Se a encomenda for válida
            if (encomendaValida)
            {
                MessageBox.Show("Encomenda válida e processada com sucesso.", "Encomenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Efetuar reset ao formulário: iniciar nova encomenda
                LimparCampos();
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


        /// <summary>
        /// Anular a encomenda.
        /// </summary>
        private void BotaoAnular_Click(object sender, EventArgs e)
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




        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
    

}

