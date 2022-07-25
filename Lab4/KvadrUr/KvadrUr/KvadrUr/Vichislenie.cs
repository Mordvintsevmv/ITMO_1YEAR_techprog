using System;
namespace KvadrUr
{
    public class Vichislenie
    {
        public static int Korni(double a, double b, double c, ref double x1, ref double x2)
        {
            double D = b * b - 4 * a * c;
            if (D < 0)
                return -1;
            else if (D == 0)
            {
                x1 = x2 = (-b / (2 * a));
                return 0;
            }
            else
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                return 1;
            }
        }
    }
}
