using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTask_BankAccount
{
    public class Account
    {
        const double depositLimit = 5000;
        
        string owner;
        double balance;
        int numberOfTransactions;

        public bool Deposit(double amount)
        {
            if (amount <= depositLimit)
            {
                balance += amount;
                numberOfTransactions++;
                return true;
            }
            else
                return false;

        }

        public bool Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                numberOfTransactions++;
                return true;
            }
            else
                return false;
        }

        public Account()
        {

        }

        public Account(string owner, double balance, int numberOfTransactions)
        {
            this.owner = owner;
            this.balance = balance;
            this.numberOfTransactions = numberOfTransactions;
        }
        public override string ToString()
        {
            return "Account owner: " + owner + " Balance: " + balance + " Number of transactions: " + numberOfTransactions;
        }
    }
}

