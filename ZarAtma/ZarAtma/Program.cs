using System;
using System.Threading;


namespace ZarAtma
{
    class Program
    {
        static void Main(string[] args)
        {
            int KacKere = 0;
            int ZarSayi1;
            int ZarSay2;
            Console.Write("Zar Kaç Kere Atılacak = ");
            KacKere = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int i = 0;
            for (i = 1; i <= KacKere; i++)
            {
                ZarSayi1 = random.Next(1, 6);
                ZarSay2 = random.Next(1, 6);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Zar Atılıyor");
                Thread.Sleep(1500);
                Console.WriteLine(i + ".Sayı = " + ZarSayi1);


            }
            Console.ReadKey();
        }
    }
}
