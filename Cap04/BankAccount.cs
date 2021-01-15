using System.Globalization;

namespace Cap04
{
    class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public BankAccount(int number, string holder, double initialDeposit) : this(number, holder)
        {
            MakeDeposit(initialDeposit);
        }


        public void MakeDeposit(double amount)
        {
            Balance += amount;
        }

        public void MakeWithdraw(double amount)
        {
            Balance -= (5.0 + amount);
        }

        public override string ToString()
        {
            return "Account: " 
                + Number
                + ", Holder: " 
                + Holder
                + ", Balance: $ " 
                + Balance.ToString("f2", CultureInfo.InvariantCulture);
                
        }

    }
}
