
namespace Lab5.ConsoleApp.Polymorphism
{
    public class EmployeeP
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public EmployeeP()
        {

        }

        public EmployeeP(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void GiveBonus(double amount)
        {
            Salary += amount;
        }
    }
}
