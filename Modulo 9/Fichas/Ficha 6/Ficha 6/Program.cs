using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ficha_6.Program;
using static Ficha_6.Program.Livro;

namespace Ficha_6
{
    internal class Program
    {
        static void Main(string[] args)
        {





            Livro livro1 = new Livro("1984", "SLB", 1949, 5, Livro.GeneroLivro.Ficcao);
            Livro livro2 = new Livro("Benfica", "slb", 2008, 2, Livro.GeneroLivro.Ficcao);

            Membro membro1 = new Membro("Simão Rodrigues", 1, "simaoodrigues10200@gmail.com");
            Membro menbro2 = new Membro("Rodrigo Pinheiro", 3, "simaoodrigues10200@gmail.com");

            Emprestimo emprestimo1 = new Emprestimo(membro1);
            Emprestimo emprestimo2 = new Emprestimo(menbro2);

           


           

            emprestimo1.EmprestarLivro(livro1);
            emprestimo2.EmprestarLivro(livro2);

            emprestimo1.ExibirEmprestimo();
            emprestimo2.ExibirEmprestimo();
            Emprestimo.ExibirTotalEmprestimos();




        }

        public class Livro
        {
            public string Titulo { get; private set; }
            public string Autor { get; private set; }
            public int AnoPublicacao { get; private set; }
            public int QuantidadeDisponivel { get; private set; }
            public GeneroLivro Genero { get; private set; }

            public Livro(string titulo, string autor, int anoPublicacao, int quantidadeDisponivel, GeneroLivro genero)
            {
                Titulo = titulo;
                Autor = autor;
                AnoPublicacao = anoPublicacao;
                QuantidadeDisponivel = quantidadeDisponivel;
                Genero = genero;
            }

            public enum GeneroLivro
            {
                Ficcao,
                NaoFiccao,
                Suspense,
                Biografia,
                Fantasia,
                Romance,
                Ciencia
            }

            public void ExibirInfo()
            {
                Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, AnoPublicacao: {AnoPublicacao}, QuantidadeDisponiveL: {QuantidadeDisponivel}");
            }
        }

        public class Membro
        {
            public string Nome { get; private set; }
            public int ID { get; private set; }
            public string Email { get; private set; }

            public Membro(string nome, int id, string email)
            {
                Nome = nome;
                ID = id;
                Email = email;
            }

            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {Nome}, ID: {ID}, Email: {Email}");
            }


        }

        public class Emprestimo
        {
            public Membro Membro { get; private set; }
            public List<Livro> LivrosEmprestados { get; private set; }
            public DateTime DataEmprestimo { get; private set; }
            public static int TotalEmprestimos { get; private set; }

            public event EventHandler<string> LivroEmprestado;

            public Emprestimo(Membro membro)
            {
                Membro = membro;
                LivrosEmprestados = new List<Livro>();
                DataEmprestimo = DateTime.Now;
                TotalEmprestimos++;
            }

            public void EmprestarLivro(Livro livro)
            {
                if (livro.QuantidadeDisponivel > 0)
                {
                    LivrosEmprestados.Add(livro);
                    Console.WriteLine($"O Livro \"{livro.Titulo}\" foi emprestado para {Membro.Nome}");
                }
                else
                {
                    Console.WriteLine($"O livro \"{livro.Titulo}\" não está disponível");
                }
                
            }

            public void EmprestarLivro(string titulo, string autor, int anoPublicacao, int quantidadeDisponivel)
            {
                Livro livro = new Livro(titulo, autor, anoPublicacao, quantidadeDisponivel, GeneroLivro.Ficcao);
                EmprestarLivro(livro);
                Console.WriteLine($"O Livro \"{livro.Titulo}\" emprestado com sucesso");

               
            }

            public void ExibirEmprestimo()
            {
                Console.WriteLine($"Empréstimo feito por: {Membro.Nome}");
                Console.WriteLine($"Data do Empréstimo: {DataEmprestimo}");
                Console.WriteLine($"Livros Emprestados: ");
                foreach (var livro in LivrosEmprestados)
                {
                    Console.WriteLine($"- {livro.Titulo} por {livro.Autor} ({livro.AnoPublicacao})");
                }
            }

            public static void ExibirTotalEmprestimos()
            {
                Console.WriteLine($"Total de Empréstimos: {TotalEmprestimos}");
            }

            



        }

        public class Funcionario
        {
            public string Nome { get; private set; }
            public int Id { get; private set; }
            public string Cargo { get; private set; }


            public Funcionario(string nome, int id, string cargo)
            {
                Nome = nome;
                Id = id;
                Cargo = cargo;
            }


           


            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {Nome}, ID: {Id}, Cargo: {Cargo}");
            }


          

        }



    }
}
