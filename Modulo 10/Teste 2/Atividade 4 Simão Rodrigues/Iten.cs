using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    internal class Iten
    {
        public TipoItem Tipo { get; set; } = TipoItem.Nulo;
        public int ID { get; set; } = -1;
        public string Titulo { get; set; } = "";
        public string Autor { get; set; } = "";
        public int Ano { get; set; } = 0;
        public int Quantidade { get; set; } = 0;

        public void Item() { }

        public void Item(TipoItem tipo, string titulo, string autor, int ano, int quantidade)
        {
            Tipo = tipo;
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Quantidade = quantidade;
        }

    }
}
