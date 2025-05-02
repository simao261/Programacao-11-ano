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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// Gestão de utilizadores.
        /// </summary>
        private void BotaoUtilizadores_Click(object sender, EventArgs e)
        {
            FormUtilizadores frmUtilizadores = new FormUtilizadores();
            frmUtilizadores.ShowDialog();
            frmUtilizadores.Dispose();
        }

    }
}
