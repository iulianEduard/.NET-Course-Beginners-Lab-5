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
            Salary += amount * 0.02;
        }

        //public override void GiveBonus(double amount)
        //{
        //    base.GiveBonus(amount);
        //    Console.WriteLine($"Employee {Name} earns {Salary}");
        //}

        public override string ToString()
        {
            return $"Object -> Employee {Name} earns {Salary}";
        }
    }

    public class Accounting  : EmployeeP
    {
        public Accounting(string name, double salary) : base(name, salary)
        {

        }

        public override void GiveBonus(double amount)
        {
            base.GiveBonus(amount);
        }
    }
}
