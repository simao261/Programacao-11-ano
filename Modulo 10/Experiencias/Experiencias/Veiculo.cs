using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiencias
{
    public abstract class Veiculo // Base class (parent) 
    {
        public string Marca {  get; set; } 
        
        public Veiculo(string marca)
        {
            Marca = marca;
            Console.WriteLine("Construtor veiculo");
        }

        public abstract void Fun();
        public virtual void Mover()
        {
            Console.WriteLine($"O veiculo da {Marca} está em Movimento");

        }


    }
    
}
