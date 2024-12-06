using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2
{
    public class Camiao : Veiculo
    {
        public string Matricula { get; set; }

        public Camiao(int x, int y, string marca, string modelo,string matricula,  ConsoleColor cor)
            : base(x, y, marca, modelo, cor)
        {
            Matricula = matricula;
        }

        public override void Desenhar()
        {

            Console.ForegroundColor = Cor;
            Console.BackgroundColor = Cor;

            
            Console.SetCursorPosition(left: X, top: Y);
            Console.Write("█████"); 

            
            Console.SetCursorPosition(left: X, top: Y + 1);
            Console.Write("█   █"); 

            
            Console.SetCursorPosition(left: X, top: Y + 2);
            Console.Write("█   █"); 

            
            Console.SetCursorPosition(left: X + 6, top: Y);
            Console.Write("██████████"); 

            Console.SetCursorPosition(left: X + 6, top: Y + 1);
            Console.Write("█        █"); 

            Console.SetCursorPosition(left: X + 6, top: Y + 2);
            Console.Write("█        █"); 

            Console.ResetColor();
            
            Console.SetCursorPosition(left: X + 1, top: Y + 3);
            Console.Write("O");

            Console.SetCursorPosition(left: X + 3, top: Y + 3);
            Console.Write("O");

            Console.SetCursorPosition(left: X + 7, top: Y + 3);
            Console.Write("O");

            Console.SetCursorPosition(left: X + 11, top: Y + 3);
            Console.Write("O");

            
            Console.ResetColor();




        }

    }
}
