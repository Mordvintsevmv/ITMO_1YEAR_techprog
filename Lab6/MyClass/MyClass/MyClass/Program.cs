using System;

namespace MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.SetBook("К.С. Станиславский", "Работа актёра над собой", "Public Domain", 520, 1989);
            //Book.SetPrice(13);
            b1.Print();
            Console.WriteLine("\nЦена аренды за 3 дня: {0}р.", b1.PriceBook(3));

            Console.WriteLine("\nУстановить цену на книгу 5 рублей:");
            Book.SetPrice(5);
            b1.Print();

            Console.WriteLine("\nУстановить цену на книгу 10 рублей:");
            Book.SetPrice(10);
            b1.Print();

            Book b2 = new Book("Редакция ФотоДепартамента", "Диалог искусств, № 2", "ФотоДепартамент", 138, 2019);
            b2.Print();

            Book b3 = new Book("LIFE magazine", "The Great Life Photographers");
            b3.Print();


        }
    }
}
