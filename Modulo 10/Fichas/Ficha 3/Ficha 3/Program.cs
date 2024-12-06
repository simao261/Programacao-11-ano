using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Circulo circulo1 = new Circulo(5, 5, 10);
            Retangulo retangulo1 = new Retangulo(20, 5, 8, 12);

            circulo1.informacoes();
            retangulo1.informacoes();

            circulo1.Mover(10, 10);
            retangulo1.Mover(25, 10);

            circulo1.informacoes();
            retangulo1.informacoes();
        }



    }

    
}
