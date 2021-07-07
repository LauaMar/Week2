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
                Console.WriteLine("Premi 0 per Uscire");
                while(!int.TryParse(Console.ReadLine(), out operazione))
                {
                    Console.WriteLine("Hai inserito una opzione non valida, riprova:");
                }
                switch (operazione)
                {
                    case 0:
                        break;
                    case 1:
                        Utente.CreareConto();
                        break;
                    case 2:
                        Utente.EliminareConto();
                        break;
                    default:
                        Console.WriteLine("Hai inserito una opzione non valida, riprova:");
                        break;
                }
            }
        }
    }
}
