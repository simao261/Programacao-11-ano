using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ficha_2
{
    public class Bicicleta : Veiculo
    {
        public Bicicleta(int x, int y, string marca, string modelo, ConsoleColor cor)
        : base(x, y, marca, modelo, cor) { }

        public override void Desenhar()
        {
            
            ConsoleColor corAntiga = Console.ForegroundColor;

            
            Console.ForegroundColor = Cor;

            
            Console.SetCursorPosition(left: X, top: Y); 
            Console.Write("__0");

            
            Console.SetCursorPosition(left: X, top: Y + 1);
            Console.Write(" - '\\|<,-");

           
            Console.SetCursorPosition(left: X, top: Y + 2);
            Console.Write("(*) / (*)");

            
            Console.ForegroundColor = corAntiga;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
