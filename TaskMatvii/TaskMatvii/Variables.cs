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
            return 5 * a + b * b / (b - a);
        }
        public static void ReplacementOfValues(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static double[] DivisionAndRemainderDivision(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException(" b == 0  division by zero");
            }
            double division = a / b;
            double remainder = a % b;
            return new double[2] { division, remainder };
        }

        public static double SolvingLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a = 0 division by zero this is not an equation");
            }
            return (c - b) / a;
        }
        public static double[] MappinglineEquation(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException("x1 no == x2 . Division by zero");
            }
            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;
            return new double[2] { a, b };
        }
    }
}
