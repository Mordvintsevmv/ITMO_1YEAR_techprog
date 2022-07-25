using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            triangle t1 = new triangle(3, 4, 5);
            t1.Print();
            Console.WriteLine("\nПериметр треугольника = {0}", t1.Perimetr());
            Console.WriteLine("\nПлощадь треугольника = {0}", t1.Ploshad());

            triangle t2 = new triangle(10, 20, 1);
            t2.Print();
        }
    }
}
