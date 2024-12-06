using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAvaliacaoModulo9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa("Patrícia Mamona", SexoPessoa.Feminino, 30, 76, 1.78);
            Pessoa p3 = new Pessoa("Diogo Costa", SexoPessoa.Masculino, 23, 90, 1.85);


            p2.CalcularImc();
            p3.CalcularImc();


            Console.WriteLine(Pessoa.ExibirTotalPessoas());
            Console.WriteLine(p1.DadosPessoa());
            Console.WriteLine(p2.DadosPessoa());
            Console.WriteLine(p3.DadosPessoa());
        }

        public enum SexoPessoa
        {
            Nulo,
            Masculino,
            Feminino
        }

        public class Pessoa
        {

            public string Nome { get; set; }
            public SexoPessoa Sexo { get; set; }
            public int Idade { get; set; }
            public double Peso { get; set; }
            public double Altura { get; set; }
            public double Imc { get; private set; } = 0;


            public static int TotalPessoas { get; private set; } = 0;

            public Pessoa()
            {
                TotalPessoas++;
            }


            public Pessoa(string nome, SexoPessoa sexo, int idade, double peso, double altura)
            {
                Nome = nome;
                Sexo = sexo;
                Idade = idade;
                Peso = peso;
                Altura = altura;
                TotalPessoas++;
            }


            public void CalcularImc()
            {
                if (Altura > 0)
                {
                    Imc = Peso / (Altura * Altura);
                }
            }


            public string ClassificacaoPeso()
            {
                if (Imc == 0) return string.Empty;
                if (Imc <= 18.5) return "Baixo peso";
                if (Imc <= 24.9) return "Peso normal";
                if (Imc <= 29.9) return "Pré-obesidade";
                if (Imc <= 34.9) return "Obesidade grau I";
                if (Imc <= 39.9) return "Obesidade grau II";
                return "Obesidade grau III";
            }


            public string DadosPessoa()
            {
                return $"Nome: {Nome} - IMC: {Imc} ({ClassificacaoPeso()})";
            }


            public static string ExibirTotalPessoas()
            {
                return $"Total de pessoas : {TotalPessoas}";
            }
        }
    }
}
