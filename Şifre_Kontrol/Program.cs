using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şifre_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak_sayisi = 3;
            while(true)
            {
                Console.WriteLine("Kullanıcı adını giriniz:");
                string kullanici_adi = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz:");
                string sifre = Console.ReadLine();
                if(kullanici_adi == "Rumeysa" && sifre == "2023")
                {
                    Console.WriteLine("Giriş başarılı!! :)");
                    break;
                }
                else
                {
                    if(hak_sayisi > 0)
                    {
                        hak_sayisi--;
                        Console.WriteLine("Kalan hak sayınız:" +  hak_sayisi);
                    }  
                    if(hak_sayisi == 0)
                    {
                        Console.WriteLine("Hak sayınız bitmiştir giriş yapamazsınız!!");
                        break;
                    }
                }

            }
        }
    }
}
