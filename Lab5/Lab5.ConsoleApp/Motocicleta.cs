using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    class Motocicleta : Autovehicul
    {
        public Motocicleta(string marca, string model, int numarroti, string tipul, int numarusi) : base(marca, model, numarroti, tipul, numarusi)
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
