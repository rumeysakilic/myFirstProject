using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte birinci = 0;
            byte ikinci = 255;
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);

            byte maxDeger = byte.MaxValue;
            Console.WriteLine(maxDeger);
            byte minDeger = byte.MinValue;
            Console.WriteLine(minDeger);
            int max_deger = int.MaxValue;
            Console.WriteLine(max_deger);
            int min_Deger = int.MinValue;
            Console.WriteLine(min_Deger);
            Console.ReadLine();
        }
    }
}
