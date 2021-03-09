using System;

namespace TaskMatvii
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 10);
                }
            }
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool isindex = true;
                    for (int di = -1; di <= 1; di++)
                    {
                        for (int dj = -1; dj <= 1; dj++)
                        {
                            if ((i + di) >= 0 && (i + di) < array.GetLength(0) && (j + dj) >= 0 && (j + dj) < array.GetLength(1) && !(di == 0 && dj == 0))
                            {
                                if (array[i, j] > array[i + di, j + dj])
                                {

                                }
                                else
                                {
                                    isindex = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (isindex)
                    {
                        count++;
                        Console.WriteLine(array[i,j]);
                    }

                }
               
            }

            Console.WriteLine(count);
        }
    }
}
