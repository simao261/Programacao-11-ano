using System;
using System.Collections.Generic;

namespace Locadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Criando alguns filmes
            Filme filme1 = new Filme("Inception", "Christopher Nolan", 2010, 3, Filme.GeneroFilme.FiccaoCientifica);
            Filme filme2 = new Filme("The Matrix", "The Wachowskis", 1999, 2, Filme.GeneroFilme.FiccaoCientifica);

            // Criando alguns clientes
            Cliente cliente1 = new Cliente("João Silva", 1, "joao.silva@email.com");
            Cliente cliente2 = new Cliente("Maria Oliveira", 2, "maria.oliveira@email.com");

            // Criando locações
            Locacao locacao1 = new Locacao(cliente1);
            Locacao locacao2 = new Locacao(cliente2);

            // Alugando filmes usando diferentes métodos
            locacao1.AlugarFilme(filme1); // Usando o método com objeto Filme
            locacao2.AlugarFilme("The Matrix", "The Wachowskis", 1999); // Usando o método com dados diretos

            // Exibindo as locações
            locacao1.ExibirLocacao();
            locacao2.ExibirLocacao();

            // Exibindo o total de locações feitas
            Locacao.ExibirTotalLocacoes();
        }
    }

    public class Filme
    {
        public string Titulo { get; private set; }
        public string Diretor { get; private set; }
        public int AnoLancamento { get; private set; }
        public int QuantidadeDisponivel { get;  set; }
        public GeneroFilme Genero { get; private set; }

        public Filme(string titulo, string diretor, int anoLancamento, int quantidadeDisponivel, GeneroFilme genero)
        {
            Titulo = titulo;
            Diretor = diretor;
            AnoLancamento = anoLancamento;
            QuantidadeDisponivel = quantidadeDisponivel;
            Genero = genero;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Título: {Titulo}, Diretor: {Diretor}, Ano de Lançamento: {AnoLancamento}, Disponível: {QuantidadeDisponivel}");
        }

        public enum GeneroFilme
        {
            Acao,
            Comedia,
            Drama,
            Suspense,
            Documentario,
            Fantasia,
            Romance,
            FiccaoCientifica
        }
    }

    public class Cliente
    {
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public string Email { get; private set; }

        public Cliente(string nome, int id, string email)
        {
            Nome = nome;
            Id = id;
            Email = email;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, ID: {Id}, Email: {Email}");
        }
    }

    public class Locacao
    {
        public Cliente Cliente { get; private set; }
        public List<Filme> FilmesAlugados { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public static int TotalLocacoes { get; private set; } = 0;

        public Locacao(Cliente cliente)
        {
            Cliente = cliente;
            FilmesAlugados = new List<Filme>();
            DataLocacao = DateTime.Now;
            TotalLocacoes++;
        }

        // Método overloading para alugar um filme passando um objeto Filme
        public void AlugarFilme(Filme filme)
        {
            if (filme.QuantidadeDisponivel > 0)
            {
                FilmesAlugados.Add(filme);
                filme.QuantidadeDisponivel--;
                Console.WriteLine($"Filme \"{filme.Titulo}\" alugado com sucesso para {Cliente.Nome}");
            }
            else
            {
                Console.WriteLine($"Filme \"{filme.Titulo}\" não está disponível para locação.");
            }
        }

        // Método overloading para alugar um filme passando dados diretos
        public void AlugarFilme(string titulo, string diretor, int anoLancamento)
        {
            Filme filme = new Filme(titulo, diretor, anoLancamento, 1, Filme.GeneroFilme.FiccaoCientifica);
            AlugarFilme(filme); // Chama o método AlugarFilme que aceita um objeto Filme
        }

        public void ExibirLocacao()
        {
            Console.WriteLine($"Locação realizada por: {Cliente.Nome}");
            Console.WriteLine($"Data da Locação: {DataLocacao}");
            Console.WriteLine("Filmes Alugados:");
            foreach (var filme in FilmesAlugados)
            {
                Console.WriteLine($"- {filme.Titulo} ({filme.AnoLancamento}) - Diretor: {filme.Diretor}");
            }
        }

        public static void ExibirTotalLocacoes()
        {
            Console.WriteLine($"Total de Locações: {TotalLocacoes}");
        }
    }
}
