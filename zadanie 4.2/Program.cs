using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace zadanie_4._2
{
    class Program
    {  //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej największej z tych liczb
        static void Main(string[] args)
        {
            int a, b, c, d, e, min, max;
            Console.WriteLine("Podaj liczbe a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe d: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe e: ");
            e = Convert.ToInt32(Console.ReadLine());
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza", min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba {0} jest najwieksza", max);
            Console.ReadKey(true);
        }
    }
}
