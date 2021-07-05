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

            int numeroIterazioni = 4;

            //if(numeroIterazioni>1)
            //{ 
            //    for(int i =1; i<numeroIterazioni; i++)
            //    {
            //        int risultato = FibonacciRicorsione(i);
            //    }
            // }

            //Console.WriteLine($"Fibonacci: numero di iterazioni: {i} --> risultato: {risultato}");
            SerieFibonacciIterazione(21); // rifarlo passandogli in ingresso il numero di iterazioni e non il numero 
                                          //da raggiungere

            //SerieFibonacciRicorsion(numeroIterazioni);
        }

        /* 1 1 2 3 5 8
         * 1 +1 -> 2*/

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
            return totale;
        }


        static void SerieFibonacciIterazione(int numeroInterazioni)
        {
            Console.WriteLine("Calcolo con l'iterazione");
            int nuovoTotale = 0;
            int totalePrecedente1 = 0;
            int totalePrecedente1 = 1;
            int i
            while (i < numeroIterazioni)
            {

                nuovoTotale = totalePrecedente1 + totalePrecedente2;
                Console.WriteLine($"il numero successivo della serie di Fibonacci è {totale}");
                totalePrecedente = totale;
                totale = nuovoTotale;

            }

            //}

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
