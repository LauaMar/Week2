using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banca.Conto;

namespace Banca
{
    class BancaManager
    {
        public static List<Conto> conti = new List<Conto>();
        public static string path = @"C:\Users\Laura Martines\Desktop\progetti\miei\week2\Banca.txt";
        //metodi 
        public static void EffettuaVersamento()
        {
            int numeroConto = 0;
            Console.WriteLine("Inserisci il numero del conto in cui versare:");
            MostraConti();
            while (!(int.TryParse(Console.ReadLine(), out numeroConto) && numeroConto > 0 && numeroConto <= conti.Count))
            {
                Console.WriteLine("Non hai inserito un numero valido, riprova:");
            }
            Conto contoInCuiVersare = conti.ElementAt(numeroConto-1);
            conti.Remove(contoInCuiVersare);
            double versamento = 0;
            Console.WriteLine("Inserisci la cifra che vuoi versare:");
            while (!(double.TryParse(Console.ReadLine(), out versamento) && versamento > 0))
            {
                Console.WriteLine("Hai inserito un valore sbagliata");
            }
            contoInCuiVersare.Saldo = contoInCuiVersare.Saldo + versamento;//
            //oppure
            //conto.AggiornaSaldo(importo);
            conti.Add(contoInCuiVersare);
        }

        internal static void SalvaSuFile()
        {
           using(StreamWriter sw= new StreamWriter(path))
            {
                sw.WriteLine("Intestatario \t\t Saldo \t\t Tipo Conto");
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
               
                foreach (Conto conto in conti)
                {
                    sw.WriteLine($"{conto.Intestatario} \t\t {conto.Saldo} \t\t {conto.TipoDiConto}");
                }
            }

        }

        //public static void LeggiDaFile()
        //{
        //    List<Conto> conti = new List<Conto>();
        //    using (StreamReader sr =new StreamReader(path))
        //    {
        //        string MyFile = sr.ReadToEnd();

        //        string[] RigheFile = MyFile.Split("\r\n");
        //        for (int i=1; i<RigheFile.Length-2; i++)
        //        {
        //            string[] proprietà = RigheFile[i].Split("\t\t");
        //            Conto conto = new Conto();
        //            conto.Intestatario = proprietà[0];
        //            conto.Saldo = Convert.ToDouble(proprietà[1]);
        //            conto.TipoDiConto = Tipologia(proprietà[2];
        //        }
        //    }
        //}

        public static void EffettuaPrelievo()
        {
            int numeroConto = 0;
            Console.WriteLine("Inserisci il numero del conto da cui prelevare:");
            MostraConti();
            while (!(int.TryParse(Console.ReadLine(), out numeroConto) && numeroConto > 0 && numeroConto <= conti.Count))
            {
                Console.WriteLine("Non hai inserito un numero valido, riprova:");
            }
            Conto contoDaCuiPrelevare = conti.ElementAt(numeroConto-1);
            if(contoDaCuiPrelevare.TipoDiConto==Tipologia.Risparmio)
            {
                Console.WriteLine("Non è possibile prelevare da un conto risparmio!");
                Console.WriteLine();
                return;
            }
            conti.Remove(contoDaCuiPrelevare);
            double prelievo = 0;
            Console.WriteLine("Inserisci la cifra che vuoi prelevare:");
            while (!(double.TryParse(Console.ReadLine(), out prelievo) && prelievo > 0 && prelievo <= contoDaCuiPrelevare.Saldo))
            {
                Console.WriteLine("Hai inserito un valore sbagliata");
            }
            contoDaCuiPrelevare.Saldo = contoDaCuiPrelevare.Saldo - prelievo;
            conti.Add(contoDaCuiPrelevare);
        }

        public static void AggiungiConto()
        {
            Console.WriteLine("Inserisci nome e cognome");
            string intestatario = Console.ReadLine();

            Tipologia tipoConto = GestisciTipoConto();

            Conto conto = new Conto(intestatario, tipoConto);

            conti.Add(conto);
        }
        public static void CreareConto()
        {
            Conto conto = new Conto();
            Console.WriteLine("Inserisci l'intestatario del conto");
            conto.Intestatario = Console.ReadLine();

            conto.TipoDiConto = GestisciTipoConto();

            conto.Saldo = GestisciSaldo();

            conto.NumeroConto = GenerareNumeroConto();


            conti.Add(conto);
        }

        private static int GenerareNumeroConto()
        {
            Random Generatore = new Random();
            int newNumeroConto = 0;
            bool isUnique = false;
            do
            {
                isUnique = false;
                newNumeroConto = 0;
                newNumeroConto = Generatore.Next(1, 100);
                if (conti.Count == 0)
                {
                    //isUnique = true;
                }
                else
                {
                    foreach (Conto conto in conti)
                    {
                        if (newNumeroConto == conto.NumeroConto)
                        {
                            isUnique = true;
                        }

                    }
                }
            } while (isUnique);
            return newNumeroConto;
        }

