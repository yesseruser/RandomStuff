namespace RandomStuff
{
    public class Money
    {
        /// <summary>
        /// The money on the bank account.
        /// </summary>
        public double moneyOnBankAccount;

        /// <summary>
        /// The money in cash.
        /// </summary>
        public double moneyInCash;
        
        /// <summary>
        /// The money in total. Not changeable.
        /// </summary>
        public double MoneyTotal
        {
            get => moneyInCash + moneyOnBankAccount;
        }

        /// <summary>
        /// The constructor.
        /// </summary>
        /// <param name="inCash">Determines money in cash.</param>
        /// <param name="onAccount">Determines money on the bank account.</param>
        public Money(double inCash, double onAccount)
        {
            moneyInCash = inCash;
            moneyOnBankAccount = onAccount;
        }
    }
}
