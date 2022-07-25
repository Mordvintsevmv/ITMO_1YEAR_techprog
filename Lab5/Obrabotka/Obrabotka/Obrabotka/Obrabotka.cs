using System;

namespace Obrabotka
{
    class Obrabotka
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько чисел в массиве? : ");
            int n = int.Parse(Console.ReadLine());

            double[] Arr = new double[n];

            Console.WriteLine("Введите числа : ");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}] = ", i);
                Arr[i] = double.Parse(Console.ReadLine());
            }

            Menu();

            int ch;
            do
            {
                Console.Write("Ваш выбор : ");
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        {
                            Summa(n, Arr);
                            break;
                        }

                    case 2:
                        {
                            SrZnach(n, Arr);
                            break;
                        }

                    case 3:
                        {
                            ZnakSumma(n, Arr);
                            break;
                        }

                    case 4:
                        {
                            ChetSumma(n, Arr);
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("\nМаксимальный элемент массива Arr[{0}] = {1}", FindMax(n, Arr), Arr[(int)FindMax(n, Arr)]);
                            Console.WriteLine("Минимальный элемент массива Arr[{0}] = {1}\n", FindMin(n, Arr), Arr[(int)FindMin(n, Arr)]);

                            break;
                        }

                    case 6:
                        {
                            Proizv(n, Arr);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nВы ввели что-то не то!\n");
                            break;
                        }
                }
            }
            while (ch != 0);

        }

        private static void Proizv(int n, double[] Arr)
        {
            double pr = 1;
            for (int i = (int)FindMin(n, Arr) + 1; i < (int)FindMax(n, Arr); i++)
            {
                pr = pr * Arr[i];
            }
            Console.WriteLine("\nПроизведение между минимальным и максимальным  элементами = {0}\n", pr);
        }

        private static double FindMax(int n, double[] Arr)
        {
            double max = Double.MinValue;
            int maxn = -1;
            for (int i = 0; i < n; i++)
            {
                if (Arr[i] > max) { max = Arr[i]; maxn = i; }
            }
            return maxn;
        }

        private static double FindMin(int n, double[] Arr)
        {
            double min = Double.MaxValue;
            int minn = -1;
            for (int i = 0; i < n; i++)
            {
                if (Arr[i] < min) { min = Arr[i]; minn = i; }
            }
            return minn;
        }

        private static void ChetSumma(int n, double[] Arr)
        {
            double sumc = 0;
            double sumn = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) sumc += Arr[i];
                if (i % 2 != 0) sumn += Arr[i];
            }
            Console.WriteLine("\nСумма всех  чётных элементов = {0}", sumc);
            Console.WriteLine("\nСумма всех нечётных элементов = {0}\n", sumn);
        }

        private static void ZnakSumma(int n, double[] Arr)
        {
            double summ = 0;
            double sump = 0;
            for (int i = 0; i < n; i++)
            {
                if (Arr[i] < 0) summ += Arr[i];
                if (Arr[i] > 0) sump += Arr[i];
            }
            Console.WriteLine("\nСумма всех положительных элементов = {0}", sump);
            Console.WriteLine("\nСумма всех отрицательных элементов = {0}\n", summ);
        }

        private static void SrZnach(int n, double[] Arr)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Arr[i];
            }

            Console.WriteLine("\nСреднее значение массива = {0}\n", sum / n);
        }

        private static void Summa(int n, double[] Arr)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Arr[i];
            }
            Console.WriteLine("\nСумма всех элементов = {0}\n", sum);
        }

        private static void Menu()
        {
            Console.WriteLine("\n\nЧто вы хотите сделать с массивом?");
            Console.WriteLine("1 -  Вывод суммы элементов;");
            Console.WriteLine("2 -  Вывод среднего значения;");
            Console.WriteLine("3 -  Вывод суммы отрицательных и положительных;");
            Console.WriteLine("4 -  Вывод суммы нечётных и чётных элементов;");
            Console.WriteLine("5 -  Найти минимальный и максимальный элементы;");
            Console.WriteLine("6 -  Вывод произведения между минимальным и максимальынм;");
            Console.WriteLine("0 -  Закончить.\n");

        }
    }
}
