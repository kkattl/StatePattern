namespace lab5.Pattern
{
    public interface IATMState
    {
        void InsertCard();
        void EnterPIN(int pin);
        void WithdrawCash(int amountOfCash);
        void EjectCard();
    }
}
