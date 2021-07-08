using System;

namespace RipassoDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(); // così mi restituisce il primo gennaio dell'anno 1

            DateTime dt2 = new DateTime(2021,07,05); // non avendogli passato ore, minuti, secondi lo setta a mezzanotte

            DateTime dt3 = DateTime.Now; // data di oggi con orario

            DateTime dt4 = dt3.Date; //cancella l'orario

            if (dt2.Date > dt4) //dateTime è ordinabile
            { }

            DateTime dt5=DateTime.Parse("06/07/2021"); 
            DateTime dt6 = DateTime.Parse("06-07-2021");
            DateTime dt7 = DateTime.Parse("06 07 2021");

            //Modo non valido di scrivere una data
            // DateTime dt7 = DateTime.Parse("2021 07 06");
            // DateTime dt7 = DateTime.Parse("06072021");

            //Console.WriteLine("Inserisci una data");
            //bool isDate = true;
            //DateTime dataInserita;
            //do
            //{
            //    isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);
            //} while (!isDate);

            Console.WriteLine("Inserisci una data antecedente alla data di inserimento");
            bool isDate = true;
            DateTime dataInserita;
            do
            {
                isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);
                if(dataInserita<DateTime.Now.Date)
                {


                }
            } while (!isDate||dataInserita>DateTime.Now.Date);

            var anno = DateTime.Now.Year;
            int mese = dt3.Month;
            int giorno = dt6.Day;

            var dt8= dt3.AddDays(30); //posso aggiungere giorni, mesi o anni ad una data

            //var dt9= dt3.Ticks;
            


        }
    }
}