        public static void FiltraConti()
        {
            Console.WriteLine("Scegli il tipo di conto che vuoi vedere");
            Tipologia tipoContoDaMostrare = GestisciTipoConto();
            List<Conto> contiPerTipo = new List<Conto>();
            foreach (Conto conto in conti)
            {
                if (conto.TipoDiConto == tipoContoDaMostrare)
                {
                    contiPerTipo.Add(conto);
                }
            }
            if (contiPerTipo.Count == 0)
            {
                Console.WriteLine($"Non è stato trovato alcun conto di tipo {tipoContoDaMostrare}");
            }
            else
            {
                MostraConti(contiPerTipo);
            }
        }

        public static void EliminareConto()
        {
            //Conto contoDaEliminare = new Conto();
            //Console.WriteLine("Inserisci l'intestatario del conto da eliminare:");
            //string intestatario = Console.ReadLine();
            //contoDaEliminare = CercareConto(intestatario);
            //conti.Remove(contoDaEliminare);

            Console.WriteLine("Inserisci il numero di conto che vuoi eliminare");
            MostraConti();
            int numConto = 0;
            while (!(int.TryParse(Console.ReadLine(), out numConto) && numConto > 0 && numConto <= conti.Count))
            {
                Console.WriteLine("Hai inserito un numero non corretto");
            }
            Conto contoDaEliminare = conti.ElementAt(numConto - 1);
            conti.Remove(contoDaEliminare);
        }
        public static void MostraConti()
        {
            MostraConti(conti);
        }
        public static void MostraConti(List<Conto> conti)
        {
            if (conti.Count > 0)
            {
                int count = 1;
                foreach (Conto conto in conti)
                {
                    Console.WriteLine($"{count}-> Intestatario: {conto.Intestatario}, Saldo: {conto.Saldo}, Tipo conto: {conto.TipoDiConto}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("Nessun conto presente:");
            }
        }
        public static Conto CercareConto(string intestatario)
        {
            //provare ad aggiungere un ID ai conti in modo tale che se ci sono omonimi (o un utente vuole aprire più conti)
            //possiamo identificiarli
            List<Conto> contiTrovati = new List<Conto>();
            foreach (Conto conto in conti)
            {
                if (conto.Intestatario == intestatario)
                {

                    contiTrovati.Add(conto);
                }
            }
            if (contiTrovati.Count == 1)
            {
                return contiTrovati[0];
            }
            else if (contiTrovati.Count > 1)
            {
                Console.WriteLine("Ho trovato più conti con uguale intestatario");
                Console.WriteLine();
                StampaConto(contiTrovati);
                int numeroContoDaCercare = 0;
                Console.WriteLine("Inserire il numero di conto: ");
                while (!(int.TryParse(Console.ReadLine(), out numeroContoDaCercare) && numeroContoDaCercare > 0 && numeroContoDaCercare < 100))
                {
                    Console.WriteLine("Codice inserito non corretto. riprova:");
                }
                foreach (Conto conto in contiTrovati)
                {
                    if (conto.NumeroConto == numeroContoDaCercare)
                    {
                        return conto;
                    }
                }
                Console.WriteLine("Conto non trovato!");
                return null;
            }

            Console.WriteLine("Conto non trovato");
            return null;
        }

        private static void StampaConto(List<Conto> contiTrovati)
        {
            Console.WriteLine("Intestatario \t numero conto \t tipo conto \t saldo");
            foreach (Conto conto in contiTrovati)
            {
                Console.WriteLine($"{conto.Intestatario} \t\t {conto.NumeroConto} \t\t {conto.TipoDiConto}\t\t {conto.Saldo}");
            }
            Console.WriteLine();

        }
        private static void StampaConto()
        {
            StampaConto(conti);

        }


        private static double GestisciSaldo()
        {
            double saldo = 0;
            Console.WriteLine("Quanto denaro vuoi depositare nel conto?");
            while (!(double.TryParse(Console.ReadLine(), out saldo) && saldo >= 0))
            {
                Console.WriteLine("Hai inserito un valore non valido! Devi inserire un intero positivo:");
            }
            return saldo;
        }

        public static Tipologia GestisciTipoConto()
        {
            Console.WriteLine("Inserisci il tipo di conto da creare");
            Console.WriteLine($"Premi {(int)Tipologia.Corrente} per Conto {Tipologia.Corrente}");
            Console.WriteLine($"Premi {(int)Tipologia.Risparmio} per Conto {Tipologia.Risparmio}");
            int tipoDiConto = 2;
            while (!(int.TryParse(Console.ReadLine(), out tipoDiConto) && tipoDiConto >= 0 && tipoDiConto <= 1))
            {
                Console.WriteLine("Hai inserito un valore non corretto. \n Devi inserire un intero compreso tra 0 e 1. Riprova:");
            }
            return (Tipologia)tipoDiConto;
        }
    }
}
