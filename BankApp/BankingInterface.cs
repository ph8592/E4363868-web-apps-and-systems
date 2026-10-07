using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankApp
{
    // BankingInterface class to handle user interactions and manage the menu logic
    internal class BankingInterface
    {
        private PremiumAccount? Customer;

        public void Run()
        {
            Console.WriteLine("Welcome to THE EXTRAORDINARY BANKING APP!");
            Console.WriteLine("This is a fixed run through demo.");
            Console.WriteLine("Please enter the customer's name:");
            string customerName = Console.ReadLine() ?? "";

            string sortCode;

            do
            {
                Console.WriteLine("Please enter the sort code (6 digits):");
                sortCode = Console.ReadLine() ?? "";

                if (!Regex.IsMatch(sortCode, @"\A[0-9]{6}\z"))
                {
                    Console.WriteLine("Sort code must contain exactly 6 digits.");
                }
            }
            while (!Regex.IsMatch(sortCode, @"\A[0-9]{6}\z"));

            string accountNumber;

            do
            {
                Console.WriteLine("Please enter the account number (8 digits):");
                accountNumber = Console.ReadLine() ?? "";

                if (!Regex.IsMatch(accountNumber, @"\A[0-9]{8}\z"))
                {
                    Console.WriteLine("Account number must contain exactly 8 digits.");
                }
            }
            while (!Regex.IsMatch(accountNumber, @"\A[0-9]{8}\z"));

            Customer = new PremiumAccount(customerName, sortCode, accountNumber);

            Console.WriteLine($"Account created: {Customer.ToString()}.");

            Console.WriteLine("Now, let's enter the initial deposit.");

            decimal initialDeposit;

            do
            {
                Console.WriteLine("Please enter the initial deposit amount:");
                string input = Console.ReadLine() ?? "";
                if (!decimal.TryParse(input, out initialDeposit) || initialDeposit < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number");
                }
                else
                {
                    Customer.Balance = initialDeposit;
                    break;
                }

            }
            while (true);

            Console.WriteLine($"The balance is currently {Customer.Balance:C2}.");

            Console.WriteLine("Now, let's process a transaction - three, in fact.");

            Console.WriteLine("Please enter the first transaction amount:");

            decimal transactionAmount;

            do
            {
                string input = Console.ReadLine() ?? "";
                if (!decimal.TryParse(input, out transactionAmount))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                else if (!Customer.ProcessTransaction(transactionAmount))
                {
                    Console.WriteLine("Transaction failed. Please enter a valid transaction amount.");
                }
                else
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine("Please enter the second transaction amount:");

            do
            {
                string input = Console.ReadLine() ?? "";
                if (!decimal.TryParse(input, out transactionAmount))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                else if (!Customer.ProcessTransaction(transactionAmount))
                {
                    Console.WriteLine("Transaction failed. Please enter a valid transaction amount.");
                }
                else
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine("Please enter the third transaction amount:");

            do
            {
                string input = Console.ReadLine() ?? "";
                if (!decimal.TryParse(input, out transactionAmount))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                else if (!Customer.ProcessTransaction(transactionAmount))
                {
                    Console.WriteLine("Transaction failed. Please enter a valid transaction amount.");
                }
                else
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine($"All transactions processed. Final account details: {Customer.ToString()} - balance: {Customer.Balance:C2}");

            Console.WriteLine("Thank you for using THE EXTRAORDINARY BANKING APP! Goodbye!");
        }



    }
}
