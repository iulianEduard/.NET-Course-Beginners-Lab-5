using Lab5.ConsoleApp.Encapsulation;
using Lab5.ConsoleApp.Inheritance;
using Lab5.ConsoleApp.Polymorphism;
using System;

namespace Lab5.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritanceExample3();

        }

        #region Encapsulation

        static void EncapsulationWork()
        {
            EmployeeWithProperties employee1 = new EmployeeWithProperties(1, "eduard", 1000);
            employee1.DisplayStatus();

            EmployeeWithProperties employee2 = new EmployeeWithProperties(2, "Eduard", 1000, 123454343);
            //employee2.CNP = 1231231;
            employee2.DisplayFullStatus();

            EmployeeAutomaticProperties employee3 = new EmployeeAutomaticProperties(3, "Iulian", 1500);
            employee3.DisplayStatus();
            employee3.DisplayFullStatus();

            Console.ReadKey();
        }

        static void EncapsulationWork2()
        {
            Point point1 = new Point();
            point1.X = 2;
            point1.Y = 2;
            point1.DisplayStatus();

            Point point2 = new Point(3, 3);
            point2.DisplayStatus();

            Point point3 = new Point() { X = 4, Y = 4 };
            point3.DisplayStatus();

            Console.ReadKey();
        }

        static void EncapsulationWork3()
        {
            EmployeeWithBenefits employee1 = new EmployeeWithBenefits();
            employee1.DispayInitalStatus();
            employee1.DispayStatus();
            employee1.RaiseStandardSalary();
            employee1.DispayStatus();

            EmployeeWithBenefits employee2 = new EmployeeWithBenefits("Eduard", 1000.0);
            employee2.DispayInitalStatus();
            employee2.RaiseStandardSalary();
            employee2.DispayStatus();

            EmployeeWithBenefits employee3 = new EmployeeWithBenefits("Eduard", 1000.0);
            employee3.DispayInitalStatus();
            employee3.RaiseCustomSalary(500.25);
            employee3.DispayStatus();

            Console.ReadKey();
        }

        #endregion Encapsulation

        #region Inheritance

        static void InheritanceExample1()
        {
            Samsung samsung = new Samsung();
            samsung.Display();
            samsung.Manufacturer = "Samsung";
            samsung.Model = "S8";
            samsung.OperatingSystem = "Oreo";
            samsung.ScreenSize = 6.2;
            samsung.RezolutionHeight = 2960;
            samsung.RezolutionWidth = 1440;
            samsung.Display();

            Console.ReadKey();
        }

        static void InheritanceExample2()
        {
            Apple apple = new Apple("iPhone X", "iOS 11", 5.8);
            apple.RezolutionHeight = 2436;
            apple.RezolutionWidth = 1125;
            apple.Display();

            Console.ReadKey();
        }

        static void InheritanceExample3()
        {
            Audi rs7 = new Audi("Audi RS7", 160);
            rs7.IncreaseMaxSpeedTo(200);
            rs7.Display();
            rs7.SpeedUp(20);
            Console.ReadKey();

            Car m4 = new Car("M4", 150);
            m4.SpeedUp(10);
            m4.Display();
            Console.ReadKey();
        }

        #endregion Inheritance

        #region Polymorphism

        static void PolymorphismExample1()
        {
            EmployeeP employee1 = new EmployeeP("Eduard", 2500.75);
            employee1.GiveBonus(100);
            Console.WriteLine($"Emp: {employee1.Name} earns {employee1.Salary}");

            Manager manager1 = new Manager("Iulian", 3000.25);
            employee1.GiveBonus(200);
            employee1.ToString();

            Console.ReadKey();
        }

        static void PolymorphismExample2()
        {
            SciFi sciFi1 = new SciFi("Dark Tower", "Stephan King", 500, 9.8);
            sciFi1.DisplayBook();

            Drama drama1 = new Drama("Enimga Otiliei", "George Calinescu", 230, 8.5);
            drama1.Display();
            drama1.DisplayBook();

            Console.ReadKey();
        }

        #endregion Polymorphism
    }
}
