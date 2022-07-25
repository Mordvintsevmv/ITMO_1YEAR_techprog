using System;
namespace triangle
{
    public class triangle
    {
        public double A;
        public double B;
        public double C;

        public triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public void Print()
        {
            Console.WriteLine("\n@@@Стороны треугольника:@@@ \nA: {0}, \nB: {1}, \nC: {2}.", A, B, C);
            if (A > B + C) Console.WriteLine("\nТакого треугольника не существует");
            else if (B > A + C) Console.WriteLine("\nТакого треугольника не существует");
            else if (C > B + A) Console.WriteLine("\nТакого треугольника не существует");
            else Console.WriteLine("\nТакой треугольник существует");

        }

        public double Perimetr()
        {
            return A + B + C;
        }

        public double Ploshad()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
