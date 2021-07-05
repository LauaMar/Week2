using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.Esercizio3Day1
{
   public static class CalcolaInteresse
    {
        // Scrivere una funzione che dato un importo di denaro iniziale,
        // un interesse annuo e un numero di anni permette di calcolare
        // l’importo di denaro accresciuto degli interessi dopo il numero di anni passati

        // Esempio
        // Voglio vincolare 10000 euro per 3 anni con un interesse del 3%

        // Dopo 1 anno : 10000 + (10000 * 3 / 100) = 10000 + 300 = 10300
        // Dopo 2 anni : 10300 + (10300 * 3 / 100) = 10300 + 309 = 10609
        // Dopo 3 anni : 10609 + (10609 * 3 / 100) = 10609 + 318,27 = 10927,27
        public static void Start()
        {
            int numAnni = 3;
            int percInteresse = 3 ;
            double importoVincolato = 10000;
            double[] importoTotale = new double[numAnni];

            //importoTotale = InteresseIterativo(numAnni, importoVincolato, percInteresse);

            InteresseRicorsivo(numAnni, importoVincolato, percInteresse);

        }

        private static void InteresseRicorsivo(int numAnni, double importoVincolato, int percInteresse)
        {
            
        }

        private static double[] InteresseIterativo(int numAnni, double importoVincolato, int percInteresse)
        {
            double[] importoTotale = new double[numAnni];
            for (int i=0; i<numAnni; i++)
            {
                importoTotale[i] = importoVincolato + ((importoVincolato * 3) / 100);
                Console.WriteLine($"l'importo totale all'anno {i} è {importoTotale[i]}");
                importoVincolato = (importoTotale[i]);
                

            }
            return importoTotale;
        }
    }
  
}
