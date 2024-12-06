using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_4
{
    internal class Program
    {
        public class Produto 
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public int Estoque { get; set; }



            public Produto(string nome, decimal preco, int estoque)
            {
                Nome = nome;
                Preco = preco;
                Estoque = estoque;

            }   

            public void exibirInfo()
            {
                Console.WriteLine($"Poduto: {Nome}, Preço: {Preco}, Estoque. {Estoque}");
            }
        }

        public class Cliente
        { 
            public string Nome { get; set; }
            public string Email { get; set; }


            public Cliente ( string nome, string email)
            {
                Nome = nome;
                Email = email;
                

            }

            public void exibirInfo()
            {
                Console.WriteLine($"Cliente: {Nome}, Email: {Email}");
            }

        }

        public class Pedido
        {
            public Cliente Cli { get; private set; }
            private List<Produto> produtos;
            private List<int> quantidades;
            public static int TotalPedidos { get; private set; }

            public Pedido ( Cliente cli )
            {
                Cli = cli;
                produtos = new List<Produto> ();
                quantidades = new List<int> ();
                TotalPedidos++;
            }

            public void Adicionarproduto( Produto produto, int quantidade )
            {
                produtos.Add (produto);
                quantidades.Add (quantidade);


            }

            public void Adicionarproduto( string nome , decimal preco , int quantidade)
            {
                Produto produto = new Produto ( nome, preco , quantidade);
                produtos.Add(produto);
                quantidades.Add(quantidade);
            }

            public void exibirPedido()
            {

                Console.WriteLine($"Pedido do Cliente: {Cli.Nome}");
                
                Console.WriteLine("Produtos no Pedido");

                for (int i = 0; i < produtos.Count; i++)
                {
                    Produto produto = produtos[i];
                    int quantidade = quantidades[i];
                    Console.WriteLine($"Produto - {produto.Nome}, Quantidade - {quantidade} x {produto.Preco:C2} Total: {quantidade * produto.Preco:C2})");
                }

            }

            public static void ExibirTotalPedidos()
            {
                Console.WriteLine($"Total de pedidos feitos: {TotalPedidos}");
            }



        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Produto produto1 = new Produto("telemovel", 1500, 10);
            Produto produto2 = new Produto("Computador", 2500, 2);
            Produto produto3 = new Produto("iphone", 1500, 3);

            Cliente cliente = new Cliente("Simão rodrigues", "simaoodrigues10200@gmail.com");

            Pedido pedido1 = new Pedido(cliente);
            Pedido pedido2 = new Pedido(cliente);

            pedido1.Adicionarproduto(produto1, 2);
            pedido1.Adicionarproduto(produto2, 2);
            pedido1.Adicionarproduto("Fones", 150, 2);
            pedido2.Adicionarproduto(produto3, 2);

            



            pedido1.exibirPedido();
            pedido2.exibirPedido();
            Pedido.ExibirTotalPedidos();

        }
    }
}
