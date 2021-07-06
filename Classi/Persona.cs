using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Persona
    {
        // proprietà
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public int Età { get; set; }

        public string CodiceFiscale { get; set; } //get e set sono due metodi che mi permettono di settare (set) o di estrarre (get)
                                                  //il valore della proprietà

        // costruttori
        /* nel costruttore posso mettere tutti i parametri, alcuni o nessuno (costruttore vuoto) ma se non lo metto non posso
         * istanziare una variabile persona */

        //public Persona()
        //{

        //}

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        //metodi --> contiene le cose che la persona può fare
        public string OttieniDati()
        {
            string dati = $"Ciao mi chiamo {Nome} {Cognome} e ho {Età} anni";
            return dati;
        }

    }
}
