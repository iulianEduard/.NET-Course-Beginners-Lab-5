using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp._3in1
{
    public class Toy
    {
        private string name;
        private int buttons;
        private string type;
        public const int nrofbatteries = 2;
        public readonly string material;

        public int Buttons
        {
            get { return buttons; }
            set
            {
                if (value < 2)
                    Console.WriteLine("I need more power!");
                else
                buttons = value;
            }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name { get; set; }

        public Toy()
        {

        }
        public Toy(string toytype,int toybuttons,string toymaterial,string name)
        {
            type = toytype;
            buttons = toybuttons;
            material = toymaterial;
            this.name = name;
        }

        public int Power(int A,int V)
        {
            int P = A * V * nrofbatteries;
            Console.WriteLine(P + "W");
            return P;
        }

        public virtual void Display()
        {
            Console.WriteLine($" Name {name} , Type {type} , Nrofbuttons {buttons}, Material {material}");
        }

        public virtual void Activity()
        {
            Console.WriteLine("This means : walking, driving, flying");
        }
    }

   
}
