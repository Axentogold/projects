using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    public class Result : IOperation
    {
        public string Sum(int val1, int val2)
        {
            return (val1 + val2).ToString();
        }
    }
    class ConsoleUI
    {
        static ILogger Logger { get; set; }
        public void Start()
        {

            Logger = new Logger();
            bool exit = false;
            do
            {

                try
                {
                    Console.WriteLine("\n Введите первое число:");
                    var val1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n Введите второе число:");
                    var val2 = Convert.ToInt32(Console.ReadLine());
                    IOperation result = new Result();
                    Logger.Event($"\n Результат: {val1} + {val2} = {result.Sum(val1, val2)}");

                }
                catch (FormatException)
                {
                    Logger.Error("Некорректный ввод, введите целое число");
                }

                finally
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_________________________\n");

                    Console.WriteLine("Для выхода нажмите ESC, для продолжения - любую клавишу");

                    if (Console.ReadKey().Key == ConsoleKey.Escape) exit = true;
                }

            } while (!exit);

        }
    }
}