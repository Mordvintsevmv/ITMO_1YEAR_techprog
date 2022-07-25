using System;

namespace Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression ap = new ArithmeticProgression(9, 13);
            GeometricProgression gp = new GeometricProgression(5, 7);
            Console.Write("Какой элемент вывести?: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Этот элемент в арифметичской прогрессии: {0}\nЭтот" +
            	" элемент в геометрической прогрессии: {1}", ap.GetElement(n), gp.GetElement(n));
        }
    }
}
