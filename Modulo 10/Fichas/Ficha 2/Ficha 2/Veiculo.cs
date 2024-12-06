using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2
{
    public abstract class Veiculo
    {

        public enum DirecaoMovimento
        {
            Indefenido,
            Esquerda,
            Direita
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public ConsoleColor Cor { get; set; }

        public DirecaoMovimento Direcao { get; set; }

        public Veiculo(int x, int y, string marca, string modelo, ConsoleColor cor)
        {
            X = x;
            Y = y;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            
        }

        public abstract void Desenhar();


    }
}
