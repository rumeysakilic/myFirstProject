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
            int hakSayisi = 3;
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
                    if(hakSayisi > 0)
                    {
                        hakSayisi--;
                        Console.WriteLine("Kalan hak sayınız:" +hakSayisi);
                    }  
                    if(hakSayisi == 0)
                    {
                        Console.WriteLine("Hak sayınız bitmiştir giriş yapamazsınız!!");
                        break;
                    }
                }

            }
        }
    }
}
