using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonucYazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sınav Notunuzu Giriniz:");
            string sinav1 = Console.ReadLine();
            Console.WriteLine("2. Sınav Notunuzu Giriniz:");
            string sinav2 = Console.ReadLine();
            Console.WriteLine("3. Sınav Notunuzu Giriniz:");
            string sinav3 = Console.ReadLine();
            int ortalama = (Convert.ToInt32(sinav1) + Convert.ToInt32(sinav2) + Convert.ToInt32(sinav3)) / 3;
            Console.WriteLine("Ortalamanız: " + ortalama);
            if (ortalama>80 && ortalama<=100)
            {
                Console.WriteLine("A+");
            }
            else if (ortalama < 80 && ortalama > 60)
            {
                Console.WriteLine("A");
            }
            else if(ortalama < 60 && ortalama > 40)
            {
                Console.WriteLine("B+");
            }
            else if(ortalama < 40)
            {
                Console.WriteLine("F");
            }
        }
    }
}
