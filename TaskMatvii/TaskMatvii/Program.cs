using System;

namespace TaskMatvii
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] a = Cycles.PrintNumbersSumEvenDigitsSumOddOnes(50);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($" {a[i]} ");
            }

        }
    }
}
