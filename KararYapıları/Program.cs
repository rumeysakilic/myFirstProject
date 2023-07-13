using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınav Notunuzu Giriniz:");
            string sinav = Console.ReadLine();
            if (Convert.ToInt32(sinav)<50)
            {
                Console.WriteLine("Sonucunuz : BAŞARISIZ");
            }
            else
            {
                Console.WriteLine("Sonucunuz : BAŞARILI");
            }
        }
    }
}
