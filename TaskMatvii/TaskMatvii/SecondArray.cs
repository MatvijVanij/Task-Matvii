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
        public static int[,] DisplayMirrorArray(int[,] array)
        {
            int temp;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i != j)
                    {
                        temp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return array;
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
        public static int FindingNumberMaxElementsWorking(int[,] array)
        {
            int[,] tarray = new int[array.GetLength(0) + 2, array.GetLength(1) + 2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    tarray[i + 1, j + 1] = array[i, j];
                }
            }
            int count = 0;
            for (int i = 1; i < tarray.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < tarray.GetLength(1) - 1; j++)
                {
                    if (tarray[i, j] > tarray[i, j + 1]
                     && tarray[i, j] > tarray[i, j - 1]
                     && tarray[i, j] > tarray[i + 1, j]
                     && tarray[i, j] > tarray[i - 1, j])
                    {
                        ++count;
                    }
                }
            }
            return count;
        }
        public static bool FindingNumberMaxElements(int[,] array, int i, int j)
        {
            int currenty = i > 0 ? -1 : 0;
            int targety = i < array.GetLength(0) - 1 ? 1 : 0;
            for (int dy = currenty; dy < targety; dy++)
            {
                int currentx = j > 0 ? -1 : 0;
                int targetx = j > array.GetLength(1) ? 1 : 0;
                for (int dx = currentx; dx < targetx; dx++)
                {
                    if (i != i + dy && j != j + dx)
                    {
                        if (array[i, j] <= array[i + dy, j + dx])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
