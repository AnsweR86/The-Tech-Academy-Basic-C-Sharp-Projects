using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(15, 40);
            Person person2 = new Person(20, 40);

            Console.WriteLine("Anonymous Income Comparison Program");
            PrintPersonStats(person1);
            PrintPersonStats(person2);
            Console.WriteLine("Weekly Salry of Person 1:\n{0}", person1.WeeklySalary());
            Console.WriteLine("Weekly Salry of Person 2:\n{0}", person2.WeeklySalary());
            CompareSalary(person1, person2);
            Console.ReadLine();
        }
        public static void PrintPersonStats (Person person)
        {
            Console.WriteLine("Hourly Rate?\n{0}", person.HourlyRate);
            Console.WriteLine("Hours worked per week?\n{0}", person.HoursPerWeek);
        }
        public static void CompareSalary(Person p1,Person p2)
        {
            bool compare = true;
            if (p1.WeeklySalary() < p2.WeeklySalary())
            {
                compare = false;
            }
            Console.WriteLine("Dose person1 make more than person2?\n{0}", compare);

        }
    }
}
