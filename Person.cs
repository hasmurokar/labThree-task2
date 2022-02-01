using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labThree
{
    struct Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public DateTime Birthday { get; set; }

        public Employee(string firstName, string secondName, string thirdName, string job, double salary, DateTime birthday)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            Job = job;
            Salary = salary;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{FirstName, -16} | {SecondName, -16} | {ThirdName, -16} | {Job, -16} | {Salary, -10}$ | {Birthday:D}";
        }
    }
}
