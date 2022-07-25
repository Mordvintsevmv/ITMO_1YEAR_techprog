using System;

namespace BankAccount
{
    public enum AccountType { Cheking, Deposit}
    class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Cheking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("AccountType gold клиента - {0}", goldAccount);
            Console.WriteLine("AccountType platinum клиента - {0}", platinumAccount);

        }
    }
}
