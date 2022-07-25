using System;
namespace MyClass
{
    public class Book: Item
    {
            public string Author { get; set; }
            public string Title { get; set; }
            //public string Publisher { get; set; }
            public Publisher Publ{ get; set; }
            public int Pages { get; set; }
            public int Year { get; set; }
            public bool returnSrok { get; private set; }   



        private static double price = 9;

        public static double Price
        {
            get { return price; }
            set { if (value > 9) price = value; }
        }

        public void SetBook(string author, string title, Publisher publisher, int pages, int year)
        {
            this.Author = author;
            this.Title = title;
            this.Publ = publisher;
            this.Pages = pages;
            this.Year = year;
        }

        public static void SetPrice(double price)
        {
            Book.Price = price;
        }

        public override string ToString()
        {
            string bs = String.Format("\n\t@@@Книга@@@ \nАвтор: {0} \n Название: {1} \nГод издания: {2} \n Страниц: {3} \nСтоимость аренды: {4}, \n Издатель: {5}", Author, Title, Year, Pages, Book.Price, Publ.ToString());
            return bs;
        }

        public double PriceBook(int s)
        {
            double cost = s * price;
            return cost;
        }

        public Book(string author, string title, Publisher publisher, int pages, int year, long invNumber, bool taken)
        : base(invNumber, taken)
        {
            this.Author = author;
            this.Title = title;
            this.Publ = publisher;
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

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return()
        {
            if (returnSrok == true) taken = true;
            else taken = false;
        }

        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }

       
    }
}

