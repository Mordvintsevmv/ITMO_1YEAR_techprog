using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_c
{
    class Game
    {
        public Player player;
        public Game(ref Player player)
        {
            this.player = player;
        }
        public void Session()
        {
            Console.Write("\n@@@\nБаланс: {0}\n", player.balance);
            Console.Write("Ваша ставка: ");
            int stav = int.Parse(Console.ReadLine());
            if (stav > player.balance)
            {
                Console.Write("Ошибка! Значение ставки не может превышать текущей суммы на счету\n");
            }
            else
            {
                Console.Write("\nСделайте выбор: \n0 - чет\n1 - нечет\n");
                int choose = int.Parse(Console.ReadLine());
                if ((choose != 0) & (choose != 1))
                {
                    Console.Write("Введено неверное значение\n");
                }
                else
                {
                    Generator generator = new Generator();
                    int rand = generator.random();
                    if (rand % 2 == choose)
                    {
                        player.balance += stav;
                        Console.Write("\n---\nВы угадали!\nБаланс:{0}\n", player.balance);
                        Console.Write("Число:{0}\n---\n", rand);
                    }

                    else
                    {
                        player.balance -= stav;
                        Console.Write("\n---\nВы не угадали!\nБаланс:{0}\n", player.balance);
                        Console.Write("Число:{0}\n---\n", rand);

                    }
                }
            }
        }
    }
}
