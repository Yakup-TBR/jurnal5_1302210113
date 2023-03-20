using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_1302210113
{
    public class Penjumlahan<T>
    {
        public static void PenjumlahanTigaAngka(T A, T B, T C)
        {

            dynamic a = A;
            dynamic b = B;
            dynamic c = C;

          

            double total = a + b + c;

            System.Console.WriteLine(total);

        } 
    }
}
