using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.SoluzioneEsercizio3Day1
{
   public class CalcoloInteressiSalvataggioFile
    {
        public static void Start()
        {
            //MIA SOLUZIONE ALL'ESERCIZIO 3 COME LO HA FATTO LEI, E CON IL SALVATAGGIO SU FILE
            //calcolo l'interesse con il metodo iterativo e salvo i risultati sul file al posto che stamparli

            int percInteresseAnnuo = 3;
            double importoVincolato = InserisciImportoVincolato();
            int anni = InserisciAnniVincolo();
            double[] importoAnnuale = new double[anni];
            double[] interesseAnnuale = new double[anni];
            double[] importoPrecedente = new double[anni];
            CalcolaInteresse(importoVincolato, anni, percInteresseAnnuo, out importoAnnuale, out interesseAnnuale, out importoPrecedente);

            string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\Interessi.txt";
            SalvataggioDatiFile(importoAnnuale, interesseAnnuale, importoPrecedente, path); //si poteva anche creare la stringa nella funzione
                                                                                            //precedente e chiamare questa funzione dentro la
                                                                                            //precedente per farle stampare la stringa ogni volta
        }

        private static void SalvataggioDatiFile(double[] importoAnnuale, double[] interesseAnnuale, double[] importoPrecedente, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                for (int i = 0; i < importoAnnuale.Length; i++)
                {
                    sw.WriteLine($"Dopo {i + 1} anni, da {importoPrecedente[i]} avrai { interesseAnnuale[i]} " +
                    $"e il tuo nuovo capitale sarà {importoAnnuale[i]}");
                }
            }
        }

        private static void CalcolaInteresse(double importoVincolato, int anni, int percInteresseAnnuo, out double[] importoAnnuale, out double[] interesseAnnuale, out double[] importoPrecedente)
        {
            double currImporto = 0;
            double currInteresse = 0;
            double currVincolato = importoVincolato;
            double[] importoPrec = new double[anni];
            double[] InteresseAnnuale = new double[anni];
            double[] ImportoAnnuale = new double[anni];
            for (int i=0;i<anni; i++)
            {
                importoPrec[i] = currVincolato;
                currInteresse = currVincolato * percInteresseAnnuo / 100;
                currImporto = currVincolato + currInteresse;
                ImportoAnnuale[i] = currImporto;
                InteresseAnnuale[i] = currInteresse;
                currVincolato = currImporto;

            }
            importoAnnuale = ImportoAnnuale;
            interesseAnnuale = InteresseAnnuale;
            importoPrecedente = importoPrec;
        }

        private static int InserisciAnniVincolo()
        {
            int anni = 0;
            Console.WriteLine("Per quanti anni vuoi vincolare la somma?");
            while(!(int.TryParse(Console.ReadLine(), out anni)&&anni>0))
            {
                Console.WriteLine("Hai inserito un valore non riconosciuto. Devi inserire un numero intero posivo. Riprova");
            }
            return anni;
        }

        private static double InserisciImportoVincolato()
        {
            double importoVincolato = 0;
            Console.WriteLine("Inserisci importo da vincolare:");
            while (!(double.TryParse(Console.ReadLine(), out importoVincolato)&&importoVincolato>0))
            {
                Console.WriteLine("Hai inserito un valore sbagliato, devi inserire un importo positivo. Riprova");
            }
            return importoVincolato;
        }
    }
}
