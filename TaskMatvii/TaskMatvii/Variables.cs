using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMatvii
{
    public class Variables
    {
        public static int SolvingEquations(int a, int b)
        {
            if (a == b)
            {
                throw new DivideByZeroException("a no == b  division by zero");
            }
            return (5 * a + b * b) / (b - a);
        }
        public static void ReplacementOfValues(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static int[] DivisionAndRemainderDivision(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException(" b == 0  division by zero");
            }
            int division = a / b;
            int remainder = a % b;
            return new int[2] { division, remainder };
        }
        public static int SolvingLinearEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new Exception("a = 0 division by zero this is not an equation");
            }
            return (c - b) / a;
        }
        public static int[] MappinglineEquation(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException("x1 no == x2 . Division by zero");
            }
            int a = (y2 - y1) / (x2 - x1);
            int b = y1 - a * x1;
            return new int[2] { a, b };
        }
    }
}
