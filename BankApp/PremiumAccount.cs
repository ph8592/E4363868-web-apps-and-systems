using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class PremiumAccount
    {
        private string CustomerName { get; set; } = "";
        private string SortCode { get; set; } = "";
        private string AccountNumber { get; set; } = "";
        public decimal Balance { get; set; }
        private decimal OverdraftLimit { get; set; }
        public decimal DailyTransactionLimit { get; private set; }

        // Constructor
        public PremiumAccount(string customerName, string sortCode, string accountNumber)
        {
            CustomerName = customerName;
            SortCode = sortCode;
            AccountNumber = accountNumber;
            Balance = 0.00m;
            OverdraftLimit = 1000.00m;
            DailyTransactionLimit = 500.00m;
        }

        // ToString method to display customer name and full account identification
        public override string ToString()
        {
            return $"Customer: {CustomerName} (Sort Code: {SortCode[..2]}-{SortCode[2..4]}-{SortCode[4..6]}, Account No: {AccountNumber})";
        }

        // Method to process a transaction - allows for refunds
            public bool ProcessTransaction(decimal transactionAmount)
        {
            if (transactionAmount > DailyTransactionLimit)
            {
                Console.WriteLine($"Transaction failed!: Amount exceeds the daily transaction limit of {DailyTransactionLimit:C2}.");
                return false;
            }
            if (Balance + OverdraftLimit < transactionAmount)
            {
                Console.WriteLine($"Transaction failed due to insufficient funds!: Available balance including overdraft is {Balance + OverdraftLimit:C2}.");
                return false;
            }
            Balance -= transactionAmount;
            Console.WriteLine($"Transaction successful: Your new balance is {Balance:C2}.");
            return true;
        }
    }
}