using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_4
{
    class Processador
    {
        public string Modelo {  get; set; }

        public  double Frequencia { get; set; }

        public Processador(string modelo, double frequencia) 
        {
            Modelo = modelo;
            Frequencia = frequencia;
        
        }
        public Processador() 
        {
            Console.WriteLine("Processador destruido");
        
        }


    }
}
