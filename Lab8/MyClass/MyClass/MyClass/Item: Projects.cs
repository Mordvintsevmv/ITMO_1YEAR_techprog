using System;
namespace MyClass
{
    public abstract class Item: IComparable
    {
        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }

        public abstract void Return();

        protected long invNumber;
        protected bool taken;

        public bool IsAvailable()
        {
            if (taken == true) return true;
            else return false;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        private void Take()
        {
            taken = false;
        }

       

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public Item()
        {
            this.taken = true;
        }

        public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }

        public virtual void Print()
        {
            Console.WriteLine("\n@@@Состояние предмета:@@@  \nИнвентарный номер: {0}; \n Наличие: {1}.", invNumber, taken);
        }
    }
}
