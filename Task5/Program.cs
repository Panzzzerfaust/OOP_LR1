using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter multi dimensional array rows amount: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter multi dimensional array columns amount: ");
            int size2 = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[size1, size2];
            int[][] jagArr = new int[size1][];

            InitializeArray(ref arr, size1, size2);
            InitializeJaggedArray(ref jagArr, arr);

            PrintArray(arr);
            Console.WriteLine(new string('=', 20));
            PrintJaggedArray(jagArr);
            Console.ReadKey();
        }

        private static void PrintJaggedArray(int[][] jagArr)
        {
            for (int i = 0; i < jagArr.Length; i++)
            {
                for (int j = 0; j < jagArr[i].Length; j++)
                {
                    Console.Write(jagArr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void InitializeJaggedArray(ref int[][] jagArr, int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int count = 0, ind = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
                jagArr[i] = new int[count];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                    {
                        jagArr[i][ind++] = arr[i, j];
                    }
                }
            }
        }

        private static void InitializeArray(ref int[,] arr, int size1, int size2)
        {
            Random rnd = new Random();
            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    arr[i, j] = rnd.Next(-50, 50);
                }
            }
        }
    }
}
