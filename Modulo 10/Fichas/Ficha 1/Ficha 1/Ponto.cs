using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_1
{
    public class Ponto : Forma
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Ponto(int x, int y, ConsoleColor cor) : base(cor)
        {
            X = x;
            Y = y;
        }
        public void Desenhar()
        {
            Console.ForegroundColor = Cor;
            Console.SetCursorPosition(X, Y);
            Console.Write("*");
        }
    }
}
