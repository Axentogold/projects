using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    /// <summary>
    /// Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join("\n", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            //Вариант с полным query синтаксисом
            //var allStudents = (from cl in classes
            //                   select cl.Students into studList
            //                   from student in studList
            //                   select student).ToArray();

            //вариант через методы расширения
            var allStudents = classes.SelectMany(s => s.Students).ToArray();
            return allStudents;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}