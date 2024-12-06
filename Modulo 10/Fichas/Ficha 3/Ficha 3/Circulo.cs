using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_3
{
    class Circulo : Forma
    {
        public int Raio {  get; set; }

        public Circulo(int x, int y, int raio) : base (  x, y ) 
        {
            Raio = raio;
        
        }

        public override void Desenhar() 
        {
            Console.WriteLine($"Desenhando um círculo em ({X}, {Y}) com raio {Raio}.");



        }

        public virtual void informacoes()
        {
            Console.WriteLine($"Círculo em ({X}, {Y}) com raio {Raio}. Informações detalhadas.");
        }

    }
}
