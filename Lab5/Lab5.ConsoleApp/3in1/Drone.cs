using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp._3in1
{
    public class Drone: Plane
    {
        public override void Activity()
        {
            base.Activity();
            Console.WriteLine("The drone is Flying too");
        }
    }
}
