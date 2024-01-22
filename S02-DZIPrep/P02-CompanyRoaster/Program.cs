using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CompanyRoaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Employee employee = new Employee(input[0], double.Parse(input[1]), input[2]);
                employees.Add(employee);
            }
            var highestSalary = employees.GroupBy(x => x.Department);
        }
    }
    public class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
