using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example._0
{
    class Program
    {
        static void CiftSayı(string[] args)
        {
            Console.WriteLine("Bİr Yazı Yazdır");

            int sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı%2==0)
            {
                Console.WriteLine($"{sayı} sayı çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayı} tek sayıdır.");
            }
            Console.ReadKey();
        }
        static void Mutlak(string[] args)
        {
          

            int n = Convert.ToInt32(Console.ReadLine());
            if (n<0)
            {
                Console.WriteLine($"|{n}| = {n*-1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            var k = (char) Console.Read();
            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır!");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("Karakter Küçüktür");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("Karakter Büyüktür");
            }
            else
            {
                Console.WriteLine("Bilinmeyen.");

            }
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
