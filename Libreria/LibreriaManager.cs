using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Libreria.Libro;

namespace Libreria
{
    // Sarà possibile inserire un nuovo libro, eliminare un libro, modificare un libro o cercare i libri per genere*/
    class LibreriaManager
    {
       public static List<Libro> libri = new List<Libro>();
       static string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\libreria.txt";

        public static void LeggiDaFile()
        {
            //File è una classe che fa parte della System.IO
            //Metodo exists a cui abbiamo passato la posizione e il nome del file (che è una stringa, il path)
            //Exists restituisce un booleano
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string file = sr.ReadToEnd();
                    // se il file è vuoto scrivo che non ci sono ancora libri nella libreria

                    //bool isNull = String.IsNullOrEmpty(file); // metodo che controlla se la stringa di nome file è vuota e restituisce
                    //un booleano
                    if (string.IsNullOrEmpty(file))
                    {
                        Console.WriteLine("La libreria è vuota!");
                    }
                    else
                    {

                        string[] righeFile = file.Split("\r\n");
                        // riga 1 --> intestazione
                        //riga 2 --> titolo \t\t autore \t\t genere \t\t prezzo
                        // ultima riga --> vuota
                        for (int i = 1; i < (righeFile.Length - 1); i++)
                        {
                            Libro libro = new Libro();
                            string riga = righeFile[i];
                            string[] campiRiga = riga.Split("\t\t");
                            libro.Titolo = campiRiga[0];
                            libro.Autore = campiRiga[1];
                            libro.Genere = (Tipologia)Enum.Parse(typeof(Tipologia), campiRiga[2]); // il Parse mi converte campiriga[2] che 
                                                                                                   // è una stringa, in un enum, mentre il typeof gli dice che tipo di enum è (ci possono essere diversi enum)
                                                                                                   // il (Tipologia) all'inizio è un cast esplicito che serve in aggiunta al parse per convertire l'enum

                            libro.Prezzo = Convert.ToDouble(campiRiga[3]); // conversione esplicita

                            libri.Add(libro);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("La libreria è vuota!");
            }
        }

        //metodi
        public static void AggiungiLibro()
        {
            Libro libro = new Libro();
            Console.WriteLine("Inserisci il titolo del libro da aggiungere:");
            libro.Titolo = Console.ReadLine();

            Console.WriteLine("Inserisci l'autore del libro da aggiungere:");
            libro.Autore = Console.ReadLine();

            // la parte di inserimento genere è piuttosto corposa, meglio spostarla in un metodo
            Console.WriteLine("Inserisci il genere del libro da aggiungere:");
            libro.Genere = InserisciGenere();


            libro.Prezzo = GestisciPrezzo();

            libri.Add(libro);
        }

        public static void EliminaLibro()
        {
            Console.WriteLine("Inserisci il titolo del libro da eliminare:");
            string titolo = Console.ReadLine();
            Libro libroDaEliminare = CercaLibro(titolo);
            if (libroDaEliminare != null)
            {
                libri.Remove(libroDaEliminare);
            }
            else
            {
                Console.WriteLine("Non ho trovato il libro da eliminare");
            }
        }

        public static void StampaLibri(List<Libro> libri)
        {
            Console.WriteLine("Titolo\t\t Autore \t Genere \t Prezzo");
            Console.WriteLine();
            foreach (Libro libro in libri)
            {
                Console.WriteLine($"{libro.Titolo}\t\t{libro.Autore}\t\t{libro.Genere}\t\t{libro.Prezzo}");
            }
        }

        internal static void SalvaSuFile()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Titolo \t\t  Autore \t\t Genere \t\t Prezzo \t\t");
            }
            
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                
                foreach(Libro libro in libri)
                {
                    sw.WriteLine($"{libro.Titolo}\t\t {libro.Autore}\t\t {libro.Genere}\t\t {libro.Prezzo}");
                }
            }
        }

        public static void StampaLibri()
        {
            StampaLibri(libri);
        }

        internal static void FiltraLibri()
        {
            Console.WriteLine("Scegli il genere di libri che vuoi vedere");
            Tipologia tipologiaDaFiltrare = InserisciGenere();
            List<Libro> libriPerGenere = new List<Libro>();
            foreach(Libro libro in libri)
            {
                if(libro.Genere==tipologiaDaFiltrare)
                {
                    libriPerGenere.Add(libro);
                }
            }
            if(libriPerGenere.Count>0)
            {
                StampaLibri(libriPerGenere);
            }
            else
            {
                Console.WriteLine($"Non sono presenti libri del genere {tipologiaDaFiltrare}");
            }

        }

        public static void ModificaLibro()
        {
            Console.WriteLine("Inserisci il titolo del libro da modificare:");
            string titolo = Console.ReadLine();
            Libro libroDaModificare = CercaLibro(titolo);
            libri.Remove(libroDaModificare); // lo devo rimuovere qui perché poi una volta che lo modifica non lo riconosce più
            bool continuare = true;
            do
            {
                Console.WriteLine("Premi 1 per modificare il titolo");
                Console.WriteLine("Premi 2 per modificare l'autore");
                Console.WriteLine("Premi 3 per modificare il genere");
                Console.WriteLine("Premi 4 per modificare il prezzo");
                Console.WriteLine("Premi 0 se hai terminato");

                int scelta = 0;
                bool isInt = true;
                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out scelta);
                } while (!isInt);

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserisci il titolo modificato");
                        libroDaModificare.Titolo = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Inserisci l'autore modificato");
                        libroDaModificare.Autore = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Inserisci il genere modificato");
                       libroDaModificare.Genere = InserisciGenere();

                        break;
                    case 4:
                        Console.WriteLine("Inserisci il prezzo modificato");
                        libroDaModificare.Prezzo = GestisciPrezzo();
                        break;
                    case 0:
                        continuare = false;
                        break;
                }
            } while (continuare);

            //libri.Remove(libroDaModificare); //in realtà sembra funzionare anche se lo rimuovo qui e non in cima
            libri.Add(libroDaModificare); //aggiungo nuovamente alla lista dei libri il libro modificato
        }

        public static Libro CercaLibro(string titolo)
        {
            foreach (Libro libro in libri)
            {
                if (libro.Titolo == titolo)
                {
                    return libro;
                }
            }
            return null;
        }

        public static Tipologia InserisciGenere()
        {
            Console.WriteLine($"Premi {(int)Tipologia.Narrativa} per il genere {Tipologia.Narrativa}");
            Console.WriteLine($"Premi {(int)Tipologia.Storico} per il genere {Tipologia.Storico}");
            Console.WriteLine($"Premi {(int)Tipologia.Fantasy} per il genere {Tipologia.Fantasy}");
            int genere = 4;
            bool isInt = true;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out genere);
            } while (!isInt);
            return (Tipologia)genere; // è come se facessi un cast dell'intero al tipo "tipologia"
        }

        public static double GestisciPrezzo()
        {
            bool isDouble;
            double prezzo = 0;
            do
            {
                Console.WriteLine("Inserisci il prezzo del libro da aggiungere:");
                isDouble = double.TryParse(Console.ReadLine(), out prezzo);
            } while (!isDouble);
            return prezzo;
        }
    }

}
