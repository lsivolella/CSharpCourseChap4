using System.Globalization;

namespace Cap04
{
    class Employee
    {
        public string Name;
        public double GrossIncome;
        public double Tax;

        private double NetIncome()
        {
            return GrossIncome - Tax;
        }

        public void RaiseGrossIncome(double percentage)
        {
            GrossIncome = GrossIncome + (GrossIncome * percentage / 100.0);
        }

        public override string ToString()
        {
            return "Employee: " + Name + ", $" + 
                NetIncome().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
