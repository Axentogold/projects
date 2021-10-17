using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public static class Calculator
    {
        // Метод для расчета процентной ставки
        public static void CalculateInterest(IAccount account)
        {
            Console.WriteLine(account.CalculateInterest());
        }
    }
}