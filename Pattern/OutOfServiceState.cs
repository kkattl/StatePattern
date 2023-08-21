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
            atm.SetState(new ReadyState(atm));
        }
        public void EnterPIN(int pin)
        {
            Console.WriteLine("Card is blocked. Please contact your bank.");
        }


        public void WithdrawCash(int amountOfCash)
        {
            Console.WriteLine("Card is blocked. Please contact your bank.");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card ejected.");
        }
    }
}
