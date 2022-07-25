using System;
namespace MyClass
{
    public class Book
    {
            public string Author { get; set; }
            public string Title { get; set; }
            public string Publisher { get; set; }
            public int Pages { get; set; }
            public int Year { get; set; }

        private static double price = 9;

        public static double Price
        {
            get { return price; }
            set { if (value > 9) price = value; }
        }

        public void SetBook(string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        public static void SetPrice(double price)
        {
            Book.Price = price;
        }

        public override string ToString()
        {
            string bs = String.Format("\n\t@@@Книга@@@ \nАвтор: {0} \nНазвание: {1} \nГод издания: {2} \nСтраниц: {3} \nСтоимость аренды: {4}", Author, Title, Year, Pages, Book.Price);
            return bs;
        }

        public void Print()
        {
            Console.WriteLine(this);
        }

        public double PriceBook(int s)
        {
            double cost = s * price;
            return cost;
        }

        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publisher = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        public Book()
        {

        }

        static Book()
        {
            Price = 9;
        }

        public Book(string author, string title)
        {
            this.Author = author;
            this.Title = title;
        }
    }
}

