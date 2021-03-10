using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMatvii
{
    public class SecondArray
    {
        public static int MinElementsSecondArrays(int[,] array)
        {
            int min = 0;
            min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
        public static int MaxElementsSecondArrays(int[,] array)
        {
            int max;
            max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        public static int[] IndexMinElementsSecondArrays(int[,] array)
        {
            int min;
            int indexi = 0;
            int indexj = 0;
            min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        indexi = i;
                        indexj = j;
                    }
                }
            }
            return new int[2] { indexi, indexj };
        }
        public static int[] IndexMaxElementsSecondArrays(int[,] array)
        {
            int max;
            int indexi = 0;
            int indexj = 0;
            max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        indexi = i;
                        indexj = j;
                    }
                }
            }
            return new int[2] { indexi, indexj };
        }
        public static int[,] TransposeMatrix(int[,] array)
        {
            int[,] tarray = new int[array.GetLength(1), array.GetLength(0)];
            for (int i = 0; i < tarray.GetLength(1); i++)
            {
                for (int j = 0; j < tarray.GetLength(0); j++)
                {
                    tarray[j, i] = array[i, j];
                }
            }
            return tarray;
        }
        public static int FindingNumberMaxElementsSecond(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    bool elementmax = true;
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
                                    elementmax = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (elementmax)
                    {
                        count++;
                   }

                }

            }
            return count;
        }
    }
}
