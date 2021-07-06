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
            int numAnni = 5;
            //int percInteresse = 3;
            //double importoVincolato = 10000;
            double[] importoTotale = new double[numAnni];
            double totale = 0;

            //importoTotale = InteresseIterativo(numAnni, importoVincolato, percInteresse);

            //for (int i = 1; i <= numAnni; i++)
            //{
                totale = InteresseRicorsivo(numAnni);
            //}
        }

        private static double InteresseRicorsivo(int numAnni)
        {
            /* 10000 + 10000 *(3/100); year 1 
             * 10300 + 10300 *(3/100); year 2 --> result_year1 + result_year1*(3/100);
             * result_year2 + result_year2 *(3/100); */

            int percInteresse = 3;
            double importoVincolato = 10000;
            double importoTotale;

            if (numAnni == 1)
            {
                importoTotale = importoVincolato + ((importoVincolato *percInteresse)/100);
            }
            else 
            {
                //double addendo1 = InteresseRicorsivo(numAnni - 1);
                //double addendo2 = ((InteresseRicorsivo(numAnni - 1) * percInteresse) / 100);
                importoTotale = (InteresseRicorsivo(numAnni - 1) + ((InteresseRicorsivo(numAnni - 1) * percInteresse) / 100));
                //importoTotale = addendo1 + addendo2;
            }
            Console.WriteLine($"All'anno {numAnni}, l'importo totale è {importoTotale}");
            return importoTotale;
        }

        private static double[] InteresseIterativo(int numAnni, double importoVincolato, int percInteresse)
        {
            Console.WriteLine($"L'importo iniziale (senza interessi aggiunti) è {importoVincolato}");
            double[] importoTotale = new double[numAnni];
            for (int i = 0; i < numAnni; i++)
            {
                importoTotale[i] = importoVincolato + ((importoVincolato * percInteresse) / 100);
                Console.WriteLine($"l'importo totale all'anno {i + 1} è {importoTotale[i]}");
                importoVincolato = (importoTotale[i]);

            }
            return importoTotale;
        }
    }

}
