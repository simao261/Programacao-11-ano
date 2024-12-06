using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5
{
    internal class Garagem
    {

        public string Nome { get; set; }
        private List<Veiculo> Veiculos { get; set; }

        public Garagem(string nome)
        {
            Nome = nome;
            Veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
            Console.WriteLine($"Veículo {veiculo.Modelo} adicionado à garagem.");
        }

        public void ListarVeiculos()
        {
            Console.WriteLine($"\nGaragem: {Nome}");
            foreach (var veiculo in Veiculos)
            {
                Console.Write($"Veículo: {veiculo.Marca} {veiculo.Modelo} ({veiculo.Ano})");
                if (veiculo is Carro carro)
                {
                    Console.WriteLine($"\nNúmero de Portas: {carro.NumeroPortas}");
                }
                else if (veiculo is Camiao camiao)
                {
                    Console.WriteLine();
                    camiao.Motor.MostrarDetalhes();
                }
                Console.WriteLine();
            }
        }

        public void RetirarVeiculo(Veiculo veiculo)
        {
            if (Veiculos.Remove(veiculo))
            {
                Console.WriteLine($"Veículo {veiculo.Modelo} removido da garagem.");
            }
            else
            {
                Console.WriteLine($"Veículo {veiculo.Modelo} não encontrado na garagem.");
            }
        }
    }
}



    

