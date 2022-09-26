using System;

namespace Task2
{
    class Program
    {
        static double? Sqrt(double x, out int error) {
            if (x >= 0) {
                error = 0;
                if (x == 0 || x == 1)
                    return x;
                double approach = 1, sqrt = x, accuracy = 0.001;
                while (Math.Abs(sqrt - approach) > accuracy)
                {
                    approach = sqrt;
                    sqrt = (x / approach + approach) / 2;
                }
                return Math.Round(sqrt, CountAccuracy(accuracy));
            }
            error = -1;
            return null;
        }

        private static int CountAccuracy(double acc)
        {
            int length = acc.ToString().Substring(acc.ToString().IndexOf(",")+1).Length;
            return length;
        }

        static void Main(string[] args)
        {
            int num;
            double? x = Sqrt(0.0009, out num);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
