namespace lab5.Pattern
{
    public class ATM
    {

        private IATMState currentState;
        private int _cashInMachine;
        private int _transactionLimit;
        public int _correctPin;

        public int FailedAttempts = 0;

        public ATM()
        {
            this.currentState = new ReadyState(this);
        }

        public int CashInMachine
        {
            get => _cashInMachine;
            set => _cashInMachine = value;
        }
        public int TransactionLimit
        {
            get => _transactionLimit;
            set => _transactionLimit = value;
        }
        public int CorrectPin
        {
            get => _correctPin;
            set => _correctPin = value;
        }
        public void SetState(IATMState newState)
        {
            currentState = newState;
        }

        public void InsertCard()
        {
            currentState.InsertCard();
        }

        public void EnterPIN(int pin)
        {
            currentState.EnterPIN(pin);
        }

        public void WithdrawCash(int amountOfCash)
        {
            currentState.WithdrawCash(amountOfCash);
        }

        public void IncrementFailedAttempts()
        {
            FailedAttempts++;
        }
    }
}
