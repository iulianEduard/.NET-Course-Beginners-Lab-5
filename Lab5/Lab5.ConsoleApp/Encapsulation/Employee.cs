using System;

namespace Lab5.ConsoleApp.Encapsulation
{
    public class Employee
    {
        //Field data
        private string empName;
        private int empId;
        private float empCurrPay;

        //Constructors
        public Employee()
        {

        }

        //Methods
        public Employee(int id, string name, float currentPay)
        {
            empId = id;
            empName = name;
            empCurrPay = currentPay;
        }

        public void GiveBonus(float amount)
        {
            empCurrPay += amount;
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"ID: {empId}, Name: {empName}, Pay: {empCurrPay}");
        }

        public string GetName()
        {
            return empName;
        }

        public void SetName(string name)
        {
            char fistCharacther = name[0];

            if(!char.IsUpper(fistCharacther))
            {
                Console.WriteLine("Provided name does not begin with capital letter!");
            }
            else if(name.Length > 15)
            {
                Console.WriteLine("Provided name is longer than 15 caracthers!");
            }
            else
            {
                empName = name;
            }
        }
    }
}
