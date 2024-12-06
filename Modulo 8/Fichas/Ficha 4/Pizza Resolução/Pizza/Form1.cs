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
    public partial class form1 : Form
    {
        private Encomenda encomendaCliente = new Encomenda();

        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            // Inicializar as pizzas
            ListaPizzas.Items.Add("(selecione pizza)");
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

        private void AtualizarTotais()
        {
            encomendaCliente.CalcularTotais();
            LabelTotalSemIva.Text = $"{encomendaCliente.TotalSemIva.ToString("C")}";
            LabelTotalComIva.Text = $"{encomendaCliente.TotalComIva.ToString("C")}";
        }
      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void QuantidadeEntrada_ValueChanged(object sender, EventArgs e)
        {
            encomendaCliente.QuantidadeEntrada = (int)QuantidadeEntrada.Value;
            AtualizarTotais();
        }

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

        private void BebidaSumoComGas_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaSumoComGas = BebidaSumoComGas.Checked;
            AtualizarTotais();
        }

        private void BebidaAgua_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaAgua = BebidaAgua.Checked;
            AtualizarTotais();
        }

        private void BebidaCocaCola_CheckedChanged(object sender, EventArgs e)
        {
                encomendaCliente.BebidaCocaCola = BebidaCocaCola.Checked;
                AtualizarTotais(); 
        }

        private void BebidaSumoSemGas_CheckedChanged(object sender, EventArgs e)
        {
            encomendaCliente.BebidaSumoSemGas = BebidaSumoSemGas.Checked;
            AtualizarTotais();
        }

        private void EntregaTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            if (EntregaTakeAway.Checked)
            {
                encomendaCliente.Entrega = MetodoEntrega.TakeAway;
                AtualizarTotais();
            }
        }

        private void EntregaCasa_CheckedChanged(object sender, EventArgs e)
        {
            if (EntregaCasa.Checked)
            {
                encomendaCliente.Entrega = MetodoEntrega.Casa;
                AtualizarTotais();
            }
        }

        private void BotaoValidar_Click(object sender, EventArgs e)
        {
            bool validarencomenda = true;

            if (Nome.Text == "" || Morada.Text == "" || Contacto.Text == "")
            {
                MessageBox.Show("Dados de cliente em falta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validarencomenda = false;
            }
            else if (ListaPizzas.SelectedIndex == 0)
            {
                MessageBox.Show("Escolha a pizza!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validarencomenda = false;
            }
            if (validarencomenda )
            {
                MessageBox.Show("Encomenda Validada e confirmada.\nObrigado!","Encomenda Validada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

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

        private void LimparCampos()
        {
            // Dados do cliente
            Nome.Text = "";
            Morada.Text = "";
            Contacto.Text = "";
            // Entradas
            Entradas.SelectedIndex = 0;
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
            EntregaCasa.Checked = false;
        }

        private void BotaoAnular_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirma a anulação da encomenda?", "Anular Encomenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimparCampos();
                AtualizarTotais();
            }

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
