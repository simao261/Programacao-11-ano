using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_4
{
    class MemoriaRAM
    {

        public int Capacidade {  get; set; }

        public MemoriaRAM ( int capacidade  )
        {
            Capacidade = capacidade;

        }
        public MemoriaRAM()
        {
            Console.WriteLine("MemoriaRAM destruida");

        }



    }
}
