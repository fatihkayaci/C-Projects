using System;

namespace BankSystem
{
    class MainProgram
    {
        private static List<IBankAccount> accounts = new List<IBankAccount>();
        static void Main(string[] args)
        {
            Console.Clear();
            string? number;
            bool cont = true;
            Console.WriteLine("Welcome to the bank Management System");
            do
            {
                Console.WriteLine("1. Open Account \n2. Account list \n3. Account View detail \n4. Deposit Money \n5. Withdraw Money \n6. Exit");
                Console.WriteLine("---------------------------------------------------------------");
                number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        OpenAccount();
                        break;
                    case "2":
                        ViewAccountList();
                        break;
                    case "3":
                        ViewAccountDetail();
                        break;
                    case "4":
                        DepositAccount();
                        break;
                    case "5":
                        WithDrawAccount();
                        break;
                    case "6":
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("Please try again");
                        break;
                }                
            } while (cont);
        }
        private static void OpenAccount()
        {
            XBank account;
            int accountNumber;
            Console.WriteLine("Please enter holder.");
            string? holder = Console.ReadLine();

            Console.WriteLine("Please enter balance");
            decimal balance = Convert.ToDecimal(Console.ReadLine());
            if (holder != null)
            {
                accountNumber = accounts.Count() + 1;
                account = new XBank(accountNumber, holder, balance);
                accounts.Add(account);
            }
            Console.WriteLine("---------------------------------------------------------------");
        }
        private static void ViewAccountList()
        {
            foreach (IBankAccount a in accounts)
            {
                Console.WriteLine($"{a.AccountNumber} {a.AccountHolder}");
            }
            Console.WriteLine("---------------------------------------------------------------");
        }
        private static void ViewAccountDetail()
        {
            Console.WriteLine("Please enter account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");
            foreach (IBankAccount a in accounts)
            {
                if (a.AccountNumber == accountNumber)
                {
                    Console.WriteLine($"Account Number = {a.AccountNumber}");
                    Console.WriteLine($"Account Holder = {a.AccountHolder}");
                    Console.WriteLine($"Account Balance = {a.Balance}");
                }
            }
            Console.WriteLine("--------------------------------------------------");
        }
        private static void DepositAccount()
        {
            Console.WriteLine("Select Account \nplease enter Account Number:");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            foreach (IBankAccount a in accounts)
                if (a.AccountNumber == accountNumber)
                {
                    Console.WriteLine("Enter Balance Amount: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    a.Deposit(amount);
                }    
        }
        private static void WithDrawAccount()
        {
            Console.WriteLine("Select Account \nplease enter Account Number:");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            foreach (IBankAccount a in accounts)
                if (a.AccountNumber == accountNumber)
                {
                    Console.WriteLine("Enter Balance Amount: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    a.Withdraw(amount);
                }    
        }

    }
}