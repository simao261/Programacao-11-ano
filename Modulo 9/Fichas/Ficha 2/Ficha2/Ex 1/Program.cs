using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1 = new Pessoa("Simão Rodrigues", "Rua da cruz, 24", 123456789, "1234ABC", new DateTime(1990, 5, 10));
            Pessoa pessoa2 = new Pessoa("Miguel costa", "coimbra, 456", 987654321, "5678XYZ", new DateTime(1985, 12, 25));


            /* pessoa1.SetNome("Simao Rodrigues");
             Console.WriteLine(pessoa1.nome);
             pessoa1.SetMorada("coimbra");*/


           Console.WriteLine($"Nome: {pessoa1.Nome}, Idade. {pessoa1.Idade()}, Morada: {pessoa1.Morada}, Cartaocidadao: {pessoa1.CartaoCidadao}, NIF: {pessoa1.Nif} ");
           Console.WriteLine($"Nome: {pessoa2.Nome}, Idade. {pessoa2.Idade()}, Morada: {pessoa2.Morada}, Cartaocidadao: {pessoa2.CartaoCidadao}, NIF: {pessoa2.Nif} ");
           

        }

       




        public class Pessoa
        {
            public string Nome {  get; set; }
            public string Morada { get; set; }
            public int Nif {  get; set; }
            public string CartaoCidadao { get; set; }
            public DateTime DataNascimento {  get; set; }




            public Pessoa(string nome, string morada, int nif, string cartaocidadao, DateTime dataNascimento)
            {
                this.Nome = nome;
                this.Morada = morada;
                this.Nif = nif;
                this.CartaoCidadao = cartaocidadao;
                this.DataNascimento = dataNascimento;
            }
            
           /* public string GetNome()
            {
                return nome;
            }

            public void SetNome(string novoNome)
            {
                nome = novoNome;
            }

            
            public string GetMorada()
            {
                return morada;
            }

            public void SetMorada(string novaMorada)
            {
                morada = novaMorada;
            }

            
            public int GetNif()
            {
                return nif;
            }

            public void SetNif(int novoNif)
            {
                nif = novoNif;
            }

            
            public string GetCartaoCidadao()
            {
                return CartaoCidadao;
            }

            public void SetCartaoCidadao(string novoCartaoCidadao)
            {
                CartaoCidadao = novoCartaoCidadao;
            }

            
            public DateTime GetDataNascimento()
            {
                return DataNascimento;
            }

            public void SetDataNascimento(DateTime novaDataNascimento)
            {
                DataNascimento = novaDataNascimento;
            }*/
            public int Idade()
            {
                int anos = DateTime.Now.Year - DataNascimento.Year;
                int meses = DateTime.Now.Month - DataNascimento.Month;
                int dias = DateTime.Now.Day - DataNascimento.Day;

                if (meses == 0 && dias < 0)
                {
                    --anos;
                }
                else if (meses < 0)
                {
                    --anos;
                }

                return anos;
            }


        }
    }   
}
