using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(4, ConsoleColor.Blue);
            Console.WriteLine(circulo.ToString());
        }
        public class Circulo
        {
            public double Raio { get; set; }
            public ConsoleColor Cor { get; set; }

            public Circulo()
            {
                Raio = 0.0;
                Cor = ConsoleColor.Red;

            }
            public Circulo ( double raio)
            {
                Raio = raio;
            }
            public Circulo ( double raio, ConsoleColor cor)
            {
                Raio = raio;
                Cor = cor;
            }
            public void Desenhar()
            {
                Console.WriteLine("O circulo está a ser desenhado! ");

            }

            public override string ToString()
            {
                return $"Dados do Círculo: Raio = {Raio}, Cor = {Cor}";
            }



        }
    }
}
