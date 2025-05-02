using GestaoBiblioteca.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI.FormAutenticacao());
            // Executar a form principal
            Application.Run(new FormPrincipal());
            Application.Run(new GUI.FormAcercaAplicacao());
            
        }
    }
}
