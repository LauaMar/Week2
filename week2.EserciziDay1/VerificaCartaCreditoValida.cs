using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.Esercizio1Day1
{
    public static class VerificaCartaCreditoValida
    {
        public static void Start()
        {
            // Le carte di pagamento sono lunghe 16 cifre
           int creditCardNumberLength = 16; // questa dovrebbe essere una costante, ma in caso mi chiede altri modificatori che 
                                            //non conosciamo ancora, quindi lasciamo così
            int[] creditCardNumbers = new int[creditCardNumberLength];
            creditCardNumbers = InsertCreditCard(creditCardNumberLength);

            // Hans Peter ha inventato un metodo per determinare se un numero di carta di credito è sintatticamente valido

            /* al posto di richiamare qui ogni metodo che esegue ogni step, potevamo fare un metodo "OperazioniPerVerifica" 
             * e richiamare al suo interno ogni  step. Così sarebbe stato forse più pulito */

            // Step 1 : Vengono raddoppiate le cifre che si trovano in posizione dispari
            int[] creditCardNumbersStep1 = new int[creditCardNumberLength];
            creditCardNumbersStep1 = RaddoppioCifreDispari(creditCardNumbers); 
            // Step 2 : Se questo "raddoppio" risulta in un numero a due cifre, viene sottratto 9 da esso per ottenere una sola cifra.
            int[] creditCardNumbersStep2 = new int[creditCardNumberLength];
            creditCardNumbersStep2 = EliminaNumeriDueCifre(creditCardNumbersStep1);
            // Step 3 : Vengono sommante tutte le cifre ottenute
            // Step 4 : Vengono aggiunte le cifre nelle posizioni dispari
            int SommaCifreCartaCredito = 0;
            SommaCifreCartaCredito = SommaCifre(creditCardNumbersStep2);
            // Step 5 : Se il risultato è divisibile per 10, il numero della carta è valido; in caso contrario, non è valido.
            bool creditCardIsValid = false;
            creditCardIsValid = VerificaValiditàCartaCredito(SommaCifreCartaCredito);
            // Le carte di pagamento sono lunghe 16 cifre


            // Esempi
            // Carta di pagamento : 4  5  5  6    7  3  7  5   8  6  8  9   9  8  5  5
            // Step 1             : 8  5 10  6   14  3 14  5   16 6  16 9   18 8  10 5
            // Step 2             : 8  5  1  6    5  3  5  5   7  6  7  9   9  8  1  5
            // Step 3             : 8 + 1 + 5 + 5 + 7 + 7 + 9 + 1 = 43
            // Step 4             : 43 + (5+6+3+5+6+9+8+5) = 43 + 47 = 90
            // Step 5             : 90/10 = 9 resto 0 -> Numero della carta valido



            // Esempi
            // Carta di pagamento : 4  0  2  4    0  0  7  1   0  9  0  2   2  1  4  3
            // Step 1             : 8  0  4  4    0  0 14  1   0  9  0  2   4  1  8  3
            // Step 2             : 8  0  4  4    0  0  5  1   0  9  0  2   4  1  8  3
            // Step 3             : 8 + 4 + 0 + 5 + 0 + 0 + 4 + 8 = 29
            // Step 4             : 29 + (0+4+0+1+9+2+1+3) = 29 + 20 = 49
            // Step 5             : 49/10 = 4 resto 9 -> Numero della carta non valido


        }

        /*----------------------------------------------*/
        static int[] InsertCreditCard(int CCnumberLength)
        {
            int[] cCNumbers = new int[CCnumberLength];
            for (int i = 0; i < CCnumberLength; i++) 
            {
                Console.WriteLine($"Inserisci il successivo numero della carta {i + 1} di {CCnumberLength}:"); //si poteva plottare la richiesta
                                                                //una sola volta e non tutte le volte che inserisce una cifra
                cCNumbers[i] = int.Parse(Console.ReadLine()); //manca il controllo sul fatto che mi stia inserendo un intero (TryParse) 
            }
            return cCNumbers;
        }
        static int[] RaddoppioCifreDispari(int[] CCNumbers)
        {
            int[] CCNumbersStep1 = CCNumbers;
            for (int i = 0; i < CCNumbers.Length; i++)
            {
                if ((i + 1) % 2 != 0) // cifre in posizione dispari.
                                      // un'alternativa era invertire le istruzioni: se non c'è resto sto considerando le cifre in 
                                      //posizione dispari, altrimenti le pari (questo perché il vettore parte dalla posizione 0 e 
                                      //per VS lo zero è pari.
                {
                    CCNumbersStep1[i] = CCNumbers[i] * 2;
                }
            }
            return CCNumbersStep1;
        }
        // Step 2 : Se questo "raddoppio" risulta in un numero a due cifre, viene sottratto 9 da esso per ottenere una sola cifra.
        static int[] EliminaNumeriDueCifre(int[] CCNumbersStep1)
        {

            int[] CCNumbersStep2 = CCNumbersStep1;
            for (int i = 0; i < CCNumbersStep2.Length; i++)
            {
                if (CCNumbersStep1[i] > 9)
                {
                    CCNumbersStep2[i] = CCNumbersStep1[i] - 9;
                }
            }
            return CCNumbersStep2;
        }

        static int SommaCifre(int[] CCNubersStep2)
        {
            int sommaCifrePari = 0;
            int sommaCifreDispari = 0;
            int sommaCifreTot = 0;
            for (int i = 0; i < CCNubersStep2.Length; i++)
            {

                if ((i + 1) % 2 == 0)
                {
                    // Step 3 : Vengono sommante tutte le cifre ottenute
                    sommaCifrePari = sommaCifrePari + CCNubersStep2[i];
                }
                else
                {
                    // Step 4 : Vengono aggiunte le cifre nelle posizioni dispari
                    sommaCifreDispari = sommaCifreDispari + CCNubersStep2[i];
                }
            }
            sommaCifreTot = sommaCifrePari + sommaCifreDispari;
            return sommaCifreTot;

        }

        // Step 5 : Se il risultato è divisibile per 10, il numero della carta è valido; in caso contrario, non è valido.
        static bool VerificaValiditàCartaCredito(int sum)
        {
            bool isValid = false;
            if (sum % 10 == 0)
            {
                isValid = true;
                Console.WriteLine("Il numero di carta di credito inserito è valido!");

            }
            else
            {
                Console.WriteLine("Il numero di carta di credito inserito NON è valido!");
            }
            return isValid;
        }

    }
}
