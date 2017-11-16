using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    public class Autovehicul
    {
        public string Make { get; set; }
        public string Engine { get; set; }
        public int NumberOfDoors { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public double CurrentValue { get; set; }

        public Autovehicul(string make, string engine, int numberOfDoors, string color, string year, double currentValue)
        {
            Make = make;
            Engine = engine;
            NumberOfDoors = numberOfDoors;
            Color = color;
            Year = year;
            CurrentValue = currentValue;
        }
        public double GetCurrentValue()
        {
            return CurrentValue;
        }
        public string GetYear()
        {
            return Year;
        }

        public void Display()
        {
            Console.WriteLine($"Autovehiculul {Make} cu motor : {Engine} are {NumberOfDoors} usi");
            Console.WriteLine($"Autovehiculul e din {Year} si valoreaza {CurrentValue}");
        }
    
        
    }  
}

