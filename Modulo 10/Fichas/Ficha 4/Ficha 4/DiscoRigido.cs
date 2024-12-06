using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_4
{
    class DiscoRigido
    {
        public int Capacidade {  get; set; }
        public string Tipo { get; set; }


        public DiscoRigido(int capacidade , string tipo)
        { 
            Capacidade = capacidade;
            Tipo = tipo;
        
        }
        public DiscoRigido() 
        {

            Console.WriteLine("DiscoRigido destruido");
        
        }


    }
}
