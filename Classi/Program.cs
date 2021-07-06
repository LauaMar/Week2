using System;

namespace Classi
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Laura", "Martines");
            p.CodiceFiscale = "MRTLRA...."; //altro modo di settare proprietà (se non richiamate nel costruttore)

            string nome = p.Nome; //posso estrarre così una proprietà dall'oggetto
            string dati = p.OttieniDati();
            Console.WriteLine(dati);
        }
    }
}
