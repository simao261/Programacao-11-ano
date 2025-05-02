using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoBiblioteca
{
    internal static class Program
    {
        public static Utilizadores UtilizadoresPrograma {  get; set; } = new Utilizadores();


        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new GUI.FormPrincipal());

            // Inicializar os utilizadores, com dados artificiais para efeitos de teste
            UtilizadoresPrograma.InicializarDadosFake();

            // Efetuar autenticação
            Application.Run(new GUI.FormAutenticacao());

            // Executar a form principal
            Application.Run(new GUI.FormPrincipal());

            // Executar a form Acerca
            //Application.Run(new GUI.FormAcercaAplicacao());

        }
    }
}
