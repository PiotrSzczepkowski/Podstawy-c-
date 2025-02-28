using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, l,v, Pc;
            Console.Write("Podaj r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj h=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            v = 1 / 3 * Math.PI * r * r *h;
            Pc = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("v={0}", v);
            Console.WriteLine("Pc={0}", Pc);
            Console.ReadKey(true); //pauza
        }
    }
}
