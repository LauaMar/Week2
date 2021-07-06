using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2.SoluzioneEsercizio3Day1
{
    class FileManager
    {
       public static string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\Interessi.txt"; // così non devo scriverlo 
                                                                                                         //dentro ogni funzione, ma lo riconoscono

        public static void Indirizzatore(string messaggio, bool scriviInCoda, int formatoInt)
        {
            if (formatoInt==(int)Formato.File)
            {
                ScrivisuFile2(messaggio, scriviInCoda);
            }
            else
            {
                Console.WriteLine(messaggio);
            }
        }
        public static void ScrivisuFile(string messaggio, int count)
        {
            
            if (count == 0)
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.WriteLine(messaggio);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(messaggio);
                }
            }
        }

        public static void ScrivisuFile(string messaggio)
        {
            ScrivisuFile(messaggio, 1);
        }

        public static void ScrivisuFile2(string messaggio, bool cancella)
        { 

            using (StreamWriter sw = new StreamWriter(path, cancella))
            {
                sw.WriteLine(messaggio);
            }
        }

        enum Formato
        {
            File,
            Console
        }
    }
}
