using System;
using System.Collections.Generic;

namespace Numeros
{
    class NumerosPares : IAuxNumerico
    {
        public static void Listar(List<int> n)
        {
            Console.WriteLine("#### NO. PARES ####");

            foreach (var item in n)
            {
                if (item % 2 == 0)
                {
                    Console.Write("{0}, ", item);
                }
            }

        }

        public void Listar() => throw new NotImplementedException();
    }
}
