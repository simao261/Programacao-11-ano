using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool TryGetNumbers(out decimal number1, out decimal number2)
        {
            
            number1 = 0;
            number2 = 0;

            bool isValid = decimal.TryParse(textBox1.Text, out number1) && decimal.TryParse(textBox2.Text, out number2);

            if (!isValid)
            {

                MessageBox.Show("Erro: Insira números válidos.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            labelResult.Text = "Resultado: ";
        }

        private void buttonMultiply_Click_1(object sender, EventArgs e)
        {
            if (TryGetNumbers(out decimal number1, out decimal number2))
            {
                labelResult.Text = $"Resultado: {number1 * number2}";
            }
        }

        private void buttonDivide_Click_1(object sender, EventArgs e)
        {
            if (TryGetNumbers(out decimal number1, out decimal number2))
            {
                if (number2 == 0)
                {
                    MessageBox.Show("Erro: Divisão por zero.", "Erro de Operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    labelResult.Text = $"Resultado: {number1 / number2}";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out decimal number1, out decimal number2))
            {
                labelResult.Text = $"Resultado: {number1 + number2}";
            }
        }

        private void buttonSubtract_Click_1(object sender, EventArgs e)
        {
            if (TryGetNumbers(out decimal number1, out decimal number2))
            {
                labelResult.Text = $"Resultado: {number1 - number2}";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar!=(char)Keys.Enter && e.KeyChar!=(char)Keys.Back && e.KeyChar!= (char)Keys.Delete)
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (!char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }


    }
}
