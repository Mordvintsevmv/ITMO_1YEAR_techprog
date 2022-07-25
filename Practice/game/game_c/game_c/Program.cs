using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n@@@Введите начальное значение баланса:\n");
            int exit = 0;
            Player Player = new Player(int.Parse(Console.ReadLine()));
            
            do
            {
                Console.Write("\n@@@Главное меню@@@\nВарианты действий: \n0 - играть\n1 - запрос баланса \n2 - выйти\n");
                Console.Write("\nВыберите действие: ");
                int action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 0:
                        int cont = 1;
                        while ((Player.balance > 0) & (cont == 1))
                        {
                            Game game1 = new Game(ref Player);
                            game1.Session();
                            Console.Write("\nЖелаете продолжить игру? \n-0 - выйти в меню, \n-1 - продолжить, \n-2 - закончить игру\n");
                            cont = int.Parse(Console.ReadLine());
                            if ((cont != 0) & (cont != 1))
                            {
                                Console.Write("\n---\nВведено неверное значение\n---\n");
                                break;
                            }
                        }
                        if (Player.balance == 0) Console.Write("\nУ Вас больше нет средств!\n");
                        exit = 1;
                        break;
                    case 1:
                        Console.WriteLine(Player.Balance());
                        Console.WriteLine("\n-0 - выход в главное меню, \n-1 - закончить игру\n");
                        exit = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        exit = 1;
                        break;
                    default:
                        Console.WriteLine("\nВведите корректное значение\n");
                        break;
                }
            }
            while (exit != 1);


        }
    }

}
