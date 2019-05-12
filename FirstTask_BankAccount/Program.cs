using System;

namespace FirstTask_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account customer = new Account("Kostas", 452, 1);
            Console.WriteLine(customer);
            bool success = customer.Withdraw(200);
            if (success)
                Console.WriteLine("Withdrawal successful!");
            else
                Console.WriteLine("Withdrawal failed, unsufficient funds!");

            Console.WriteLine(customer);

            success = customer.Deposit(5800);
            if (success)
                Console.WriteLine("Deposit successful!");
            else
                Console.WriteLine("Deposit failed");
            Console.WriteLine(customer);

            success = customer.Withdraw(8200);
            if (success)
                Console.WriteLine("Withdrawal successful!");
            else
                Console.WriteLine("Withdrawal failed, unsufficient funds!");
            Console.WriteLine(customer);

            Console.ReadLine();
        }
    }
}
