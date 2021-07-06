using System;
using System.IO;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\prova.txt"; // con la @ legge la stringa carattere per carattere
           
            // scrittura su file con chiusura manuale
            StreamWriter sw = new StreamWriter(path); 
            sw.WriteLine("ciao a tutte!!"); // questo è quello che scrive sul file

            sw.Close(); //chiude la connessione con il file, che altrimenti resta aperto e occupa memoria
                        // ricordarsi sempre di chiudere la connessione

            // scrittura su file per chiusura automatica
            //using (StreamWriter sw1 = new StreamWriter(path)) // apre la connessione alla streamwriter e la mantiene 
            //                                                 // per tutta la durata delle operazioni incluse tra graffe, 
            //                                                 // ma poi la chiude in automatico
            //{
            //    sw1.WriteLine("Buongiorno!!"); // scritto così lui prende il file, lo svuota e poi scrive la nuova riga
            //                                  // cancella il resto del file 
            //}

            using(StreamWriter sw1 = new StreamWriter(path, true)) // se metto il booleano true, lui non cancella quello
                                                                   //trova sul file, ma ci aggiunge in coda

            {
                sw1.WriteLine("Come state?");
            }

            using(StreamReader sr = new StreamReader(path))
            {
                string contenutoFile = sr.ReadToEnd(); // legge tutto il file
            }

            // lettura di una riga del file
            using(StreamReader sr =new StreamReader(path))
            {
                string contenutoRiga = sr.ReadLine(); // legge una riga (la prima)
            }

            //lettura di tutto il file e divisione del file in righe
            using(StreamReader sr = new StreamReader(path))
            {
                string contenutoFile = sr.ReadToEnd(); // legge tutto il file 
                var arrayDiRighe = contenutoFile.Split("\r\n"); // crea un array di righe, di cui l'ultima è vuota perché
                                             // al termine dell'utima riga scritta trova un \r\n e quindi trova una riga
                                             // in più. BISOGNA SEMPRE TOGLIERE L'ULTIMO ELEMENTO DELL'ARRAY
            }
        }
    }
}
