using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5
{
    internal class Carro : Veiculo
    {
        private Motor motor;
        public int NumeroPortas { get; set; }

        public Carro(string marca , string modelo , int ano , int numeroportasb) : base ( marca, modelo, ano)
        { 
           NumeroPortas = numeroportasb;
        
        }
       
        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Numero de Portas: {NumeroPortas}");
        }

    }
}
