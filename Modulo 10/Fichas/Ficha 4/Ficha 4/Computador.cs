using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_4
{
    class Computador
    {
        private Processador processador {  get; set; }
        private MemoriaRAM memoriaRAM { get; set; }
        private DiscoRigido discoRigido { get; set; }

        public Computador ( Processador processador, MemoriaRAM memoriaRAM, DiscoRigido discoRigido)
        {
            this.processador = processador;
            this.memoriaRAM = memoriaRAM;
            this.discoRigido = discoRigido;
        }

        public Computador()
        {
            Console.WriteLine("Computador destruido");
        }
        public void ExibirEspecificacoes()
        {
            Console.WriteLine("Especificações do Computador:");
            Console.WriteLine($"Processador: {processador.Modelo}, {processador.Frequencia} GHz");
            Console.WriteLine($"Memória RAM: {memoriaRAM.Capacidade} GB");
            Console.WriteLine($"Disco Rígido: {discoRigido.Capacidade} GB, Tipo: {discoRigido.Tipo}");

            


        }
    }
}
