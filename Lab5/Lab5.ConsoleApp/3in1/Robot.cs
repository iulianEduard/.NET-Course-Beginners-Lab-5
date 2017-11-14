using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp._3in1
{
    sealed class Robot:Toy
    {
        public Robot(string Type, int Button, string Material, string Name) : base("Robot", Button, Material, Name)
        {
        }
       

        public void SetName(string nume)
        {
            Console.WriteLine("This toy is a robot");
            Console.WriteLine("Set its name");

            Name = nume;
            Console.WriteLine("Its name is {0}",nume);

            Console.WriteLine("This robot needs this power to function properly");
            Power(6,8);
   

        }

        public override void Activity()
        {
            base.Activity();
            Console.WriteLine("This robot is Walking");
        }

    }


}
