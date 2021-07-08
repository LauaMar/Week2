using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    public static class Menù
    {
        public static void Start()
        {
            Console.WriteLine("Benvenuto in Banca!");
            
            int operazione = 10;
            while (operazione != 0)
            {
                Console.WriteLine("Seleziona l'operazione da compiere:");
                Console.WriteLine("Premi 1 per Aprire un conto");
                Console.WriteLine("Premi 2 per Chiudere un conto");
                Console.WriteLine("Premi 3 per Filtrare i conti per tipo");
                Console.WriteLine("Premi 4 per Visualizzare tutti i conti");
                Console.WriteLine("Premi 5 per effettuare un prelievo");
                Console.WriteLine("Premi 6 per Effettuare un versamento");
                Console.WriteLine("Premi 0 per Uscire");
                while(!int.TryParse(Console.ReadLine(), out operazione))
                {
                    Console.WriteLine("Hai inserito una opzione non valida, riprova:");
                }
                switch (operazione)
                {
                    case 0:
                        BancaManager.SalvaSuFile();
                        break;
                    case 1:
                        BancaManager.AggiungiConto();
                        break;
                    case 2:
                        BancaManager.EliminareConto();
                        break;
                    case 3:
                        BancaManager.FiltraConti();
                        break;
                    case 4:
                        BancaManager.MostraConti();
                        break;
                    case 5:
                        BancaManager.EffettuaPrelievo();
                        break;
                    case 6:
                        BancaManager.EffettuaVersamento();
                        break;
                    default:
                        Console.WriteLine("Hai inserito una opzione non valida, riprova:");
                        break;
                }
            }
        }
    }
}
