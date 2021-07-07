using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public static class Menù
    {
        public static void Start()
        {
            int scelta = 5;
            while (scelta != 0)
            {

                Console.WriteLine("Benvenuto in libreria!");

                LibreriaManager.LeggiDaFile(); // facendo così, se il file non esiste il sistema genera una eccezione e si blocca
                // bisogna controllare che il file esista

                Console.WriteLine("Scegli l'operazione da svolgere:");
                Console.WriteLine("Premi 1 per inserire un libro;");
                Console.WriteLine("Premi 2 per eliminare un libro;");
                Console.WriteLine("Premi 3 per modificare un libro;");
                Console.WriteLine("Premi 4 per stampare tutti i libri;");
                Console.WriteLine("Premi 5 per filtrare i libri per genere;");
                Console.WriteLine("Premi 0 per uscire.");

                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Hai inserito un valore non valido, ritenta");
                }
                switch (scelta)
                {
                    case 1:
                        LibreriaManager.AggiungiLibro();
                        break;
                    case 2:
                        LibreriaManager.EliminaLibro();
                        break;
                    case 3:
                        LibreriaManager.ModificaLibro();
                        break;
                    case 4:
                        LibreriaManager.StampaLibri();
                        break;
                    case 5:
                        LibreriaManager.FiltraLibri();
                        break;
                    case 0:
                        LibreriaManager.SalvaSuFile();
                        break;
                    default:
                        Console.WriteLine("Hai scelto un valore non associato a nessuna azione!");
                        break;

                }
            }


        }
    }
}
