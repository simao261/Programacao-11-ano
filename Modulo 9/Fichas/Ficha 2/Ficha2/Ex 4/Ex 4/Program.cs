using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Funcionario cat = new Funcionario("Catarina Almeida", "Rua Vicente Vaz das Vacas, nº 67, 1º Esquerdo, 8500-611, Portimão",
                new DateTime(1995, 12, 31), 4, 0);
            
            Funcionario miguel = new Funcionario("Miguel Afonso", "Rua Dom Manuel I, nº 300, 3030 - 320, Coimbra",
                new DateTime(1960, 8, 1), 32, 4);
            

            Funcionario monica = new Funcionario("Mónica Tavares", "Rua Miguel Torga, nº 17, 9º C, 3030 - 320, Coimbra",
                new DateTime(1986, 2, 17), 12, 2);

           
            cat.CalcularSalario();
            miguel.CalcularSalario();
            monica.CalcularSalario();

            Console.WriteLine($"{cat.Nome}\nSalário: {cat.Salario:C}");
            Console.WriteLine();
            Console.WriteLine($"{miguel.Nome}\nSalário: {miguel.Salario:C}");
            Console.WriteLine();
            Console.WriteLine($"{monica.Nome}\nSalário: {monica.Salario:C}");
            Console.WriteLine();

        }



        public class Funcionario
        {
            public string Nome { get; set; }
            public string Morada { get; set; }
            public DateTime DataNascimento { get; set; }
            public decimal Salario { get; private set; } = 1000; 
            public int AnosServico { get; set; }
            public int NumeroFilhos { get; set; }


            public Funcionario(string nome, string morada, DateTime dataNascimento, int anosServico, int numeroFilhos)
            {
                Nome = nome;
                Morada = morada;
                DataNascimento = dataNascimento;
                AnosServico = anosServico;
                NumeroFilhos = numeroFilhos;
            }


            private int Idade()
            {
                int idade = DateTime.Now.Year - DataNascimento.Year;
                if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
                {
                    idade--;
                }
                return idade;
            }


            public void CalcularSalario()
            {
                int idade = Idade();
                Salario = 1000;


                if (idade > 45)
                {
                    Salario += 50;
                }

                Salario += AnosServico * 10;


                if (NumeroFilhos > 3)
                {
                    Salario += NumeroFilhos * 50;
                }
                else
                {
                    Salario += NumeroFilhos * 25;
                }
            }
        }


    }
}
