using System;

namespace Loop
{
    class Loop
    {
        static void Main(string[] args)
        {
            Console.Write("До какого числа вывести? : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n@@@ while @@@");
            int i = 1;
            while (i <= n)
            {
                Console.Write(i + " ");
                i += 2;
            }

            Console.WriteLine("\n\n@@@ do-while @@@");
            i = 1;
            do
            {
                Console.Write(i + " ");
                i += 2;
            }
            while (i <= n);

            Console.WriteLine("\n\n@@@ for @@@");
            for (i = 1; i<=n; i += 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
