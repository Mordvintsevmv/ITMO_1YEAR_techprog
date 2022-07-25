
using System;

namespace Bow
{
    class Bow
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько выстрелов вы будете делать?: ");
            int n = int.Parse(Console.ReadLine());
            double x;
            double y;
            int sum = 0;

            Console.Write("\n\n\t@@@@@\nВыберите режим игры: ");
            Console.Write("\n1 - Классический; ");
            Console.Write("\n2 - Случайный центр; ");
            Console.Write("\n3 - Стрельба с помехой. ");
            Console.Write("\n\nВаш выбор: ");
            char c = char.Parse(Console.ReadLine());
            Console.Write("\t@@@@@");

            double[] xm = new double[n];
            double[] ym = new double[n];
            int[] sm = new int[n];

            switch (c)
            {
                case '1':
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Ваш выстрел\nx : ");
                            x = double.Parse(Console.ReadLine());
                            Console.Write("y : ");
                            y = double.Parse(Console.ReadLine());
                            xm[i] = x;
                            ym[i] = y;

                            if (x * x + y * y <= 1) sm[i] = 10;
                            else if (x * x + y * y <= 4) sm[i] = 5;
                            else if (x * x + y * y <= 9) sm[i] = 1;
                            else if (x * x + y * y > 9) sm[i] = 0;
                            sum += sm[i];
                        }
                        break;
                    }
                case '2':
                    {
                        Random rnd = new Random();
                        int xc = rnd.Next(-3, 3);
                        int yc = rnd.Next(-3, 3);

                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Ваш выстрел\nx : ");
                            x = double.Parse(Console.ReadLine());
                            Console.Write("y : ");
                            y = double.Parse(Console.ReadLine());
                            xm[i] = x;
                            ym[i] = y;

                            if ((x-xc) * (x-xc) + (y-yc) * (y-yc) <= 1) sm[i] = 10;
                            else if ((x - xc) * (x - xc) + (y - yc) * (y - yc) <= 4) sm[i] = 5;
                            else if ((x - xc) * (x - xc) + (y - yc) * (y - yc) <= 9) sm[i] = 1;
                            else if ((x - xc) * (x - xc) + (y - yc) * (y - yc) > 9) sm[i] = 0;
                            sum += sm[i];
                        }
                        Console.WriteLine("Центр был в точке ({0},{1})", xc, yc);
                        break;
                    }
                case '3':
                    {
                        Random rnd = new Random();
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Ваш выстрел\nx : ");
                            x = double.Parse(Console.ReadLine()) + rnd.Next(-3,3);
                            Console.Write("y : ");
                            y = double.Parse(Console.ReadLine()) + rnd.Next(-3, 3);
                            xm[i] = x;
                            ym[i] = y;

                            if (x * x + y * y <= 1) sm[i] = 10;
                            else if (x * x + y * y <= 4) sm[i] = 5;
                            else if (x * x + y * y <= 9) sm[i] = 1;
                            else if (x * x + y * y > 9) sm[i] = 0;
                            sum += sm[i];
                        }
                        break;
                    }
                default: Console.WriteLine("Вы ввели что-то неверное."); break;




            }

            Console.WriteLine("\n\n@@@Ваши выстрелы@@@\n");


            for (int i = 0; i < n; i++)
            {
                Console.Write("\t{0}",i);
            }

            Console.WriteLine("\nx");

            for (int i = 0; i < n; i++)
            {
                Console.Write("\t{0}", xm[i]);
            }

            Console.WriteLine("\ny");

            for (int i = 0; i < n; i++)
            {
                Console.Write("\t{0}", ym[i]);
            }

            Console.WriteLine("\ns");

            for (int i = 0; i < n; i++)
            {
                Console.Write("\t{0}", sm[i]);
            }

            Console.WriteLine("\n@@@@@\nИтог : {0}", sum);
        }
    }
}
