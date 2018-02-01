using System;
using System.Collections.Generic;

namespace Numeros
{
    class NumerosImpares : IAuxNumerico
    {
        public static void Listar(List<int> n)
        {
            Console.WriteLine("#### NO. ÍMPARES ####");

            foreach (var item in n)
            {
                if (item % 2 != 0)
                {
                    Console.Write("{0}, ", item);
                }
            }

        }
        public void Listar()
        {
            throw new NotImplementedException();
        }
    }
}
