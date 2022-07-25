using System;

namespace Calc_switch
{
    class Calc_switch
    {
        static void Main(string[] args)
        {
            Console.Write("A = ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Действие (+ - * :/\\):");
            char OP = char.Parse(Console.ReadLine());

            Console.Write("B = ");
            double B = double.Parse(Console.ReadLine());

            bool ok = true;
            double res = 0;

            switch (OP)
            {
                case '+': res = A + B; break;
                case '-': res = A - B; break;
                case '*': res = A * B; break;
                case ':': 
                case '\\': 
                case '/': res = A / B; break;
                default: ok = false; break;
            }

            if (ok) Console.WriteLine("{0} {1} {2} = {3}", A, OP, B, res);
                else Console.WriteLine("Такой операции не существует ({0})",OP);
        }
    }
}
