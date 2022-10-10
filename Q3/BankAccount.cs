using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public int Balance { get; set; }

        public BankAccount(int accountNumber, string accountHolder, int balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\nAccount Number : {AccountNumber}");
            Console.WriteLine($"Account Holder : {AccountHolder}");
            Console.WriteLine($"Balance : {Balance:c}");
        }

        public void AddMoney()
        {
            Console.Write($"\nEnter amount to add for account {AccountNumber}: ");
            int money = int.Parse(Console.ReadLine());

            Balance += money;

            DisplayDetails();
        }

        public void WithdrawMoney()
        {
            Console.Write($"\nEnter amount to withdraw from account {AccountNumber}: ");
            int money = int.Parse(Console.ReadLine());

            Balance -= money;

            DisplayDetails();
        }
    }
}
