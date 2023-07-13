using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetikİslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 25;
            int sayi2 = 45;
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            sayi1--;
            Console.WriteLine(sayi1);
            bool kontrol_et = sayi1 != sayi2;
            Console.WriteLine(kontrol_et); 
            Console.ReadLine();
        }
    }
}
