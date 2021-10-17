using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем разные типы аккаунтов
            var baseAcc = new BaseAccount(35000);
            var baseAcc1 = new BaseAccount(700);
            var salaryAcc = new SalaryAccount(80000);

            //вызываем калькулятор для данных аккаунтов.
            Calculator.CalculateInterest(baseAcc);
            Calculator.CalculateInterest(baseAcc1);
            Calculator.CalculateInterest(salaryAcc);

            Console.ReadKey();
        }
    }
}