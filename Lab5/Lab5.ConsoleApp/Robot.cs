using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    public class Robot
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int NumberOfOrthesis { get; set; }
        public int Buttons { get; set; }
        public string TreadmillSpeed { get; set; }

        public Robot()
        {

        }

        public Robot(string manufacturer, string model, string treadmillSpeed, int numberOfOrthesis, int buttons)
        {
            Manufacturer = manufacturer;
            Model = model;
            TreadmillSpeed = treadmillSpeed;
            NumberOfOrthesis = numberOfOrthesis;
            Buttons = buttons;
        }

        public void Show()
        {
            Console.WriteLine($"Type of the robot: {Manufacturer} {Model}");
            Console.WriteLine($"The speed of the treadmill: {TreadmillSpeed}");
            Console.WriteLine($"Nr of orthesis: {NumberOfOrthesis}");
            Console.WriteLine($"How many buttons are on the device: {Buttons}");
            Console.WriteLine($"Size of the device: {Width * Height} square meter");
        }

    }
    sealed class Robot2 : Robot
    {
        public Robot2(string model, string treadmillSpeed, int numberOfOrthesis, int buttons) : base ("RehabRobot", model, treadmillSpeed, numberOfOrthesis, buttons)
        {

        }

        public double CalculateSize(int Width, int Height)
        {
            return Width * Height;
        }

        public void HowManyButtons(int PlusOneButton)
        {
            {
                if (Buttons == 3)
                    Console.WriteLine("\nThe robot is working properly");
                else if (Buttons < 3)
                    Buttons += PlusOneButton;
                else
                    Console.WriteLine("\nCall the Service Department");
            }

        }


    }

}
