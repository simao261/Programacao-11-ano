using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ficha_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Fechar a aplicação.
        /// </summary>
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Validar os dados de login.
        /// </summary>
        private void Botaok_Click(object sender, EventArgs e)
        {
            // Verificar que as textboxes não estão vazias
            if (Username.Text != string.Empty && Password.Text != string.Empty)
            {
                // Validar o username e a password
                if (utilizadores.Contains(new Utilizador(Username.Text, Password.Text)))
                {
                    MessageBox.Show("Os dados de login estão corretos", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Os dados de login estão incorretos.\nPor favor tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Preencha o username e a password", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Armazena dados de um utilizador.
        /// </summary>
        private struct Utilizador
        {
            public string username;
            public string password;
            public Utilizador(string _username, string _password)
            {
                username = _username;
                password = _password;
            }
        }

        /// <summary>
        /// Lista de utilizadores.
        /// </summary>
        private List<Utilizador> utilizadores = new List<Utilizador>();

        /// <summary>
        /// Inicializar os componentes da form.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar a lista de utilizadores.
            utilizadores.Add(new Utilizador("pato", "donald"));
            utilizadores.Add(new Utilizador("eça", "queirós"));
            utilizadores.Add(new Utilizador("anon", "123"));
            utilizadores.Add(new Utilizador("x", "y"));
        }
    }
}
