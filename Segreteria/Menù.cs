using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segreteria
{
    class Menù
    {
        public static void Start()
        {
            Console.WriteLine("Benvenuto in sereteria!");
            int scelta = 5;

            while (scelta != 0)
            {
                Console.WriteLine("Scegliere l'azione da compiere");
                Console.WriteLine("Premere 1 per aggiungere un appello");
                Console.WriteLine("Premere 2 per eliminare un appello");
                Console.WriteLine("Premere 3 per visualizzare gli appelli");
                Console.WriteLine("Premere 4 per filtrare gli appelli per tipo");
                Console.WriteLine("Premere 0 per uscire");

                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Il numero inserito non è corretto, riprova");
                }

                switch (scelta)
                {
                    case 0:
                        SegreteriaManager.SalvaSuFile();
                        break;
                    case 1:
                        SegreteriaManager.AggiungiAppello();
                        break;
                    case 2:
                        SegreteriaManager.EliminaAppello();
                        break;
                    case 3:
                        SegreteriaManager.MostraAppelli();
                        break;
                    case 4:
                        SegreteriaManager.FiltraAppelli();
                        break;
                    default:
                        Console.WriteLine("La scelta effettuata non corrisponde a nessuna opzione");
                        break;
                }
            }

        }
    }
}
