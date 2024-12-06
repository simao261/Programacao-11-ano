using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiencias
{
    public abstract class Bicicleta : Veiculo // Derived class (child)  
    {
        public Bicicleta(string marca) : base (marca) 
        {
            Console.WriteLine("Construtor Bicicleta");
        }
        public abstract void fun();
        public override void Mover() 
        {
            Console.WriteLine($"A bicicleta da marca {Marca} está em Movimento");
        }

    }
}
