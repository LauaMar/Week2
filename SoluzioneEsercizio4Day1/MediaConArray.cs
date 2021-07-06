﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluzioneEsercizio4Day1
{
   public class MediaConArray
    {
        public void mediaArray()
        {
            Console.WriteLine("Inserisci il tuo nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo cognome:");
            string cognome = Console.ReadLine();

            int numeroDiEsami = 0;
            bool isInt = true;
            do
            {
                Console.WriteLine("Quanti esami hai dato)");
                isInt = int.TryParse(Console.ReadLine(), out numeroDiEsami);
            } while (!isInt);

            int[] esami = new int[numeroDiEsami];
            int votoEsame = 0;
            isInt = true;

            for (int i = 0; i < numeroDiEsami; i++)
            {
                do
                {
                    Console.WriteLine("Inserisci un voto");
                    isInt = int.TryParse(Console.ReadLine(), out votoEsame);
                } while (!isInt);
                esami[i] = votoEsame;
            }

            int somma = 0;

            foreach (int singoloVoto in esami)
            {
                somma = somma + singoloVoto;
            }

            double mediaVoti = somma / numeroDiEsami;


        }
    }
}
