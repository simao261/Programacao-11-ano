using System;
using System.Windows.Forms;

namespace Ficha_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Contacto
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }

            public override string ToString()
            {
                return $"{Nome} - {Email} - {Telefone}";
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            // Validação dos campos de texto
            if (string.IsNullOrWhiteSpace(Nome.Text) ||
                string.IsNullOrWhiteSpace(Email.Text) ||
                string.IsNullOrWhiteSpace(telefone.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contacto novoContacto = new Contacto
            {
                Nome = Nome.Text,
                Email = Email.Text,
                Telefone = telefone.Text
            };
            ContactosRegistados.Items.Add(novoContacto);
            LimparCampos();
        }

        private void LimparCampos()
        {
            Nome.Text = "";
            Email.Text = "";
            telefone.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ContactosRegistados.SelectedItem != null)
            {
                Contacto contactoSelecionado = (Contacto)ContactosRegistados.SelectedItem;

                // Validação antes da edição
                if (string.IsNullOrWhiteSpace(Nome.Text) ||
                    string.IsNullOrWhiteSpace(Email.Text) ||
                    string.IsNullOrWhiteSpace(telefone.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos antes de editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                contactoSelecionado.Nome = Nome.Text;
                contactoSelecionado.Email = Email.Text;
                contactoSelecionado.Telefone = telefone.Text;

                // Atualizar a lista com o contacto editado
                ContactosRegistados.Items[ContactosRegistados.SelectedIndex] = contactoSelecionado;
                LimparCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ContactosRegistados.SelectedItem != null)
            {
                ContactosRegistados.Items.Remove(ContactosRegistados.SelectedItem);
                LimparCampos();
            }
        }

        private void ContactosRegistados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactosRegistados.SelectedItem != null)
            {
                Contacto contactoSelecionado = (Contacto)ContactosRegistados.SelectedItem;
                Nome.Text = contactoSelecionado.Nome;
                Email.Text = contactoSelecionado.Email;
                telefone.Text = contactoSelecionado.Telefone;
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos(); // Apenas limpa os campos de texto
        }
    }
}
