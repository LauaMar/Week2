using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    class Conto
    {
        //proprietà
        public string Intestatario { get; set; }
        public Tipologia TipoDiConto { get; set; }
        public int NumeroConto { get; set; }

        public double Saldo { get; set; }

        public enum Tipologia
        {
            Corrente,
            Risparmio,
        }

        //costruttore

        public Conto()
        {

        }


        //metodi
    }
}
