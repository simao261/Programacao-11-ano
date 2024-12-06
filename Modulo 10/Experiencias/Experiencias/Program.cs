using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiencias
{
    internal class Program
    {
        static void Mover( Veiculo veiculo)
        {
            veiculo.Mover();
        }
        static void Main(string[] args)
        {
            Veiculo mybicicleta = new Bicicleta("bmx");
            Veiculo mycarro = new Carron("renault");

            mybicicleta.Mover();
            mycarro.Mover();

            Mover(mycarro);
            Mover(mybicicleta);
            
        }

    }

   
}
