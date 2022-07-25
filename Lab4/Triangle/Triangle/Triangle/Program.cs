using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип треугольника:\n1 - разносторонний;\n2 - равносторонний.\n\n");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case '1':
                    {
                        Console.WriteLine("Введите три стороны треугольника:");
                        Console.Write("a - ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("b - ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("c - ");
                        double c = double.Parse(Console.ReadLine());

                        if (Operation.Geron(a, b, c) == 0)
                            Console.WriteLine("\n\nДанного треугольника не существует");
                        else
                            Console.WriteLine("\n\nПлощадь данного треугольника: {0}", Operation.Geron(a, b, c));
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine("Введите три стороны треугольника:");
                        Console.Write("a - ");
                        double a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Площадь данного треугольника = {0}", Operation.AS(a));
                        break;
                    }

            }
        }
    }
}
