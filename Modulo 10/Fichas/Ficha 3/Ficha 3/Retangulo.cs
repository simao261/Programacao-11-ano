using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_3
{
    class Retangulo : Forma
    {
        public int Largura { get; set; }
        public int Altura { get; set; }

        public Retangulo(int x, int y, int largura, int altura) : base(x, y)
        {
            Altura = altura;
            Largura = largura;

        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando um retângulo em ({X}, {Y}) com largura {Largura} e altura {Altura}.");
        }


        public virtual void Mover(int novoX, int novoY)
        {
            Console.WriteLine($"Retângulo movendo-se de ({X}, {Y}) para ({novoX}, {novoY}) com suavidade.");
            base.Mover(novoX, novoY);

        }
    }
       

    
}
