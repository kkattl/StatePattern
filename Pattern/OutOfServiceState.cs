using System;

namespace lab5.Pattern
{
    public class OutOfServiceState : IATMState
    {
        private ATM atm;

        public OutOfServiceState(ATM atm)
        {
            this.atm = atm;
        }
        public void InsertCard()
        {
            Console.WriteLine("ATM is blocked");
        }
        public void EnterPIN(int pin)
        {
            Console.WriteLine("ATM is blocked");
        }

        public void WithdrawCash(int amountOfCash)
        {
            Console.WriteLine("ATM is blocked");
        }

        public void EjectCard()
        {
            Console.WriteLine("ATM is blocked");
        }
    }
}
