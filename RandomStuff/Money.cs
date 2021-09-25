namespace RandomStuff
{
    public class Money
    {
        public double moneyOnBankAccount;
        public double moneyInCash;
        
        public double MoneyTotal
        {
            get => moneyInCash + moneyOnBankAccount;
        }

        public Money(double inCash, double onAccount)
        {
            moneyInCash = inCash;
            moneyOnBankAccount = onAccount;
        }
    }
}
