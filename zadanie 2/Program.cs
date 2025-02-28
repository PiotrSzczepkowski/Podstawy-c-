using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    { //Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero.
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbe calkowita: ");
         a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba {0} jest dodatnia");
            else if (a < 0) 
            Console.WriteLine("Liczbna {0} jest ujemna");
            else
                Console.WriteLine("Liczba {0} jest równa 0");
            Console.ReadKey(true);
            
        }
    }
}
