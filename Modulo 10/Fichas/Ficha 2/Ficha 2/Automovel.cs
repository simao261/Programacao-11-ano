using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2
{
    public class Automovel : Veiculo
    {
        public string Matricula { get; set; }

        public Automovel(int x, int y, string marca, string modelo, string matricula, ConsoleColor cor)
            : base(x, y, marca, modelo, cor)
        {
            Matricula = matricula;
        }

        public override void Desenhar()
        {

            Console.ForegroundColor = Cor; 

            
            Console.SetCursorPosition(left: X + 2, top: Y);
            Console.Write("████"); 

           
            Console.SetCursorPosition(left: X, top: Y + 1);
            Console.Write("████████"); 

            
            Console.ResetColor();

            
            Console.SetCursorPosition(left: X + 1, top: Y + 2);
            Console.Write("O    O"); 

        }
    }
    
}
