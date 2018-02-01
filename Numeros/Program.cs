using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            List<int> ListaPopulada = new List<int>();

            while (i <= 100)
            {
                ListaPopulada.Add(i);
                i++;
            }

            NumerosPares.Listar(ListaPopulada);

            Console.WriteLine("\n");

            NumerosImpares.Listar(ListaPopulada);

            Console.ReadKey();
        }
    }
}
