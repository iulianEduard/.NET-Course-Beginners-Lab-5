using System;

namespace Lab5.ConsoleApp.Encapsulation
{
    public class EmployeeWithProperties
    {
        private string empName;
        private int empId;
        private float empCurrPay;
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

        public int Id
        {
            get { return empId; }
            set { if (value % 2 == 0) empId = value; else Console.WriteLine("Not par!"); }
        }

        public float CurrentPay
        {
            get { return empCurrPay; }
            set { empCurrPay = value; }
        }

        public int CNP
        {
            get { return cnp; }
        }

        public EmployeeWithProperties()
        {

        }

        public EmployeeWithProperties(int id, string name, float currentPay)
        {
            Id = id;
            Name = name;
            CurrentPay = currentPay;
        }

        public EmployeeWithProperties(int id, string name, float currentPay, int cnp)
        {
            Id = id;
            Name = name;
            CurrentPay = currentPay;
            this.cnp = cnp;
        }

        public void GiveBonus(float amount)
        {
            empCurrPay += amount;
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
