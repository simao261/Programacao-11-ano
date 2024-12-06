using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Garagem garagem = new Garagem("Garagem Central");

           // Motor motor = new Motor("Diesel", 400);

            Carro carro = new Carro("Toyota", "Corolla", 2022, 4);
          
            Camiao camiao = new Camiao("Volvo", "FH", 2020, "Diesel", 400);


            garagem.AdicionarVeiculo(carro);
            garagem.AdicionarVeiculo(camiao);
            Console.WriteLine();

            Console.Write("Lista inicial de veículos:");
            garagem.ListarVeiculos();


            Console.WriteLine("\nRemovendo um veículo:");
            garagem.RetirarVeiculo(carro);
            Console.WriteLine();


            Console.Write("\nLista de veículos após remoção:");
            garagem.ListarVeiculos();


            Console.WriteLine("\nTentando remover um veículo inexistente:");
            garagem.RetirarVeiculo(carro);
        }
    }

    
}


