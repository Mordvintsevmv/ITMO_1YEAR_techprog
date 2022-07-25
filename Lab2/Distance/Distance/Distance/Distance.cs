using System;

namespace Distance
{

    public struct Dist 
    {
        public int feet;
        public int inch;  
    }

    class Distance
    {
        static void Main(string[] args)
        {
            Dist a;
            Dist b;
            Dist c;

            Console.WriteLine("@@@ Переменная a @@@");
            Console.Write("Футы: ");
            a.feet = int.Parse(Console.ReadLine());
            Console.Write("Дюймы: ");
            a.inch = int.Parse(Console.ReadLine());
            a.feet += (int)(a.inch / 12);
            a.inch = (a.inch % 12);

            Console.WriteLine("\n\n@@@ Переменная b @@@");
            Console.Write("Футы: ");
            b.feet = int.Parse(Console.ReadLine());
            Console.Write("Дюймы: ");
            b.inch = int.Parse(Console.ReadLine());
            b.feet += (int)(b.inch / 12);
            b.inch = (b.inch % 12);

            c.feet = a.feet + b.feet;
            c.inch = a.inch + b.inch;
            c.feet += (int)(c.inch / 12);
            c.inch = (c.inch % 12);

            Console.WriteLine("\n\na = {0}\'-{1}\"", a.feet, a.inch);
            Console.WriteLine("b = {0}\'-{1}\"", b.feet, b.inch);
            Console.WriteLine("a + b = c = {0}\'-{1}\"", c.feet, c.inch);
        }
    }
}
