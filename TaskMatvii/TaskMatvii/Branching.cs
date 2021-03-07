using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMatvii
{
    public class Branching
    {
        public static int CalculationProvided(int a, int b)
        {
            int c = 0;
            if (a > b)
            {
                c = a + b;
            }
            else if (a == b)
            {
                c = a * b;
            }
            else if (a < b)
            {
                c = a - b;
            }
            return c;
        }
        public static int DeterminingLocationPoint(int x, int y)
        {
            if (x == 0) { throw new Exception("point is on the x--axis"); }
            if (y == 0) { throw new Exception("point is on the y--axis"); }
            int c = 0;
            if (x > 0)
            {
                if (y > 0)
                {
                    c = 1;
                }
                else
                {
                    c = 2;
                }
            }
            else
            {
                if (y > 0)
                {
                    c = 4;
                }
                else
                {
                    c = 3;
                }
            }
            return c;
        }
        public static int[] SortingThreeElements(int a, int b, int c)
        {
            int temp = 0;
            if (a > b) { temp = a; a = b; b = temp; }
            if (a > c) { temp = a; a = c; c = temp; }
            if (b > c) { temp = b; b = c; c = temp; }
            return new int[3] { a, b, c };
        }
        public static int[] SortingThreeElementsBrancing(int a, int b, int c)
        {
            int[] array = new int[3];
            if (a > b && a > c)
            {
                if (b > c)
                {
                    array = new int[3] { c, b, a };
                }
                else
                {
                    array = new int[3] { b, c, a };
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        array = new int[3] { c, a, b };
                    }
                    else
                    {
                        array = new int[3] { a, c, b };
                    }

                }
                else
                {
                    if (a > b)
                    {
                        array = new int[3] { b, a, c };
                    }
                    else
                    {
                        array = new int[3] { a, b, c };
                    }

                }
            }
            return array;
        }
        public static double[] EquationSolution(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            double solution1 = 0;
            double solution2 = 0;
            if (D < 0) { throw new Exception("Descriminant  == 0"); }
            if (a == 0) { throw new Exception(" a == 0"); }
            else if (D == 0)
            {
                solution1 = -b / 2 * a;
                solution2 = solution1;
            }
            else
            {
                solution1 = (-b + Math.Sqrt(D)) / 2 * a;
                solution2 = (-b - Math.Sqrt(D)) / 2 * a;
            }
            return new double[2] { solution1, solution2 };
        }
        public static string NumberStamp(int a)
        {
            if (a < 9 && a > 99)
            {
                throw new ArgumentOutOfRangeException("Value out of range");
            }
            int c = a / 10;
            int b = a % 10;
            string str1 = "";
            string str2 = "";
            switch (c)
            {
                case 1:
                    switch (b)
                    {
                        case 0:
                            str1 = "Десять";
                            break;
                        case 1:
                            str1 = "Одинадцать";
                            break;
                        case 2:
                            str1 = "Двенадцять";
                            break;
                        case 3:
                            str1 = "Тринадцать";
                            break;
                        case 4:
                            str1 = "Четырнадцять";
                            break;
                        case 5:
                            str1 = "Пятнадцять";
                            break;
                        case 6:
                            str1 = "Шестнадцять";
                            break;
                        case 7:
                            str1 = "Семнадцять";
                            break;
                        case 8:
                            str1 = "Восемнадцять";
                            break;
                        case 9:
                            str1 = "Девятнадцать";
                            break;
                        default:
                            break;

                    }

                    break;
                case 2:
                    str1 = "Двадцять";
                    break;
                case 3:
                    str1 = "Тридцать";
                    break;
                case 4:
                    str1 = "Сорок";
                    break;
                case 5:
                    str1 = "Пятдесят";
                    break;
                case 6:
                    str1 = "Шестдесят";
                    break;
                case 7:
                    str1 = "Семдисят";
                    break;
                case 8:
                    str1 = "Восемдисят";
                    break;
                case 9:
                    str1 = "Девяносто";
                    break;
                default:
                    break;
            }
            if (c != 1)
            {
                switch (b)
                {
                    case 0:
                        str2 = " ";
                        break;
                    case 1:
                        str2 = "один";
                        break;
                    case 2:
                        str2 = "два";
                        break;
                    case 3:
                        str2 = "три";
                        break;
                    case 4:
                        str2 = "четыри";
                        break;
                    case 5:
                        str2 = "пять";
                        break;
                    case 6:
                        str2 = "шесть";
                        break;
                    case 7:
                        str2 = "семь";
                        break;
                    case 8:
                        str2 = "восемь";
                        break;
                    case 9:
                        str2 = "Девять";
                        break;
                    default:
                        break;
                }
            }
            return str1 + "  " + str2;
        }
    }
}
