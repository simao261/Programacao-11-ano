using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_3
{
    abstract class Forma
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Forma(int x, int y)
        {
            X = x;
            Y = y;

        }

        public abstract void Desenhar();

        public virtual void informacoes()
        {
            Console.WriteLine($"Forma localizada em ({X}, {Y}).");
        }

        public virtual void Mover( int novoX , int novoY )
        {
            Console.WriteLine($"Movendo forma de ({X}, {Y}) para ({novoX}, {novoY}).");
            X = novoX;
            Y = novoY;
        }



    }
}
