using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Libro
    {
        /* Un libro è un'entità che ha
            Titolo
            Autore
            Genere
            Prezzo */

        //proprietà
        public string Titolo { get; set; }

        public string Autore { get; set; }
        public Tipologia Genere { get; set; }
        public double Prezzo { get; set; }

        //costruttore
        public Libro()
        {

        }

        //metodi
        public enum Tipologia
        {
            Narrativa,
            Storico,
            Fantasy
        }

    }

}
