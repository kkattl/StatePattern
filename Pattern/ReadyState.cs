using System;

namespace lab5.Pattern
{
    public class ReadyState : IATMState
    {
        private ATM atm;

        public ReadyState(ATM atm)
        {
            this.atm = atm;
        }
        public void InsertCard()
        {
            if (atm.CashInMachine > 0)
            {
                Console.WriteLine("Card inserted. Please enter your PIN.");
                atm.SetState(new PinEntringState(atm));
            }
            else
            {
                atm.SetState(new OutOfServiceState(atm));
            }
        }
        public void EnterPIN(int pin)
        {
            Console.WriteLine("No card inserted.");
        }
       
        
        public void WithdrawCash(int amountOfCash)
        {
            Console.WriteLine("No card inserted.");
        }
    
        public void EjectCard()
        {
            Console.WriteLine("No card inserted.");
        }
    }
}
