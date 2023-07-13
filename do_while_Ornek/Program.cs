using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1'den 10'a kadar sayıları do while ile yazdır.
            //1'den 100'e kadar sayıların toplamını do while ile yazdır
            /*int sayi = 1;
            do
            {
               Console.WriteLine(sayi);
                sayi++; 
            } while (sayi<=10); */
            int sayi1 = 1;
            int toplam = 0;
            do
            {
                toplam += sayi1;
                
                sayi1++;
                
            } while (sayi1 <= 100);
            Console.WriteLine(toplam);
        }
    }
}
