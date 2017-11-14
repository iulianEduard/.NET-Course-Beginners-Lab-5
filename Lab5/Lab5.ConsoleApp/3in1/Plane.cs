using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp._3in1
{
    public class Plane : Toy
    {
        private int engine;

        public void Engine(int nrofengine)
        {
            engine = nrofengine;
        }
        public override void Activity()
        {
            base.Activity();
            Console.WriteLine("The plane is Flying");
        }
    }
}
