using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1071, num2 = 1029;
            Console.WriteLine($"{num1}  {num2}");
            static void GCD(ref int a, ref int b)
            {
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else
                        b -= a;
                }
            }
            GCD(ref num1, ref num2);
            Console.WriteLine($"{num1}  {num2}");
            Console.ReadKey();
        }
    }
}
