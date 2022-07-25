using System;

namespace Sumkm
{
    class Sumkm
    {
        static void Main(string[] args)
        {
            Console.Write("От 1 до (?): ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("От (?) до 100: ");
            int m = int.Parse(Console.ReadLine());

            int sum = 0;

            if (k > m)
            {
                Console.WriteLine("k > m \nПеременные автоматически поменяются местами");
                int temp = k;
                k = m;
                m = temp;
            }

            if (k < 1 || m > 100) Console.WriteLine("Недопустимые значения переменных");

            else
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i <= k || i >= m) sum += i;
                }

                Console.WriteLine("Сумма чисел от 1 до {0} и от {1} до 100 = {2}", k, m, sum);
            }
        }
    }
}
