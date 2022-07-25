using System;

namespace Evklid
{
    class Evklid
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            int a1, b1, temp1;

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            a1 = a;

            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            b1 = b;

            temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }

            Console.Write("НОД = {0}", a);

            temp1 = a1;
            do
            {
                a1 = temp1;
                if (a1 < b1)
                {
                    temp1 = a1;
                    a1 = b1;
                    b1 = temp1;
                }
                temp1 = a1 - b1;
                a1 = b1;
            }
            while (temp1 != b1);

            Console.Write("НОД = {0}", a1);

        }
    }
}
