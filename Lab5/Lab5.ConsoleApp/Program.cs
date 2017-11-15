using Lab5.ConsoleApp.Encapsulation;
using Lab5.ConsoleApp.Inheritance;
using Lab5.ConsoleApp.Polymorphism;
using Lab5.ConsoleApp._3in1;
using Lab5.ConsoleApp.Autovehicul;
using System;

namespace Lab5.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // DrivingTest();
           // PlayTime();
            Console.ReadKey();
        }

        static void PlayTime()
        {
            Toy toy1 = new Toy("6+", 4, "Plastic", "Batman");
            toy1.Power(2, 4);
            toy1.Activity();
            toy1.Display();

            Toy toy2 = new Toy();
            toy2.Type = "3+";
            toy2.Buttons = 1;
            toy2.Name = "Duck";
            toy2.Power(0,0);
            toy2.Display();

            Toy toy3 = new Toy() { Name = "Drupy, the master detective", Buttons = 10, Type = "Monkey" };
            toy3.Display();
        
       
            Robot robot = new Robot("10+", 1, "Plastic", "Robocop");
            robot.SetName("Doctor Who");
            robot.Activity();

            Plane plane = new Plane();
            plane.Activity();
            plane.Engine(4);
            
            Drone drone = new Drone();
            drone.Activity();
            drone.Engine(8);
            
        }


        static void DrivingTest()
        {
            Truck truck = new Truck() { Nrwheels = 8, Weight = 5000, Brand = "Papa Bear", Fuel = "Gas", Speed = 197, Gearbox = "Manual" };
          
           // truck.Charge();
          //  truck.HighWay();
          //  truck.Resting();
          //  truck.Driving();
            truck.Display();
            

           
            Truck truck1 = new Truck();
            truck1.Gearbox = "Automatic";
            truck1.Fuel = "Gas";
            truck1.Brand = "VVV";
            truck1.Nrwheels = 8;
            truck1.Weight = 9000;
            truck1.Speed = 100;
            truck1.Resting();
            truck1.Display();
            

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Brand = "Victory";
            motorcycle.Fuel = "Diesel";
            motorcycle.Gearbox = "Automatic";
            motorcycle.Nrwheels = 2;
            motorcycle.Speed = 160;
            motorcycle.Weight = 600;
            motorcycle.Pass();
            motorcycle.Display();
            
            
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
