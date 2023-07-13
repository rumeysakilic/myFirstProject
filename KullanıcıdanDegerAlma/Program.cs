using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcıdanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Adınızı giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz:");
            string soyad = Console.ReadLine();
            Console.WriteLine("KULLANICI ADI =" +ad);
            Console.WriteLine("KULLANICI SOYADI:" +soyad);
            Console.ReadLine();*/
            Console.WriteLine("Birinci değeri giriniz: ");
            string sayi1 = Console.ReadLine();
            Console.WriteLine("İkinci deeğeri giriniz: ");
            string sayi2 = Console.ReadLine();
            Console.WriteLine("Girilen iki değerin toplamı = " +(Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2)));
            Console.ReadLine();

        }
    }
}
