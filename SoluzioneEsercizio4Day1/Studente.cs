using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluzioneEsercizio4Day1
{
    class Studente
    {
        //propietà
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public List<int> Esami { get; set; }

        public double Media { get; set; }

        //costruttore

        public Studente()
        {

        }

        //metodi
        public string OttieniDati()
        {
            string dati = $"Nome: {Nome} \n Cognome: {Cognome}";
            return dati;
        }
    }
}
