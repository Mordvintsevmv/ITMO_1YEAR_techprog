using System;
using System.IO;

namespace MyClass
{
    public delegate void ProcessMagazineDelegate(Magazine mag, DateTime dt);

    public class Magazine : Item, IPubs
    {

        public static event ProcessMagazineDelegate Subscribe = null;

        public string Volume { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        public bool IfSubs { get; set; }
        public void Subs()
        {
            IfSubs = true;
            if (Subscribe != null)
                Subscribe(this, DateTime.Now);
        }

        public Magazine(string volume, int number, string title, int year, long invNumber, bool taken)
        : base(invNumber, taken)
        {
            this.Volume = volume;
            this.Number = number;
            this.Title = title;
            this.Year = year;
        }

        public Magazine()
        {
        }

        public override string ToString()
        {
            string bs = String.Format("\n@@@Журнал:@@@\nТом: {0}\n Номер: {1}\n Название: {2} \nГод выпуска: {3} \nСтатус подписки: {4}", Volume, Number, Title, Year, IfSubs);
            return bs;
        }

        public override void Print()
        {
            Console.WriteLine(this);
            base.Print();
        }

        public override void Return()
        {
            taken = true;
        }


    }
}