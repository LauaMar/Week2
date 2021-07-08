using System;

namespace Banca
{
    class Program
    {

        //scrivere un programma che permetta di gestire i conti correnti.

        /*i conti hanno
         * un intestatario
         * TipoDiConto --> conto corrente -conto risparmio
         * Saldo
         * 
         * un utente può:
         * -visualizzare tutti i conti -
         * può creare o eliminare un conto 
         * filtrare un tipo di conto.
         * 
         * per aprire un nuovo conto, l'importo minimo deve essere 100 
         * un utente può effettuare un prelievo
         * un utente può effettuare un versamento
         * sul conto risparmio si può solamente versare, mentre sul conto corrente si può sia versare che prelevare
         * quando un utente decide di uscire, i conti vengono salvati su file*/

        static void Main(string[] args)
        {
            Menù.Start();
        }
    }
}
