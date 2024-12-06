using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    internal class Utilizador : Pessoa
    {
        public TipoUtilizador Tipo { get; set; } = TipoUtilizador.Nulo;

        public Utilizador() { }

        public Utilizador(
            bool ativo,
            int id,
            TipoUtilizador tipo,
            string username,
            string password,
            string nome,
            string email,
            string telefone)
            : base(ativo, id, username, password, nome, email, telefone)
        {
            Tipo = tipo;
        }





    }
}
