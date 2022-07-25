using System;

namespace KvadrUr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициенты уравнения: \na - ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b - ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c - ");
            double c = double.Parse(Console.ReadLine());


            double x1 = 0, x2 = 0;

            if (Vichislenie.Korni(a, b, c, ref x1, ref x2) == -1)
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.",a,b,c);
            else if (Vichislenie.Korni(a, b, c, ref x1, ref x2) == 0)
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны один x1 = x2 = {3}.",a,b,c,x1);
            else if (Vichislenie.Korni(a, b, c, ref x1, ref x2) == 1)
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны x1 = {3}, x2 = {4}.",a,b,c,x1,x2);



        }
    }
}
