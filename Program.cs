using System;
using System.Collections.Generic;
using System.Linq;

namespace labThree
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            var employeers = new Employee[10];

            for (int i = 0; i < employeers.Length; i++)
            {
                var fName = "First " + (i + 1).ToString();
                var sName = "Second " + (i + 1).ToString();
                var tName = "Third " + (i + 1).ToString();
                var job = "programmist " + (i + 1).ToString();
                var salary = Math.Round(rnd.NextDouble() * 1000, 2);
                var birthday = RandomDay();
                employeers[i] = new Employee(fName, sName, tName, job, salary, birthday);
            }
            Console.WriteLine($"Список всех сотрудников:");
            PrintHeader();
            PrintBorder();
            foreach (var item in employeers)
            {
                Console.WriteLine(item);
            }
            PrintBorder();


            Console.WriteLine();
            Console.WriteLine();
            
            var averageSalary = AverageSalary(employeers);

            Console.WriteLine($"Средняя зарплата: {averageSalary}");
            Console.WriteLine();
            Console.WriteLine($"Сотрудники, зп которых больше средней и младше 30 лет");
            PrintHeader();
            PrintBorder();
            foreach (var item in employeers)
            {
                
                if (item.Salary > averageSalary && calcAge(item.Birthday) < 30)
                {
                    Console.WriteLine(item);
                }
            }
            PrintBorder();

            


        }

        private static DateTime RandomDay()
        {
            var start = new DateTime(1960, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }

        private static double AverageSalary(Employee[] array)
        {
           var list = array.ToList();
           return Math.Round(list.Sum(e => e.Salary) / list.Count, 2);
        }

        private static int calcAge(DateTime dateTime)
        {
            var now = DateTime.Now;
            var age = now.Year - dateTime.Year;

            if (now.Month < dateTime.Month || (now.Month == dateTime.Month && now.Day < dateTime.Day))
            {
                age--;

            }

            return age;
        }

        private static void PrintHeader()
        {
            Console.WriteLine("Фамилия          |Имя               |Отчество          |Должность         |Зарплата     |Дата рождения");

        }
        private static void PrintBorder()
        {
            Console.WriteLine("____________________________________________________________________________________________________________________");
        }
    }
}
