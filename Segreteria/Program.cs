using System;

namespace Segreteria
{
    class Program
    {

        /* Creare una console app che gestisca gli appelli degli esami. 
         * Un appello ha:
         * 
         * un nome (materia)
         * una data dell'esame
         * la tipologia (scritto o orale)
         * 
         * L'utente può
         * vedere tutti gli esami
         * aggiungere un nuovo appello
         * eliminare un appello
         * filtrare gli appelli per tipo
         al termine delle operazioni, gli appelli vengono salvati su file
         !!!  Attenzione : la data dell'appello deve essere almeno 10 giorni dopo la data di inserimento dell'appello
        */

        static void Main(string[] args)
        {
            Menù.Start();
        }
    }
}
