namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Task 1 - Bank Account Demo\n");

            BankAccount account = new BankAccount(123456, 2500000.0);

            Console.WriteLine($"User Account Number: {account.AccountNumber}");
            Console.WriteLine($"Starting Balance: {account.Balance}\n");

            account.Deposit(50000.0);
            Console.WriteLine($"Balance after deposit: {account.Balance}\n");

            account.Withdraw(4000.0);
            Console.WriteLine($"Balance after withdrawal: {account.Balance}");
        }
    }
}
