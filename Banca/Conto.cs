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
        //provare ad aggiungere un ID ai conti in modo tale che se ci sono omonimi (o un utente vuole aprire più conti)
        //possiamo identificiarli
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

        public Conto(string intestatario, Tipologia tipoConto)
        {
            Intestatario = intestatario;
            TipoDiConto = tipoConto;
            Saldo = 100;
        }

        public void AggiornaSaldo(double importo)
        {
            Saldo = Saldo + importo;
        }

        //metodi
    }
}
