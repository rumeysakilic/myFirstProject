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
            double bedenKitleIndeks = kilo / (boy * boy);
            Console.WriteLine("Beden Kitle İndeksiniz:" + bedenKitleIndeks);
            if(bedenKitleIndeks <= 18)
            {
                Console.WriteLine("Zayıfsınız!!");
            }
            else if(bedenKitleIndeks > 18 && bedenKitleIndeks <= 25)
            {
                Console.WriteLine("Normal");
            }
            else if(bedenKitleIndeks > 25)
            {
                Console.WriteLine("Obezitesiniz!!");
            }
        } 
    }
}
