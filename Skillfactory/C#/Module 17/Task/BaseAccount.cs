using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class BaseAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public BaseAccount(double balance)
        {
            Balance = balance;
        }

        public double CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                return Interest -= Balance * 0.2;

            if (Balance < 50000)
                return Interest -= Balance * 0.4;

            return Interest;
        }
    }
}