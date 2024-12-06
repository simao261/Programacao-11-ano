using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 4, ConsoleColor.Yellow);
            Quadrado q1 = new Quadrado(10, 9, 1, ConsoleColor.Green );
            Quadrado q2 = new Quadrado(16,9,3 , ConsoleColor.Red );
            Quadrado q3 = new Quadrado(25,9,6  , ConsoleColor.Green );
            Retangulo r1 = new Retangulo(10,19,0,0, ConsoleColor.White);
            Retangulo r2 = new Retangulo(16,19,10,3 , ConsoleColor.White );
            Retangulo r3 = new Retangulo(30,19,2,8, ConsoleColor.White );

            Console.WriteLine("         instancia da classe ponto");
            p1.Desenhar();

            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("         Instancia da classe quadrado");
            
            q1.Desenhar();
            q2.Desenhar();
            q3.Desenhar();

            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("         Instancia da classe retangulo");
            r1.Desenhar();
            r2.Desenhar();
            r3.Desenhar();
            Console.WriteLine();
            Console.WriteLine() ;
        }
    }
}
