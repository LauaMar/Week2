using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Segreteria.Appello;

namespace Segreteria
{
    /* L'utente può
         * vedere tutti gli esami
         * aggiungere un nuovo appello
         * eliminare un appello
         * filtrare gli appelli per tipo
         al termine delle operazioni, gli appelli vengono salvati su file
         !!!  Attenzione : la data dell'appello deve essere almeno 10 giorni dopo la data di inserimento dell'appello
        */
    class SegreteriaManager
    {
        public static List<Appello> appelli = new List<Appello>();
        public static string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\Appelli.txt";

        public static void AggiungiAppello()
        {
            Appello appello = new Appello();
            Console.WriteLine("Inserire il nome della materia:");
            appello.Materia = Console.ReadLine();

            Console.WriteLine("Inserire la data dell'esame:");
            Console.WriteLine("N.B. la data dell'esame deve essere almeno 10 giorni dopo la data di inserimento dell'appello");
            DateTime dataEsame = new DateTime();
            while (!(DateTime.TryParse(Console.ReadLine(), out dataEsame) && dataEsame > DateTime.Now.Date.AddDays(10)))
            {
                Console.WriteLine("La data scelta per l'appello non è valida, inserirne un'altra");
            }

            appello.Data = dataEsame.Date;

            Console.WriteLine("Scegliere la tipologia dell'esame");
            appello.TipoEsame = GestireTipoEsame();

            appelli.Add(appello);
        }

        public static Tipologia GestireTipoEsame()
        {
            Console.WriteLine($"Premere {(int)Tipologia.Scritto} per {Tipologia.Scritto}");
            Console.WriteLine($"Premere {(int)Tipologia.Orale} per {Tipologia.Orale}");
            int tipoEsame = 2;
            while (!(int.TryParse(Console.ReadLine(), out tipoEsame)) && tipoEsame >= 0 && tipoEsame < 2)
            {
                Console.WriteLine("La scelta effettuata non è valida, riprova:");
            }
            return (Tipologia)tipoEsame;
        }

        //public static void EliminaAppello()
        //{
        //    Console.WriteLine("Inserire il numero dell'appello che si vuole eliminare");
        //    MostraAppelli();
        //    int appelloDaEliminare = 0;
        //    while(!(int.TryParse(Console.ReadLine(), out appelloDaEliminare)&&appelloDaEliminare>0&&appelloDaEliminare<=appelli.Count))
        //    {
        //        Console.WriteLine("Il numero inserito non corrisponde a nessun appello");
        //    }
        //    appelli.RemoveAt(appelloDaEliminare-1);

        //}

        public static void EliminaAppello()
        {
            DateTime dataDaCercare = new DateTime();
            List<Appello> appelliInData = new List<Appello>();
            Console.WriteLine("Inserire la data dell'appello che si vuole eliminare");
            while(!DateTime.TryParse(Console.ReadLine(),out dataDaCercare))
            {
                Console.WriteLine("Data inserita non corretta, riprovare:");
            }

            foreach(Appello appello in appelli)
            {
                if(appello.Data==dataDaCercare)
                {
                    appelliInData.Add(appello);
                }
            }
            if (appelliInData.Count == 1)
            {
                appelli.Remove(appelliInData[0]);
            }
            else
            {
                MostraAppelli(appelliInData);
                Console.WriteLine("Scrivere la materia dell'appello da eliminare");
                string MateriaDaEliminare = Console.ReadLine();
                for(int i=0; i<appelliInData.Count; i++)
                {
                    Appello currAppello = appelliInData[i];
                    if(currAppello.Materia==MateriaDaEliminare)
                    {
                        appelli.Remove(appelliInData[i]);
                    }
                }
            }

        }

        public static void MostraAppelli()
        {
            MostraAppelli(appelli);
        }
        public static void MostraAppelli(List<Appello> appelli)
        {
            if (appelli.Count >= 1)
            {
                Console.WriteLine("Materia\t\t Data \t\t Tipo");
                foreach (Appello appello in appelli)
                {
                    Console.WriteLine($"{ appello.Materia}\t\t {appello.Data.ToString("dd/MM/yyyy")} \t\t {appello.TipoEsame}");
                }
            }
            else 
            {
                Console.WriteLine("Non ci sono appelli!");
            }
        }

        public static void FiltraAppelli()
        {
            List<Appello> appelliDaMostrare = new List<Appello>();
            Console.WriteLine("Scegliere il tipo di esame da mostrare");
            Tipologia tipoDaMostrare = GestireTipoEsame();
            foreach(Appello appello in appelli)
            {
                if (appello.TipoEsame== tipoDaMostrare)
                {
                    appelliDaMostrare.Add(appello);  
                }
            }

                MostraAppelli(appelliDaMostrare);

        }
        public static void SalvaSuFile()
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Materia \t\t Data \t\t Tipo di Esame");
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Appello appello in appelli)
                {
                    sw.WriteLine($"{appello.Materia} \t\t {appello.Data} \t\t {appello.TipoEsame}");
                }
            }
        }


    }
}
