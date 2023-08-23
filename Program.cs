using lab5.Pattern;
using System;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM
            {
                CashInMachine = 20000,
                TransactionLimit = 10000,
                CorrectPin = 2314
            };
           
            atm.InsertCard();
            atm.EnterPIN(1234);
            atm.EnterPIN(2314);
            atm.WithdrawCash(10000);
            atm.WithdrawCash(10000);
            atm.EjectCard();
            atm.InsertCard();
            atm.EnterPIN(2314);
            Console.ReadKey();
        }
    }
}
