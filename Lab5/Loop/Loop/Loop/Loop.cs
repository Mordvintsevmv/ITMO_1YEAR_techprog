using System;

namespace Loop
{
    class Loop
    {
        static void Main(string[] args)
        {

            int[] myArray;

            Console.Write("Сколько элементов будет в массиве: ");
            int i =  int.Parse(Console.ReadLine());
            myArray = new int[i];

            Console.WriteLine("Введите числа:");
            for(int s = 0; s< myArray.Length; s++)
            {
                Console.Write("myArray[{0}] = ", s);
                myArray[s] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Все числа в массиве:");
            foreach (int x in myArray) Console.Write("{0} ", x);


            Console.Write("\nДо какого числа вывести? : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n@@@ while @@@");
            i = 1;
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
