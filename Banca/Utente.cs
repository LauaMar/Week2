using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banca.Conto;

namespace Banca
{
    class Utente
    {
        public static List<Conto> conti = new List<Conto>();
        //metodi 
        public static void CreareConto()
        {
            Conto conto = new Conto();
            Console.WriteLine("Inserisci l'intestatario del conto");
            conto.Intestatario = Console.ReadLine();

            conto.TipoDiConto = GestisciTipoConto();

            conto.Saldo = GestisciSaldo();
            

            conti.Add(conto);
        }

        public static void EliminareConto()
        {
            Conto contoDaEliminare = new Conto();
            Console.WriteLine("Inserisci l'intestatario del conto da eliminare:");
            string intestatario = Console.ReadLine();
            contoDaEliminare = CercareConto(intestatario);
            conti.Remove(contoDaEliminare);
        }
        public static Conto CercareConto(string intestatario)
        {
            foreach (Conto conto in conti)
            {
                if (conto.Intestatario == intestatario)
                {
                    return conto;
                }
            }
            Console.WriteLine("Conto non trovato");
            return null;
        }

        private static double GestisciSaldo()
        {
            double saldo = 0;
            Console.WriteLine("Quanto denaro vuoi depositare nel conto?");
            while(!(double.TryParse(Console.ReadLine(), out saldo)&&saldo>=0))
            {
                Console.WriteLine("Hai inserito un valore non valido! Devi inserire un intero positivo:");
            }
            return saldo;
        }

        public static Tipologia GestisciTipoConto ()
        {
            Console.WriteLine("Inserisci il tipo di conto da creare");
            Console.WriteLine($"Premi {(int)Tipologia.Corrente} per Conto {Tipologia.Corrente}");
            Console.WriteLine($"Premi {(int)Tipologia.Risparmio} per Conto {Tipologia.Risparmio}");
            int tipoDiConto = 2;
            while (!(int.TryParse(Console.ReadLine(), out tipoDiConto) && tipoDiConto >= 0 && tipoDiConto <= 1))
            {
                Console.WriteLine("Hai inserito un valore non corretto. \n Devi inserire un intero compreso tra 0 e 1. Riprova:");
            }
            return (Tipologia)tipoDiConto;
        }
    }
}
