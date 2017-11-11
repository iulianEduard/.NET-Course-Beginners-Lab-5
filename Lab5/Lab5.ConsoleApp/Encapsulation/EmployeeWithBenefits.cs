using System;

namespace Lab5.ConsoleApp.Encapsulation
{
    public class EmployeeWithBenefits
    {
        public const double raisePercentage = 0.5;

        public readonly double baseSalary;

        public double RaisePercentage
        {
            get { return raisePercentage; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
        }

        public string Name { get; set; }

        public double Salary { get; set; }

        public EmployeeWithBenefits()
        {

        }

        public EmployeeWithBenefits(string name, double salary)
        {
            Name = name;
            baseSalary = salary;
        }

        public void RaiseStandardSalary()
        {
            Salary = (raisePercentage * baseSalary) + baseSalary;
        }

        public void RaiseCustomSalary(double amount)
        {
            Salary += amount;
        }

        public void DispayInitalStatus()
        {
            Console.WriteLine($"Name {Name} earns {baseSalary}");
        }

        public void DispayStatus()
        {
            Console.WriteLine($"Name {Name} earns {Salary}");
        }
    }
}
