using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Введите периметр равностороннего треугольника: ");
                double p = double.Parse(Console.ReadLine()) / 2;
                if (p == 0) throw new Exception("Вы ввели нулевой периметр");
                if (p < 0) throw new Exception("Вы ввели отрицательный периметр");

                double s = Math.Sqrt(p * Math.Pow(p - p * 2 / 3, 3));

                Console.WriteLine("\n\nСторона  Площадь");
                Console.WriteLine("{0} \t  {1}", Math.Round(p * 2 / 3, 2), Math.Round(s, 2));
                Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine("Вы ввели буквы, а не число!");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
