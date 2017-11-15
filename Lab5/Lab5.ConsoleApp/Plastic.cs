using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    public class Plastic
    {
        public string Producator { get; set; }

        public string Culoare { get; set; }

        public int Butoane { get; set; }

        

        public Plastic()
        {

        }

        public Plastic(string producator, string culoare, int butoane, )
        {
            Producator = producator;
            Culoare = culoare;
            Butoane = butoane;
            
        }

        public void Display()
        {
            Console.WriteLine($"Plastic {Producator} {Culoare}");
            
            Console.WriteLine($"Butoane: {Butoane}");
            
        }

        
    }

    public class Mouse : Plastic
    {
    }

    public class Toshiba : Plastic
    { 
        public Toshiba(string producator, string culoare, int butoane) : base(producator,culoare,butoane)
        {
        }

        

        }
}
