using System;
namespace Triangle
{
    public class Operation
    {
        public static double Geron(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            if (Exist(a, b, c))
                return s;
            else
                return 0;
        }

        private static bool Exist(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a) return false;
            else return true;
        }

        public static double AS(double a) 
        {
            double p = (3 * a) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            return s;
        }

        public static double BS(int a)
        {
            double p = (3 * a) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - a) * (p - a));
            return s;
        }
    }
}
