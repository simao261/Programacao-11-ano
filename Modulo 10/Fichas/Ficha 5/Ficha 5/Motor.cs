using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5
{
    internal class Motor
    {

        

        public string Tipo { get; set; }
         public int Potencia { get; set; }

         public Motor(string tipo, int potencia)
         {
                Tipo = tipo;
                Potencia = potencia;
         }

         public void MostrarDetalhes()
         {
                Console.WriteLine($"Motor: {Tipo}, {Potencia} CV");
         }
        

    }
}
