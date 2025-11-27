using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task1
{
    internal class BankAccount
    {
        private int accNumber;
        private double accBalance;

        // Read-only property for account number
        public int AccountNumber
        {
            get { return accNumber; }
        }

        // Balance property with validation
        public double Balance
        {
            get { return accBalance; }
            private set
            {
                if (value >= 0)
                {
                    accBalance = value;
                }
                else
                {
                    Console.WriteLine("Error: Initial balance cannot be negative.");
                }
            }
        }

        // Constructor to set account number and starting balance
        public BankAccount(int accountNumber, double initialBalance)
        {
            this.accNumber = accountNumber;
            Balance = initialBalance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
            }
            else
            {
                accBalance += amount;
                Console.WriteLine($"Deposit successful. Updated balance: {accBalance}");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Please enter a positive value.");
            }
            else if (amount > accBalance)
            {
                Console.WriteLine("Transaction failed: Insufficient balance.");
            }
            else
            {
                accBalance -= amount;
                Console.WriteLine($"Withdrawal successful. Updated balance: {accBalance}");
            }
        }
    }
}

