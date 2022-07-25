using System;

namespace Shapeifelse
{
    class Shapeifelse
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());

            if ((x * x + y * y < 9) && (y > 0))
                Console.WriteLine("Точка находится внутри!");
            else if ((x * x + y * y > 9) || (y < 0))
                Console.WriteLine("Точка находится снаружи!");
            else Console.WriteLine("Точка находится на границе!");
        }      
    }
}
