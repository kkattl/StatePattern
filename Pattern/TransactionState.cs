using System;

namespace lab5.Pattern
{
    public class TransactionState : IATMState
    {
        private ATM atm;

        public TransactionState(ATM atm)
        {
            this.atm = atm;
        }
        public void InsertCard()
        {
            Console.WriteLine("Card is already inserted.");
        }
        public void EnterPIN(int pin)
        {
           Console.WriteLine("PIN is already entered.");
        }

        public void WithdrawCash(int amountOfCash)
        {
            if (amountOfCash > atm.CashInMachine)
            {
                Console.WriteLine("Not enough cash in ATM!");
                atm.SetState(new OutOfServiceState(atm));
            }
            else if (amountOfCash > atm.TransactionLimit)
            {
                Console.WriteLine("Exceeded withdrawal limit!");
            }
            else
            {
                atm.CashInMachine -= amountOfCash;
                Console.WriteLine("Withdrew {0}, current balance is {1}", amountOfCash, atm.CashInMachine);
            }
        }

        public void EjectCard()
        {
            Console.WriteLine("Card ejected.");
            atm.SetState(new ReadyState(atm));
        }
    }
}
