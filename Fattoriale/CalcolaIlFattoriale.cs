using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoriale
{
    class CalcolaIlFattoriale
    {
        internal static void Start()
        {
            int numeroDaCalcolare = 0;

            FattorialeIterazione(5); // 3 variabili

            FattorialeRicorsione(5);  // apre ogni volta un nuovo metodo che opera in parallelo ai precedenti; solo quando li ha
                                      // aoerti tutti (occupazione di memoria massima) inizia a richiuderli (passa dai return) e 
                                      //quindi libera memoria

        }

        private static int FattorialeRicorsione(int numero)
        {
            /* deve fare una roba tipo 
             * 5*(5-1)
             * poi 4*(4-1)
             * e così via */

            var totale = 1;
            Console.WriteLine($"Il valore di calcolare il fattoriale è {numero}");
            if (numero > 1)
            {
                totale = numero * FattorialeRicorsione(numero - 1);
                Console.WriteLine($"Il fattoriale di {numero} è {totale}");
            }
            return totale;
        }

        private static void FattorialeIterazione(int numero)
        {
            Console.WriteLine("sto calcolando con l'iterazione");
            var totale = 1;
            for (var i = numero; i>0; i--)
            {
                Console.WriteLine($"Il valore di i è {i}");
                totale = totale* i;
                Console.WriteLine($"Il totale provvisorio è {totale}");
            }
            Console.WriteLine($"Il fattoriale di {numero} è {totale}");
        }
    }
}
