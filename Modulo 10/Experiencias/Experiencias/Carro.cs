using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiencias
{
    public abstract class Carron : Veiculo // Derived class (child) 
    {
        public Carron(string marca) : base(marca) 
        {
            Console.WriteLine("Construtor Carro");

        }

        public abstract void fun();

        public override void Mover()
        {
            Console.WriteLine($"O carro da marca {Marca} está em Movimento");

        }
    }
}
