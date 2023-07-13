using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDöngüÖrnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1'den 10'a kadar sayıları ekrana yazdır.
            //100'den 0'a kadar çift sayıları büyükten küçüğe ekrana yazdır.
           /* int sayi = 1;
             while (sayi <= 10) 
                {
                    Console.WriteLine(sayi);
                    sayi++;
                } */

            int sayi1 = 100;
            while (sayi1 >= 0) 
            {
                   Console.WriteLine(sayi1);
                   sayi1 = sayi1-2;       //a-=2
            }






        }
    }
}
