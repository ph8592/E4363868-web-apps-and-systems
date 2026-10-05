using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    internal class PremiumAccount
    {
        private string? CustomerName { get; set; }
        private int SortCode { get; set; }
        private int AccountNumber { get; set; }
        private double Balance { get; set; }
        private double OverdraftLimit { get; set; }
        private double DailyTransactionLimit { get; set; }


    }
}
