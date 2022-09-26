using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 5, c = 3;
            QuadraticEquation quadraticEquation = new QuadraticEquation(a, b, c);
            quadraticEquation.Solve();
            Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
            Console.WriteLine($"x1 = {quadraticEquation[0]}\nx2 = {quadraticEquation[1]}");
            Console.ReadKey();
        }
    }
}
