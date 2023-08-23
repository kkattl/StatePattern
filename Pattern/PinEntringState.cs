using System;

namespace lab5.Pattern
{
    public class PinEntringState : IATMState
    {
        private ATM atm;

        public PinEntringState(ATM atm)
        {
            this.atm = atm;
        }
       
        public void InsertCard()
        {
            Console.WriteLine("Card is already inserted.");
        }
        public void EnterPIN(int pin)
        {
            if (pin == atm.CorrectPin)
            {
                Console.WriteLine("PIN correct!");
                atm.SetState(new TransactionState(atm));
            }
            else
            {
                Console.WriteLine("Incorrect PIN!");
                atm.IncrementFailedAttempts();
                if (atm.FailedAttempts >= 3)
                {
                    Console.WriteLine("Too many incorrect PIN attempts. Card is blocked.");
                    atm.SetState(new OutOfServiceState(atm));
                }
            }
        }


        public void WithdrawCash(int amountOfCash)
        {
            Console.WriteLine("Enter your PIN.");
        }

        public void EjectCard()
        {
            Console.WriteLine("Card ejected.");
            atm.SetState(new ReadyState(atm));
        }
    }
}
