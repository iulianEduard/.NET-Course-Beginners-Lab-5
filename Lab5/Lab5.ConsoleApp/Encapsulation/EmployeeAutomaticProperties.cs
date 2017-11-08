using System;

namespace Lab5.ConsoleApp.Encapsulation
{
    public class EmployeeAutomaticProperties
    {
        private string empName;
        private int cnp;

        public string Name
        {
            get { return empName; }
            set
            {
                char fistCharacther = value[0];

                if (!char.IsUpper(fistCharacther))
                {
                    Console.WriteLine("Provided name does not begin with capital letter!");
                }
                else if (value.Length > 15)
                {
                    Console.WriteLine("Provided name is longer than 15 caracthers!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        public int Id { get;set; }

        public float CurrentPay { get; set; }

        public int CNP
        {
            get { return cnp; }
        }

        public EmployeeAutomaticProperties()
        {

        }

        public EmployeeAutomaticProperties(int id, string name, float currentPay)
        {
            Id = id;
            Name = name;
            CurrentPay = currentPay;
        }

        public EmployeeAutomaticProperties(int id, string name, float currentPay, int cnp)
        {
            Id = id;
            Name = name;
            CurrentPay = currentPay;
            this.cnp = cnp;
        }

        public void GiveBonus(float amount)
        {
            CurrentPay += amount;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Pay: {CurrentPay}");
        }

        public void DisplayFullStatus()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Pay: {CurrentPay}, CNP: {CNP}");
        }
    }
}
