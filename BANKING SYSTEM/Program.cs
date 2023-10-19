namespace BANKING_SYSTEM
{
    public class Program
    {
            static List<BankAccount> accounts = new List<BankAccount>();
            

            static void Main(string[] args)

            static void RegisterAccount()
            {
                Console.Write("Enter your name: ");
                string customerName = Console.ReadLine();

                Console.Write("Enter your phone number: ");
                string phoneNumber = Console.ReadLine();

                // Generate a unique account number based on phone number (you can use your own logic)
                string accountNumber = GenerateAccountNumber(phoneNumber);
            BankAccount account2 = new BankAccount(accountNumber, customerName, 0);
            Console.WriteLine($"Your account number is: {accountNumber}");
            Console.WriteLine($"Your account name is {customerName}");

        }
   
            static void OpenAccount()
            {

            Console.Write("Enter your account number: ");
                string accountNumber = Console.ReadLine();

                double initialBalance = 0;//Console.Write("Enter the initial balance: ");
                if (initialBalance >= 0)
                {
                    BankAccount account = new BankAccount(accountNumber, " ", initialBalance);
                    accounts.Add(account);
                    Console.WriteLine("Account opened successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid initial balance. Please enter a valid number.");
                }
            }

            // Instantiating the perform Transaction Method
            static void PerformTransactions()
            {
                Console.Write("Enter your account number: ");
                string accountNumber = Console.ReadLine();

                BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);

                if (account != null)
                {
                accounts.Add(account);
                Console.WriteLine($"Welcome, {account.CustomerName}!");
                    account.CheckBalance();

                    Console.Write("Enter the amount to deposit: ");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                    {
                        account.Deposit(depositAmount);
                    }
                    Console.WriteLine($"You just deposited {depositAmount}, and your current account balance is:");
                    Console.WriteLine();    
                    account.CheckBalance();

                    Console.Write("Enter the amount to withdraw: ");
                    if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                    {
                        account.Withdraw(withdrawAmount);
                    }

                    account.CheckBalance();
                }
                else
                {
                    Console.WriteLine("Account not found. Please check your account number.");
                }
           

        }

            static void CheckBalance()
            {
                Console.Write("Enter your account number: ");
                string accountNumber = Console.ReadLine();

                BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);

                if (account != null)
                {
                    account.CheckBalance();
                }
                else
                {
                    Console.WriteLine("Account not found. Please check your account number.");
                }
            }

            // You can define your own logic for generating account numbers based on phone numbers
            static string GenerateAccountNumber(string phoneNumber)
            {
                // This is a simple example; you can make it more complex
                return "ACC" + phoneNumber.Substring(phoneNumber.Length - 4);
            }
        

    }
}
