using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.SoluzioneEsercizio3Day1
{
    public static class CalcoloInteressi
    {
        // SOLUZIONE ARIANNA DELL'ESERCIZIO
        public static void Start()
        {
            int interesseAnnuo = 3;

            double ImportoDaVincolare = ChiediImportoVincolo();
            int anni = ChiediAnni();
            int tipoDiOutput = ChiediDoveStampare();
            Console.WriteLine();
            Console.WriteLine("Calcolo con il metodo iterativo");
            double importoConInteressi = InteressiIterazione(ImportoDaVincolare, anni, interesseAnnuo, tipoDiOutput);

            Console.WriteLine();
            Console.WriteLine("Calcolo con il metodo ricorsivo");
            double importoConInteressiRic = InteressiRicorsione(ImportoDaVincolare, anni, interesseAnnuo);
            Console.WriteLine($"Dopo {anni} anni, avrai {importoConInteressiRic}");

        }

        //ricorsione

        static double InteressiRicorsione(double importo, int anni, int interesseAnnuo)
        {
            if (anni > 0)
            {
                return InteressiRicorsione(importo + (importo * 3 / 100), anni - 1, 3);
            }
            else
            {
                return importo;
            }
        }


        // iterazione
        static double InteressiIterazione(double importoDaVincolare, int anni, int interesseAnnuo, int tipoDiOutput)
        {
            double importoConInteresse = importoDaVincolare;
            for (var i = 0; i < anni; i++)
            {
                double importoPrecedente = importoConInteresse;
                double interessi = (importoConInteresse * interesseAnnuo / 100);
                importoConInteresse = importoConInteresse + interessi;

                //Console.WriteLine($"Dopo {i + 1} anni, da {importoPrecedente} avrai {interessi} " +
                //    $"e il tuo nuovo capitale sarà {importoConInteresse}");
                string messaggio = $"Dopo {i + 1} anni, da {importoPrecedente} avrai {interessi} " +
                    $"e il tuo nuovo capitale sarà {importoConInteresse}";
                //FileManager.ScrivisuFile(messaggio, i);
                //oppure
                if (i == 0)
                {
                    //ScrivisuFile2(messaggio, false);
                    FileManager.Indirizzatore(messaggio, false, tipoDiOutput);
                }
                else
                {
                    //ScrivisuFile2(messaggio, true);
                    FileManager.Indirizzatore(messaggio, true, tipoDiOutput);
                }
            }
            Console.WriteLine($"Quindi alla fine avrai {importoConInteresse}");
            string messaggioFinale = $"Quindi alla fine avrai {importoConInteresse}";
            //FileManager.ScrivisuFile(messaggioFinale);
            //oppure
            //ScrivisuFile2(messaggioFinale, true);
            FileManager.Indirizzatore(messaggioFinale, true, tipoDiOutput);
            return importoConInteresse;
        }

      

        private static int ChiediAnni()
        {
            int anni = 0;
            bool isInt = true;
            do
            {
                Console.WriteLine("Per quanti anni?");
                isInt = int.TryParse(Console.ReadLine(), out anni);
            } while (!isInt);
            return anni;
        }

        private static double ChiediImportoVincolo()
        {
            double importoDaVincolare = 0;
            bool isDouble = true;
            do
            {
                Console.WriteLine("Che importo vuoi vincolare?");
                isDouble = double.TryParse(Console.ReadLine(), out importoDaVincolare);
            } while (!isDouble);
            return importoDaVincolare;
        }

        private static int ChiediDoveStampare()
        {
            int tipoDiOutput = 0;
            bool isInt = true;
            do
            {
                Console.WriteLine("Premi 0 per stampare su file, premi 1 per stampare a video:");
                isInt = int.TryParse(Console.ReadLine(), out tipoDiOutput);
            } while (!isInt);
            return tipoDiOutput;
        }
    }
}
