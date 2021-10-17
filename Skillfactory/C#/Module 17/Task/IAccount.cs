using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public interface IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        /// <summary>
        /// метод расчета процентной ставки
        /// </summary>
        /// <returns> ве</returns>
        public double CalculateInterest();
    }
}