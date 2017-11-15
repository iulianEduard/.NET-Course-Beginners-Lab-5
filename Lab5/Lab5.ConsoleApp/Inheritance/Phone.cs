using System;

namespace Lab5.ConsoleApp.Inheritance
{
    public class Phone
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string OperatingSystem { get; set; }

        public double ScreenSize { get; set; }

        public int RezolutionHeight { get; set; }

        public int RezolutionWidth { get; set; }

        public Phone()
        {

        }

        public Phone(string manufacturer, string model, double screenSize, string operatingSystem)
        {
            Manufacturer = manufacturer;
            Model = model;
            ScreenSize = screenSize;
            OperatingSystem = operatingSystem;
        }

        public void Display()
        {
            Console.WriteLine($"Phone {Manufacturer} {Model}");
            Console.WriteLine($"Operating system: {OperatingSystem}");
            Console.WriteLine($"Screen size: {ScreenSize}");
            Console.WriteLine($"Rezolution: {RezolutionWidth} x {RezolutionHeight}");
            Console.WriteLine($"Aspect ratio: {RezolutionWidth / CalculateAspectRatio(RezolutionWidth, RezolutionHeight)} : {RezolutionHeight / CalculateAspectRatio(RezolutionWidth, RezolutionHeight)}");
        }

        private double CalculateAspectRatio(int width, int height)
        {
            return (height == 0) ? width : CalculateAspectRatio(width, width % height);
        }
    }

    public class Samsung : Phone
    {
        public void DoWork()
        {
            Display();
        }
    }

    sealed class Apple : Phone
    {
        public Apple(string model, string operatingSystem, double screenSize) : base("Apple", model, screenSize, operatingSystem)
        {
        }

        public void SetScreenRezolution(int height, int width)
        {
            RezolutionHeight = height;
            RezolutionWidth = width;
        }
        
    }
}
