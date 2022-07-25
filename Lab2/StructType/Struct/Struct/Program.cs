using System;

namespace Struct
{
    public enum AccountType { Cheking, Deposit}

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }

    class Struct
    {
        static void Main()
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Cheking;
            goldAccount.accBal = (decimal)5400.00;
            Console.Write("Введите номер аккаунта: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());

            Console.WriteLine("\n\n@@@ Данные Аккаунта @@@");
            Console.WriteLine("Номер аккаунта - {0}", goldAccount.accNo);
            Console.WriteLine("Счёт аккаунта - {0}", goldAccount.accBal);
            Console.WriteLine("Тип аккаунта - {0}", goldAccount.accType);

        }
    }
}
