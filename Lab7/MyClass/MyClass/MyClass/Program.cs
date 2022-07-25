using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p1 = new Publisher("Public Domain", "mnelen@aaaa.hi", 11, new DateTime(1990, 01, 01));
            Book b1 = new Book("К.С. Станиславский", "Работа актёра над собой", p1, 520, 1989, 13, true);
            b1.TakeItem();
            b1.Print();

            Magazine m1 = new Magazine("Искусство фотографии", 2, "Диалог искусств", 2019, 23, true);
            m1.TakeItem();
            m1.Print();

            //Item it;

            //b1.ReturnSrok();
            //it = b1;
            //it.TakeItem();
            //it.Return();
            //it.Print();

            //it = m1;
            //it.TakeItem();
            //it.Return();
            //it.Print();
        }
    }
}
