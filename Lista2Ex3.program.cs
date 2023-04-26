using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Comparação entre 3 números:");
            Console.Write("Digite o valor do primeiro N°:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do segundo N°:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do terceiro N°:");
            c = double.Parse(Console.ReadLine());


            if (a >= b && a >= c) { Console.WriteLine($"O número {a} é maior."); }
            if (b >= a && b >= c) { Console.WriteLine($"O número {b} é maior."); }
            if (c >= a && c >= b) { Console.WriteLine($"O número {c} é maior."); }
        }
    }
}
