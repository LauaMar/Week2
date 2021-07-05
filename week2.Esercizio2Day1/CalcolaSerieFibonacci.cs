using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.Esercizio2Day1
{
    public static class CalcolaSerieFibonacci
    {
        public static void Start()
        {
            //   Dato in ingresso un numero intero, calcolare la serie di Fibonacci
            //       1, 1, 2, 3, 5, 8, 13, 21.....

            int numeroIterazioni = 5;
            int numDaRaggiungere = 21;

            //if (numeroIterazioni > 1)
            //{
            //    for (int i = 1; i < numeroIterazioni; i++)
            //    {
            //        //int risultato = FibonacciRicorsione(i);
            //        int risultato = FibonacciRicorsione2(i);
            //    }
            //}

            //Console.WriteLine($"Fibonacci: numero di iterazioni: {i} --> risultato: {risultato}");
            //SerieFibonacciIterazione(numDaRaggiungere); /* qui gli passo in ingresso il numero che deve raggiungere
            //* rifarlo passandogli in ingresso il numero di iterazioni e non il numero 
            //* da raggiungere */

            //SerieFibonacciIterazioneNumIterazioni(numeroIterazioni); // rifare con il numero delle iterazioni in ingresso

            if (numeroIterazioni > 1)
            {
                for (int i = 0; i < numeroIterazioni; i++)
                {
                    SerieFibonacciRicorsione(i);
                }
            }
        }

        private static int SerieFibonacciRicorsione(int numeroIterazioni)
        {
            int risultato;
            //if (numeroIterazioni == 0)
            //{
            //    risultato = 0;
            //}
            //else if(numeroIterazioni < 2)
            if (numeroIterazioni < 2)
            {
                   risultato = 1;
                }
                else
                {
                    int precRes1 = SerieFibonacciRicorsione(numeroIterazioni - 1);
                    int precRes2 = SerieFibonacciRicorsione(numeroIterazioni - 2);
                    risultato = precRes1 + precRes2;
                }
                Console.WriteLine($" al ciclo {numeroIterazioni+1} l'attuale numero di Fibonacci è {risultato}");
            return risultato;
        }

        /* 1 1 2 3 5 8
         * 1 +1 -> 2*/
        private static void SerieFibonacciIterazioneNumIterazioni(int numeroIterazioni)
        {
            int risultato = 0;
            int risultatoPrecedente1 = 1;
            int risultatoPrecedente2 = 1;
            for (int i = 0; i < numeroIterazioni; i++)
            {
                if (i < 2)
                {
                    risultato = 1;
                }
                else
                {
                    risultato = risultatoPrecedente1 + risultatoPrecedente2;
                    risultatoPrecedente2 = risultatoPrecedente1;
                    risultatoPrecedente1 = risultato;
                }
                Console.WriteLine($"alla iterazione {i} il valore della serie di Fibonacci è {risultato}");
            }
        }

        private static int FibonacciRicorsione(int i)
        {
            int risultato = 1;
            if (i > 1)
            {
                risultato = FibonacciRicorsione(i - 1) + FibonacciRicorsione(i - 2);
            }
            Console.WriteLine($"Fibonacci: numero di iterazioni: {i} --> risultato: {risultato}");
            return risultato;
        }

        private static int FibonacciRicorsione2(int i)
        {
            int totale = 0;
            if (i==1 || i==2)
            {
                totale = 1;
            }
            else
            {
                int fib1 = FibonacciRicorsione2(i-1);
                int fib2 = FibonacciRicorsione2(i - 2);
                totale = fib1 + fib2;
            }
            Console.WriteLine($"Fibonacci: numero di iterazioni: {i} --> risultato: {totale}");
            return totale;
        }


        //static void SerieFibonacciIterazione(int numeroInterazioni)
        //{
        //    Console.WriteLine("Calcolo con l'iterazione");
        //    int nuovoTotale = 0;
        //    int totalePrecedente1 = 0;
        //    int totalePrecedente1 = 1;
        //    int i
        //    while (i < numeroIterazioni)
        //    {

        //        nuovoTotale = totalePrecedente1 + totalePrecedente2;
        //        Console.WriteLine($"il numero successivo della serie di Fibonacci è {totale}");
        //        totalePrecedente = totale;
        //        totale = nuovoTotale;

        //    }

        //    //}

            static void SerieFibonacciIterazione(int numero)
        {
            Console.WriteLine("Calcolo con l'iterazione");
            int[] serieFibonacci = new int[numero];
            serieFibonacci[0] = 0;
            serieFibonacci[1] = 1;
            int i = 2;
            Console.WriteLine($"il numero successivo della serie di Fibonacci è {serieFibonacci[0]}");
            Console.WriteLine($"il numero successivo della serie di Fibonacci è {serieFibonacci[1]}");
            while (serieFibonacci[i-1] < numero)
            {
                serieFibonacci[i] = serieFibonacci[i-1] + serieFibonacci[i - 2];
                Console.WriteLine($"il numero successivo della serie di Fibonacci è {serieFibonacci[i]}");
                i++;

            }
            Array.Resize(ref serieFibonacci, i+1);

        }
    }
}
