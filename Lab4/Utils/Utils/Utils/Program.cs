using System;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.Write("Число x : ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Число y : ");
            y = int.Parse(Console.ReadLine());

            int greater = Utils.Greater(x, y);

            Console.WriteLine("Из чисел {0} и {1} большее {2}", x, y, greater);

            Console.WriteLine("До перемены : \nx : {0}\ny : {1}\n", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("После перемены : \nx : {0}\ny : {1}\n", x, y);

            int f;
            bool ok;
            Console.Write("Факториал числа ");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x,out f);

            if (ok)
                Console.WriteLine("Факториал числа {0} = {1}", x, f);
            else
                Console.WriteLine("Не удается посчитать факториал числа {0}", x);
        }
    }
}
