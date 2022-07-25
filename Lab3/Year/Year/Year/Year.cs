using System;

namespace Year
{
    class Year
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год : ");
            int year = int.Parse(Console.ReadLine());

            if (year < 0) Console.WriteLine("Год не может быьт отрицательным");
            else if (year % 400 == 0) Console.WriteLine("{0} -- високосный год!", year);
            else if ((year % 4 == 0) && (year % 100 != 0)) Console.WriteLine("{0} -- високосный год!", year);
            else Console.WriteLine("{0} -- не високосный год!", year);

        }
    }
}
