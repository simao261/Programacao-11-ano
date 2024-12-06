using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Experiencias_modulo_9.Program;

namespace Experiencias_modulo_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vamos criar 3 novas instâncias da classe Livro(ou seja, 3 novos livros):
            Livro livro1 = new Livro("Os Maias", 2019, 10.38M, 0.06M);
            Livro livro2 = new Livro("Python - Algoritmia e Programação Web", 2015,24.06M, 0.06M);
            Livro livro3 = new Livro("TypeScript: O JavaScript Moderno para Criação de Aplicações", 2017, 18.82M, 0.06M);
            
            livro1.Titulo = "A Ilustre Casa de Ramires";
            Console.WriteLine(livro1.Titulo);

            /* Livro livro1 = new Livro();
               Livro livro2 = new Livro();
               Livro livro3 = new Livro();
            */


            // inovar o metodo PrecoComIva
            decimal p = livro1.PrecoComIva();

          


        }

        // class Livro 
        public class Livro
        {
            public string Titulo { get; set; }
            public int Ano { get; set; }
            public decimal Preco { get; set; }
            public decimal TaxaIva { get; set; } = 0.06M;



            public Livro(string titulo, int ano, decimal preco, decimal taxaIva)
            {
                Titulo = titulo;
                Ano = ano;
                Preco = preco;
                TaxaIva = taxaIva;
            }


            public bool Matricular(int ano)
            {
                return true; // Apenas para evitar erros de compilador
            }
            public int ModulosAtraso()
            {
                return 0; // Apenas para evitar erros de compilador
            }


            public string GetTitulo() { return Titulo; }
            public void SetTitulo(string titulo) { Titulo = titulo; }
            public int GetAno() { return Ano; }
            public void SetAno(int ano) { Ano = ano; }
            public decimal GetPreco() { return Preco; }
            public void SetPreco(decimal preco) { Preco = preco; }
            public decimal GetTaxaIva() { return TaxaIva; }
            public void SetTaxaIva(decimal taxaIva) { TaxaIva = taxaIva; }

            

            

            // metodo que retorna o preço do ivo acrescido o preço com taxa de iva 
            public decimal PrecoComIva()
            {
                return Preco + (Preco * TaxaIva);
            }

            
            public void Setprecoo(decimal preco)
            {
                if (preco <= 0)
                {
                    // sinalizar um erro e retornar
                }
                Preco = preco;
            }



            private decimal preco;
            public decimal Precoo
            {
                set
                {
                    if (value <= 0)
                        preco = 1;
                    else
                        preco = value;
                }
                get { return preco; }


                


            }

            // definição de uma propriedade cujo valor apenas pode ser modificado dentro da classe
            /*public int Codigo { get; private set; }
            public void UmMetodo()
            {
                Codigo = 99;
            }
            public string ISBN { get; }
            public Livro(string titulo)
            {
                Titulo = titulo;
                ISBN = "abc";
            }
            /* public void UmMetodo()
            {
                ISBN = "abc-1234-001"; // erro nao pode ser atribuido aqui um valor 
            }*/



        }



        // Class aluno 

        public class Aluno
        {
            // indicar que os campos da class estao privados 
            private string Nome;
            private string Morada;
            private string Email;
            private int Telefone1;
            private int Telefone2;
            private DateTime DataNascimento;

            public Aluno(string nome, string morada, string email, int telefone1, int
            telefone2, DateTime dataNascimento)
            {
                Nome = nome;
                Morada = morada;
                Email = email;
                Telefone1 = telefone1;
                Telefone2 = telefone2;
                DataNascimento = dataNascimento;
            }

            // enumeraçaio que pertence a esta class
            public enum GeneroLivro
            {
                Indefinido,
                Romance,
                Ensaio,
                FiccaoCientifica,
                Policial
            }

            public bool Matricular(int ano)
            {
                return true; // Apenas para evitar erros de compilador
            }

            public int ModulosAtraso()
            {
                return 0; // Apenas para evitar erros de compilador
            }
        }

        // enumeraçao que pertence a varias classes 

        public enum TipoCombustivel
        {
            Nulo,
            Gasolina,
            Gasoleo,
            Eletricidade,
            Hidrogeneo
        }
        public class Automovel
        {
            TipoCombustivel Combustivel;
        }

        // void nao retorna nada
        public void Desenhar()
        {

        }

        // nao retorna nada e recbe 2 parametros
        public void Deslocar(int distanciaHorizontal, int distanciaVertical)
        {

        }

        // retorna um numero inteiro e recebe 2 parametros 
        public int soma(int a, int b)
        {

            a = 2;
            b = 3; 
            return a + b;

        }



    }
}
