using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    class Autobuz : Autovehicul
    {
        public Autobuz() : base()
        {

        }
        public override void GetFromInput()
        {
            base.GetFromInput();
            Console.WriteLine("introduceti tipul de autovehicul:");
            Tipul = Console.ReadLine();
        }
    }
}
