using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen istediğiniz işlemi seçiniz:");
            Console.WriteLine("1-Giriş");
            Console.WriteLine("2-Para Çekme");
            Console.WriteLine("3-Para Yatırma");
            Console.WriteLine("4-Çıkış");
            string secim = Console.ReadLine();
            switch(secim)
            {
                case "1":
                    Console.WriteLine("Bankamıza hoş geldiniz, Giriş yaptınız...");
                    break;
                case "2":
                    Console.WriteLine("Ne kadar para çekmek istiyorunuz?");
                    break;
                case "3":
                    Console.WriteLine("Ne kadar para yatırma istiyorunuz?");
                    break;
                case "4":
                    Console.WriteLine("Çıkış yapıyorsunuz. İyi günler!!!");
                    break;
                default: Console.WriteLine("Geçersiz giriş yaptınız!!");
                    break;
            }
        }
    }
}
