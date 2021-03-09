using System;

namespace TaskMatvii
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array = new int[3, 6];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 10);
                    Console.Write($"{array[i,j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();


            int[,] a = SecondArray.TransposeMatrix(array);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j <a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}  ");
                }
                Console.WriteLine();
            }
           
        }
    }
}
