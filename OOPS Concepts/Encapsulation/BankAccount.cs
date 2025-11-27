using System;

namespace BridgeLabzApp.OOPS_Concepts.Encapsulation
{
    internal class BankAccount
    {
        
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }    
            private set { balance = value; }  
        }

        public BankAccount(decimal initialAmount)
        {
            Balance = initialAmount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {Balance}");
        }
    }

    internal class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount(1000);

            account.Deposit(500);     
            account.Withdraw(300);    
            account.Withdraw(2000);   
        }
    }
}
