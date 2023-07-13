using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("Hangi işlemi yapmak istiyorsunuz? ");
            Console.WriteLine("----Menü---- ");
            Console.WriteLine("1-Bakiye Görüntüleme");
            Console.WriteLine("2-Para Çekme");
            Console.WriteLine("3-Para Yatırma");
            Console.WriteLine("q-Çıkış");
            string cevap = Console.ReadLine();
            if (cevap == "1")
            {
                Console.WriteLine("Bakiye Görüntüleme Ekranı");
                Console.WriteLine("Bakiyeniz:" + bakiye);
            }
            else if (cevap == "2")
            {
                Console.WriteLine("Para Çekme Ekranı");
                Console.WriteLine("Çekmek istediğiniz tutar :");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if(cekilecek_tutar <= bakiye)
                { 
                    Console.WriteLine("Paranız Çekilmiştir.Güncel Bakiyeniz: " +(bakiye-cekilecek_tutar));
                }
                else
                {
                    Console.WriteLine("Yetersiz Bakiye!!");
                }
               
            }
            else if (cevap == "3")
            {
                Console.WriteLine("Para Yatırma Ekranı");
                Console.WriteLine("Yatırmak istediğiniz tutar:");
                int yatıralacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Güncel Bakiyeniz: " + (bakiye + yatıralacak_tutar));
            }
            else if (cevap == "q") 
            {
                Console.WriteLine("Çıkış Yapıyorsunuz");
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Değer Giriniz!");
            }
        }
    }
}
