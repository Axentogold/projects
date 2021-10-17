
using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class SalaryAccount : IAccount
    {
        public double Balance { get; set; }

        public SalaryAccount(double balance)
        {
            Balance = balance;
        }

        public double CalculateInterest()
        {
            return Balance * 0.5;
        }
    }
}