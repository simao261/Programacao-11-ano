using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca
{
    public partial class FormUtilizador : Form
    {
        public FormUtilizador()
        {
            InitializeComponent();
        }

        private void FormUtilizador_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            AcceptButton = BotaoOK;
            CancelButton = BotaoCancelar;

        }

        /// <summary>
        /// Terminar a operação.
        /// </summary>
        private void BotaoOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancelar a operação e fechar a janela.
        /// </summary>
        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
