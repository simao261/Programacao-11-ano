using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_5
{
    internal class Camiao: Veiculo
    {
        public Motor Motor { get; set; }
      

        public Camiao(string marca, string modelo, int ano, string tipo, int potencia)
            : base(marca, modelo, ano)
        {
            Motor = new Motor(tipo, potencia);
        }

        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Motor.MostrarDetalhes();
        }
        

    }
}
