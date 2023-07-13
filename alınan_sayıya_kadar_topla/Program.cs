using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alınan_sayıya_kadar_topla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= sayi; i++)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);
            double ortalama = toplam/ sayi;
            Console.WriteLine(ortalama);
            if(ortalama > 50)
            {
                Console.WriteLine("Ortalama 50' den büyük");
            }
            else
            {
                Console.WriteLine("Ortalama 50'den küçük");
            }
        }
    }
}
