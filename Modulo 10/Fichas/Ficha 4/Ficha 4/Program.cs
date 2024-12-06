using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Processador processadorEscolhido = null;
            MemoriaRAM memoriaRAMEscolhida = null;
            DiscoRigido discoRigidoEscolhido = null;

            
            string mensagemProcessador = "";
            string mensagemRAM = "";
            string mensagemDisco = "";

            Console.WriteLine("Escolha o processador:");
            Console.WriteLine("1. Intel Core i5 (2.5 GHz)");
            Console.WriteLine("2. Intel Core i7 (3.8 GHz)");
            Console.WriteLine("3. AMD Ryzen 5 (3.6 GHz)");
            Console.Write("Opção: ");
            int processadorSel = int.Parse(Console.ReadLine());

            switch (processadorSel)
            {
                case 1:
                    processadorEscolhido = new Processador("Intel Core i5", 2.5);
                    mensagemProcessador = "Processador Intel Core i5 criado.";
                    break;
                case 2:
                    processadorEscolhido = new Processador("Intel Core i7", 3.8);
                    mensagemProcessador = "Processador Intel Core i7 criado.";
                    break;
                case 3:
                    processadorEscolhido = new Processador("AMD Ryzen 5", 3.6);
                    mensagemProcessador = "Processador AMD Ryzen 5 criado.";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            Console.WriteLine("Escolha a quantidade de memória RAM (em GB):");
            Console.WriteLine("1. 8 GB");
            Console.WriteLine("2. 16 GB");
            Console.WriteLine("3. 32 GB");
            Console.Write("Opção: ");
            int memoriaSel = int.Parse(Console.ReadLine());

            switch (memoriaSel)
            {
                case 1:
                    memoriaRAMEscolhida = new MemoriaRAM(8);
                    mensagemRAM = "Memória RAM de 8 GB criada.";
                    break;
                case 2:
                    memoriaRAMEscolhida = new MemoriaRAM(16);
                    mensagemRAM = "Memória RAM de 16 GB criada.";
                    break;
                case 3:
                    memoriaRAMEscolhida = new MemoriaRAM(32);
                    mensagemRAM = "Memória RAM de 32 GB criada.";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            Console.WriteLine("Escolha o disco rígido:");
            Console.WriteLine("1. 512 GB SSD");
            Console.WriteLine("2. 1 TB HDD");
            Console.WriteLine("3. 1 TB SSD");
            Console.Write("Opção: ");
            int discoSel = int.Parse(Console.ReadLine());

            switch (discoSel)
            {
                case 1:
                    discoRigidoEscolhido = new DiscoRigido(512, "SSD");
                    mensagemDisco = "Disco Rígido de 512 GB (SSD) criado.";
                    break;
                case 2:
                    discoRigidoEscolhido = new DiscoRigido(1024, "HDD");
                    mensagemDisco = "Disco Rígido de 1024 GB (HDD) criado.";
                    break;
                case 3:
                    discoRigidoEscolhido = new DiscoRigido(1024, "SSD");
                    mensagemDisco = "Disco Rígido de 1024 GB (SSD) criado.";
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

           
            Computador computador = new Computador(processadorEscolhido, memoriaRAMEscolhida, discoRigidoEscolhido);

           
            Console.WriteLine();
            Console.WriteLine(mensagemProcessador);
            Console.WriteLine(mensagemRAM);
            Console.WriteLine(mensagemDisco);
            Console.WriteLine("Computador criado.");
            Console.WriteLine();
            Console.WriteLine();




            computador.ExibirEspecificacoes();
            computador = null;
            GC.Collect();
        }



    }

}
