using System;

namespace Lab5.ConsoleApp.Inheritance
{
    public class Car
    {
        public string Name { get; set; }

        public int CurrentSpeed { get; set; }

        protected int MaxSpeed { get; set; } = 150;

        public Car()
        {

        }

        public Car(string name, int currentSpeed)
        {
            Name = name;
            CurrentSpeed = currentSpeed;
        }

        public void SpeedUp(int delta)
        {
            if (CurrentSpeed + delta <= MaxSpeed)
            {
                CurrentSpeed += delta;
            }
            else
            {
                Console.WriteLine($"Vehicle {Name} has reached max speed: {MaxSpeed}");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Vehicle {Name} is going {CurrentSpeed}");
        }
    }

    public class Audi : Car
    {
        public Audi(string name, int currentSpeed) : base(name, currentSpeed)
        {

        }

        public void IncreaseMaxSpeedTo(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }
    }
}
