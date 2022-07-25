using System;

namespace Sin
{
    class Sin
    {
        static void Main(string[] args)
        {
            double x, x1, x2, y;

            Console.Write("Введите границы:\nx1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());

            if (x2 < x1)
            {
                double t = x1;
                x1 = x2;
                x2 = t;
            }

            Console.WriteLine("sin(x) \ty");
            x = x1;
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("sin({0}) \t{1}", x, y);
                x = x + 0.01;
            }
            while (x < x2);

            Console.WriteLine("\n\nsin(x) \ty");
            x = x1;
            while (x < x2)
            {
                y = Math.Sin(x);
                Console.WriteLine("sin({0}) \t{1}", x, y);
                x = x + 0.01; 
                }
        }
    }
}
