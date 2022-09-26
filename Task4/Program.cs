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
            QuadraticEquation quadraticEquation = new QuadraticEquation(2, 5, 3);
            quadraticEquation.Solve();
            Console.WriteLine($"x1 = {quadraticEquation[0]}\nx2 = {quadraticEquation[1]}");
            Console.ReadKey();
        }
    }
}
