using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Autovehicul
{
   sealed class Truck:Autovehicul
    {

        public void HighWay()
        {
            if (Weight > 4500 || Speed>110)
            {
                Speed = 110;
                Console.WriteLine(" Max speed is 110 km/h ");
            }
            else
                Console.WriteLine("Your speed is in limits");
        }

        public void Resting()
        {
            Console.WriteLine("For how many hours have you been driving ? ");
            string hours = Console.ReadLine();
            int x = Int32.Parse(hours);
            if(x>=12)
                Console.WriteLine("Time for you to rest");
            else
                Console.WriteLine("Go go go");
          
        }

        public void Charge()
        {
            Console.WriteLine("You are shipping books");
            Weight = 2200.22;
        }

        public override void Display()
        {
            Console.WriteLine("I am the master of the trucks");
            base.Display();
        }
    }
}
