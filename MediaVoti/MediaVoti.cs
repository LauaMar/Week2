using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.Esercizio4Day1
{
    public static class MediaVoti
    {
        public static void Start()
        {
            /* Scrivere un programma che gestisca i voti degli esami di uno studente. In particolare chieda in 
             * ingresso un nome, un cognome e i voti degli esami sostenuti e ne calcoli la media.
             * 
             * Stampa a video:
             * Nome: Arianna
             * Cognome: Bolzoni
             * Media: 22.6 */
            string nome;
            string cognome;
            double mediaVoti;
            //IdentificaStudente(out nome, out cognome);
            //mediaVoti = OperazioniPerMediaVoti();
            mediaVoti = OperazioniPerMediaVotiRicorsiva();
        }


        private static int SommaVotiRicorsiva(int[] votiEsami, int numEsami)
        //private static int SommaVotiRicorsiva(int[] votiEsami)
        {

            int sommaVoti = 0;
            //int numEsami = votiEsami.Length;
            for (int i = numEsami; i > 0; i--)
            {

                if (i == 0)
                {
                    sommaVoti = votiEsami[i];
                }
                else 
                {
                    sommaVoti = votiEsami[i] + SommaVotiRicorsiva(votiEsami, (numEsami-1));
                }
            }
            return sommaVoti;
        }
        private static double OperazioniPerMediaVotiRicorsiva()
        {
            //VerificaNumEsami(out int numEsami);
            InserisciVotiEsami(out int[] votiEsami, out int numEsami);

            int sommaVoti = SommaVotiRicorsiva(votiEsami, numEsami);
            double media = (sommaVoti/numEsami);
            return media;
        }
       private static void VerificaNumEsami(out int numEsami)
        {
            numEsami = 0;
            Console.WriteLine($"Inserisci numero di esami sostenuti:");
            while (!int.TryParse(Console.ReadLine(), out numEsami))
            {
                Console.WriteLine("Hai inserito un carattere sbagliato, riprova");
            }
        
        }
        private static double OperazioniPerMediaVoti()
        {
            InserisciVotiEsami(out int[] votiEsami, out int numEsami);
            double media = CalcolaMediaVoti(votiEsami, numEsami);
            return media;
        }

        private static double CalcolaMediaVoti(int[] votiEsami, int numEsami)
        {
            int sommaVoti = 0;
            for (int i = 0; i < numEsami; i++)
            {
                sommaVoti = sommaVoti + votiEsami[i];
            }
            double media = (sommaVoti/numEsami);
            Console.WriteLine("Media: {0}", media);
            return media;
        }

        private static void InserisciVotiEsami(out int[] votiEsami, out int numEsami)
        {
            numEsami = 0;
            Console.WriteLine($"Inserisci numero di esami sostenuti:");
            while (!int.TryParse(Console.ReadLine(), out numEsami))
            {
                Console.WriteLine("Hai inserito un carattere sbagliato, riprova");
            }
            votiEsami = new int[numEsami];
            int currVoto;
            for (int i = 0; i < numEsami; i++)
            {
                Console.WriteLine($"Inserisci voto esame ({i + 1} di {numEsami}):");
                while (!(int.TryParse(Console.ReadLine(), out currVoto) && currVoto >= 18 && currVoto <= 30))
                {
                    Console.WriteLine("Hai inserito un voto sbagliato. ");
                    Console.WriteLine("Il voto inserito deve essere compreso tra 18 e 30. Riprova:");
                }
                votiEsami[i] = currVoto;
                //Console.WriteLine($"il voto inserito è {currVoto}");
            }
        }

        private static void IdentificaStudente(out string nome, out string cognome)
        {
            Console.WriteLine("inserisci nome studente:");
            nome = Console.ReadLine();
            Console.WriteLine("inserisci cognome studente:");
            cognome = Console.ReadLine();
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Cognome: {cognome}");

        }
    }
}
