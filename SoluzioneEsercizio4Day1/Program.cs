using System;
using System.Collections.Generic;
using System.IO;

namespace SoluzioneEsercizio4Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            MediaConArray.mediaArray();
            #region MediaConLista
            //    Console.WriteLine("Inserisci il tuo nome:");
            //    string nome = Console.ReadLine();

            //    Console.WriteLine("Inserisci il tuo cognome:");
            //    string cognome = Console.ReadLine();

            //    List<int> esami = new List<int>();

            //    bool isInt = true;
            //    int votoEsame = 0;
            //    int continuare = 0;
            //    bool isInt2 = true;

            //    while (true)
            //    {
            //        do
            //        {
            //            Console.WriteLine("Vuoi inserire un altro esame? ");
            //            Console.WriteLine("premi 1 per inserire un altro esame;");
            //            Console.WriteLine("premi 2 per terminare.");
            //            isInt2 = int.TryParse(Console.ReadLine(), out continuare);
            //        } while (!isInt2);

            //        if (continuare == 1)
            //        {
            //            do
            //            {
            //                Console.WriteLine("Inserisci il voto di un esame:");
            //                isInt = int.TryParse(Console.ReadLine(), out votoEsame);
            //            } while (!isInt);
            //            esami.Add(votoEsame);
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    int sommaVotiEsami = 0;
            //    foreach (int voto in esami)
            //    {
            //        sommaVotiEsami = sommaVotiEsami + voto;
            //    }
            //    int numEsami = esami.Count;
            //    double media = sommaVotiEsami / numEsami;

            //    //Console.WriteLine($"Nome: {nome}");
            //    //Console.WriteLine($"Cognome: {cognome}");
            //    //Console.WriteLine($"Media: {media}");

            //    ////oppure
            //    //Console.WriteLine($"Nome: {nome}\n Cognome: {cognome}\n Media: {media}");
            //    //Console.WriteLine($"Nome: {nome}\t Cognome: {cognome}\t Media: {media}"); // fa il tab, quindi dovrebbe incolonnare

            //    ////oppure
            //    Console.WriteLine($"Nome: \t Cognome: \t Media: ");
            //    Console.WriteLine($"{nome}\t {cognome}\t {media}");
            //    //StampaSuFile($"Nome: \t Cognome: \t Media: ");
            //    //StampaSuFile($"{nome}\t {cognome}\t {media}");
            //    string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\Media.txt";
            //    using (StreamWriter sw = new StreamWriter(path, true))
            //    {
            //        sw.WriteLine($"Nome: \t Cognome: \t Media: ");
            //        sw.WriteLine($"{nome}\t {cognome}\t {media}");

            //    }


            //}
            //static void StampaSuFile(string messaggio)
            //{
            //    string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\Media.txt";
            //    using (StreamWriter sw = new StreamWriter(path, true))
            //    {
            //        sw.WriteLine(messaggio);
            //    }
            //}
            #endregion

            #region MediaConClasseStudente

            //Studente studente = new Studente();

            //Console.WriteLine("Inserisci il tuo nome:");
            //studente.Nome = Console.ReadLine();

            //Console.WriteLine("Inserisci il tuo cognome:");
            //studente.Cognome = Console.ReadLine();

            //List<int> esami = new List<int>();

            //bool isInt = true;
            //int votoEsame = 0;
            //int continuare = 0;
            //bool isInt2 = true;

            //while (true)
            //{
            //    do
            //    {
            //        Console.WriteLine("Vuoi inserire un altro esame? ");
            //        Console.WriteLine("premi 1 per inserire un altro esame;");
            //        Console.WriteLine("premi 2 per terminare.");
            //        isInt2 = int.TryParse(Console.ReadLine(), out continuare);
            //    } while (!isInt2);

            //    if (continuare == 1)
            //    {
            //        do
            //        {
            //            Console.WriteLine("Inserisci il voto di un esame:");
            //            isInt = int.TryParse(Console.ReadLine(), out votoEsame);
            //        } while (!isInt);
            //        esami.Add(votoEsame);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //studente.Esami = esami;

            //int sommaVotiEsami = 0;
            //foreach (int voto in studente.Esami)
            //{
            //    sommaVotiEsami = sommaVotiEsami + voto;
            //}
            //studente.Media = sommaVotiEsami / studente.Esami.Count;

            //string anagrafica = studente.OttieniDati();
            //Console.WriteLine(anagrafica + $"\n Media: {studente.Media}");
            ////oppure
            //Console.WriteLine($"Nome: \t Cognome: \t Media: ");
            //Console.WriteLine($"{studente.Nome}\t {studente.Cognome}\t {studente.Media}");

            ////Console.WriteLine($"Nome: {nome}");
            ////Console.WriteLine($"Cognome: {cognome}");
            ////Console.WriteLine($"Media: {media}");

            //////oppure
            ////Console.WriteLine($"Nome: {nome}\n Cognome: {cognome}\n Media: {media}");
            ////Console.WriteLine($"Nome: {nome}\t Cognome: {cognome}\t Media: {media}"); // fa il tab, quindi dovrebbe incolonnare

            //////oppure
            ////Console.WriteLine($"Nome: \t Cognome: \t Media: ");
            ////Console.WriteLine($"{studente.Nome}\t {studente.Cognome}\t {studente.Media}");
            //////StampaSuFile($"Nome: \t Cognome: \t Media: ");
            //////StampaSuFile($"{nome}\t {cognome}\t {media}");
            ////string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\Media.txt";
            ////using (StreamWriter sw = new StreamWriter(path, true))
            ////{
            ////    sw.WriteLine($"Nome: \t Cognome: \t Media: ");
            ////    sw.WriteLine($"{studente.Nome}\t {studente.Cognome}\t {studente.Media}");

            ////}


            //}
            //static void StampaSuFile(string messaggio)
            //{
            //    string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\Media.txt";
            //    using (StreamWriter sw = new StreamWriter(path, true))
            //    {
            //        sw.WriteLine(messaggio);
            //    }
            //}
            #endregion

        }
    }
}
