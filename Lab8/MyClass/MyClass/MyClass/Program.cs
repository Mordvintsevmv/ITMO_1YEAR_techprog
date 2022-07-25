using System;
using System.Collections.Generic;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p1 = new Publisher("Public Domain", "mnelen@aaaa.hi", 11, new DateTime(1990, 01, 01));
            Book b1 = new Book("К.С. Станиславский", "Моя жизнь в искусстве", p1, 320, 1989, 13, true);
            b1.TakeItem();

            Audit.RunAudit();

            Magazine m1 = new Magazine("Искусство фотографии", 2, "Диалог искусств", 2019, 23, true);
            m1.TakeItem();
            m1.Subs();

            Magazine m2 = new Magazine("Spider-Man", 20, "MARVEL", 2019, 242, true);
            m2.TakeItem();
            Audit.StopAudit();
            m2.Subs();

            Book b2 = new Book("К.С. Станиславский", "Работа актёра над собой", p1, 820, 1989, 17, true);

            Book b3 = new Book("К.С. Станиславский", "Работа актёра над ролью", p1, 920, 1989, 2, true);

            List<Item> itlist = new List<Item>();
            itlist.AddRange(new Item[] { b1, b2, b3, m1, m2 });
            itlist.Sort();

            Console.WriteLine("\n@@@Сортировка по инвентарному номеру@@@");
            foreach (Item x in itlist) x.Print();
 
        }
    }
}
