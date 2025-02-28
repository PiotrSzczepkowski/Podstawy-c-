using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {  //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb.
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj liczbe a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbe c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && b > c)
                Console.WriteLine("Liczba Najwieksza to a, Liczba najmniejsza to c");
            else if (b > a && a > c)
                Console.WriteLine("Liczba Najwieksza to b, Liczba najmniejsza to c");
            else if(c > a && a > b)
                Console.WriteLine("Liczba Najwieksza to c, Liczba najmniejsza to b");
            else if(c > b && b > a)
                Console.WriteLine("Liczba Najwieksza to c, Liczba najmniejsza to a");
            else if (a > c && c > b)
                Console.WriteLine("Liczba Najwieksza to a, Liczba najmniejsza to b");
        else 
            Console.WriteLine("Liczba Najwieksza to b, Liczba najmniejsza to a");
            Console.ReadKey(true);
        }
    }
}
