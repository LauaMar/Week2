using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segreteria
{
    /* Un appello ha:
         *
         * un nome(materia)
         * una data dell'esame
         * la tipologia(scritto o orale) */
    class Appello
    {
        //proprietà
        public string Materia { get; set; }
        public DateTime Data { get; set; }

        public Tipologia TipoEsame { get; set; }

        public enum Tipologia
        {
           Scritto,
           Orale
        }

        //costruttore
        public Appello()
        {

        }
    }
}
