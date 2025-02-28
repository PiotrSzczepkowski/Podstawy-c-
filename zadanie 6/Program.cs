using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, suma, roznica, iloczyn, iloraz;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b =  Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            roznica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine($"{a} + {b} = {suma}");
            Console.WriteLine($"{a} - {b} = {roznica}");
            Console.WriteLine($"{a} * {b} = {iloczyn}");
            Console.WriteLine($"{a} / {b} = {iloraz}");
            Console.ReadKey(true);

        }   }
}
