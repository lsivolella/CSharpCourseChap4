using System;
using System.Globalization;

namespace Cap04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise01();
            // Exercise02();
            // Exercise03();
            // Exercise04();
            // Exercise05();
            // Exercise06();
            // Exercise07();
            // Exercise08();
            Exercise09();
        }

        private static void Exercise01()
        {
            Person a = new Person();
            Person b = new Person();

            Console.WriteLine("Type the name and age of a person:");
            a.Name = Console.ReadLine();
            a.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the name and age of another person:");
            b.Name = Console.ReadLine();
            b.Age = int.Parse(Console.ReadLine());

            if (a.Age > b.Age)
            {
                Console.WriteLine("{0} is older than {1}", a.Name, b.Name);
            }
            else if (a.Age == b.Age)
            {
                Console.WriteLine("{0} and {1} are the same age.", a.Name, b.Name);
            }
            else
            {
                Console.WriteLine("{0} is older than {1}", b.Name, a.Name);
            }
        }

        private static void Exercise02()
        {
            Employee a = new Employee();
            Employee b = new Employee();

            Console.WriteLine("Type the name and wage of the first employee:");
            a.Name = Console.ReadLine();
            a.GrossIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Type the name and wage of the second employee:");
            b.Name = Console.ReadLine();
            b.GrossIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double averageWage = (a.GrossIncome + b.GrossIncome) / 2.0;

            Console.WriteLine("The average wage is: " + averageWage.ToString("f2", CultureInfo.InvariantCulture));
        }

        private static void Exercise03()
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();
            double a1, a2;

            Console.WriteLine("Type the length of the three sides of the first triangle: ");
            t1.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t1.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t1.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Type the length of the three sides of the second triangle: ");
            t2.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t2.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t2.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a1 = t1.Area();
            a2 = t2.Area();

            Console.WriteLine();
            Console.WriteLine("Area of the first triangle: " + a1.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area of the second triangle: " + a2.ToString("f4", CultureInfo.InvariantCulture));

            Console.WriteLine();
            if (a1 > a2)
                Console.WriteLine("The first triangle has the largest area.");
            else if (a1 == a2)
                Console.WriteLine("Both triangles have the same area.");
            else
                Console.WriteLine("The second triangle has the largest area.");
        }

        private static void Exercise04()
        {
            Product product = new Product();

            Console.Write("Type in the name of the product: ");
            product.Name = Console.ReadLine();
            Console.Write("Type in the price of the product: ");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Type in the quantity in inventory for this product: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Product Info: " + product);

            Console.WriteLine();
            Console.Write("Type in how many products you wish to add to the inventory: ");
            product.AddProductToInventory(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Updated Product Info: " + product);

            Console.WriteLine();

            Console.Write("Type in how many products you wish to remove from the inventory: ");
            product.RemoveProductToInventory(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Updated Product Info: " + product);

        }

        private static void Exercise05()
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Enter the width and hight of the rectangle: ");
            rectangle.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rectangle.Hight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(rectangle.ToString());
        }

        private static void Exercise06()
        {
            Employee employee = new Employee();

            Console.WriteLine("Type in the Name, the Gross Income and the Tax amount for the Employee: ");
            employee.Name = Console.ReadLine();
            employee.GrossIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            employee.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(employee.ToString());

            Console.WriteLine("Type in the percentage you wish to raise the Employee Gross Income: ");
            double _percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            employee.RaiseGrossIncome(_percentage);

            Console.WriteLine(employee.ToString());
        }

        private static void Exercise07()
        {
            Student student = new Student();

            Console.WriteLine("Type in the student's Name and Test Scores: ");
            student.Name = Console.ReadLine();
            student.Score1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Score2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Score3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Final Score: " + student.FinalScore().ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine("Student Status: " + student.FinalResult());

            if (student.FinalScore() < 60.0)
            {
                Console.WriteLine("Student Missed: " + student.RemainingScore() + " points.");
            }
        }

        private static void Exercise08()
        {
            Console.Write("Type in the current Dollar Quote: ");
            double _quotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Type in how many Dollar you wish to buy: ");
            double _amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Value to be paid in Reais: R$ " + CurrencyConverter.ReaisToBePaid(_quotation, _amount).ToString("f2", CultureInfo.InvariantCulture));
        }

        private static void Exercise09()
        {
            BankAccount bankAccount;

            Console.Write("Type in the Number of the new Account: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Type in the Name of the Account Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Make initial deposit (y/n)? ");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 'y' || answer == 'Y')
            {
                Console.Write("Type in the value of the first deposit: ");
                double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bankAccount = new BankAccount(number, holder, deposit);
            }
            else
            {
                bankAccount = new BankAccount(number, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Account Information: ");
            Console.WriteLine(bankAccount);

            Console.WriteLine();
            Console.WriteLine("Account Information: ");
            bankAccount.MakeDeposit(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Type in the value for deposit: ");
            Console.WriteLine(bankAccount);

            Console.WriteLine();
            Console.Write("Type in the value for withdraw: ");
            bankAccount.MakeWithdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Account Information: ");
            Console.WriteLine(bankAccount);
        }
    }
}
