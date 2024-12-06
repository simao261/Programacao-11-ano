using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automovel automovel1 = new Automovel( 10, 7, "Toyota", "Corolia", "AA-00-11", ConsoleColor.Yellow);
            Camiao camiao1 = new Camiao ( 10, 14 , "Toyota", "Hiace", "BB-11-22", ConsoleColor.Red);
            Bicicleta bicicleta1 = new Bicicleta(10, 20, "Specialized", "S-Works Epic", ConsoleColor.White);

            automovel1.Desenhar();
            camiao1.Desenhar();
            bicicleta1 .Desenhar();






        }
    }
}
