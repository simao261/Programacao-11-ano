using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("Rex", Animal.TipoAnimal.cao, 12.28);
            Animal animal2 = new Animal("Atum", Animal.TipoAnimal.gato, 6.0);
            Animal animal3 = new Animal("Nemo", Animal.TipoAnimal.peixe, 0.90);

           
            Console.WriteLine($"Animal1: {animal1}");
            Console.WriteLine($"Animal2: {animal2}");
            Console.WriteLine($"Animal3: {animal3}");

        }

        public class Animal
        {
            public enum TipoAnimal
            {
                cao,
                gato,
                passaro,
                peixe

            }

            public string Nome { get; set; }
            public TipoAnimal Tipo {  get; set; }
            public double Peso { get; set; }

            public Animal ( string nome , TipoAnimal tipo , double peso )
            {
                Nome = nome;
                Tipo = tipo;
                Peso = peso;
            }

            public override string ToString()
            {
                return $"Animal(Nome: {Nome}, Tipo: {Tipo}, Peso: {Peso})";
            }

        }



    }
}
