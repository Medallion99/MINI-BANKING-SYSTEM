using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKING_SYSTEM
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string CustomerName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string accountNumber, string customerName, double initialBalance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = initialBalance;
        }

        //Creating the deposit function

        public void Deposit(double amount)
        {
            if (amount > 0)
            { 
                Balance += amount;
                Console.WriteLine($"{amount} deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please enter a valid amount.");
            }
            Console.Clear();
        }
   
        //Creating withdrawal function
        public void Withdraw(double amount)
        {
            if (Balance >= amount && amount > 0)
            {
                Console.WriteLine("Please leave a description for your transaction");
                string desc = Console.ReadLine();

                Console.WriteLine($"{amount} withdrawn successfully\n Description:\t {desc}\n.");
                Balance -= amount;
               
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount. Please check your balance and try again.");
            }
           // Console.Clear();
            
        }

        //Creating Account Balance Function
        public void CheckBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            //Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Current balance: {Balance}");
        }
    }
}
