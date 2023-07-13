using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_Kitle_İndeksi_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beden Kitle İndeksini Hesaplama Programına Hoş Geldiniz!");
            Console.WriteLine("Kilonuzu Giriniz:");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu Giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());
            double beden_kitle_indeks = kilo / (boy * boy);
            Console.WriteLine("Beden Kitle İndeksiniz:" + beden_kitle_indeks);
            if(beden_kitle_indeks <= 18)
            {
                Console.WriteLine("Zayıfsınız!!");
            }
            else if(beden_kitle_indeks > 18 && beden_kitle_indeks <= 25)
            {
                Console.WriteLine("Normal");
            }
            else if(beden_kitle_indeks > 25)
            {
                Console.WriteLine("Obezitesiniz!!");
            }
        } 
    }
}
