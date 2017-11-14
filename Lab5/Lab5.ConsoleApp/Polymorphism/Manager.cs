using System;

namespace Lab5.ConsoleApp.Polymorphism
{
    public class Manager : EmployeeP
    {
        public Manager()
        {

        }

        public Manager(string name, double salary): base(name, salary)
        {

        }

        public override void GiveBonus(double amount)
        {
            base.GiveBonus(amount);
            Console.WriteLine($"Employee {Name} earns {Salary}");
        }

        public override string ToString()
        {
            return $"Object -> Employee {Name} earns {Salary}";
        }

    }
}
