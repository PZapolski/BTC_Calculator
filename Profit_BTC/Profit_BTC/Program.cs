using System;

namespace btc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            Console.WriteLine("Kurs zakupu:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kurs sprzedaży:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ile wkładu?");
            c = Convert.ToDouble(Console.ReadLine());
            d = ((c / a) * b) - c;
            e = ((b / a) * 100) + (-100);
            Console.WriteLine("Zyska USD: " + d + " USD");
            Console.WriteLine("Zysk %: " + e + " %");
            Console.ReadKey();
        }
    }
}
