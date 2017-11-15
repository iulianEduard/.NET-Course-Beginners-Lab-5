using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Autovehicul
{
    sealed class Motorcycle: Autovehicul
    {
        
        public void Pass()
        {
            Console.WriteLine("1 or 2 persones?");
            string passenger = Console.ReadLine();
            int traveler = Int32.Parse(passenger);
            if (traveler > 2)
                traveler = 2;

            int[] term;
            if (traveler == 1)
                term = new int[1];
            else
                term = new int[2];

            for (int i = 0; i < term.Length; i++)
            {
                term[i] = i;
            }

            foreach (int i in term)
            {
                StopAndShop();
            }
        }

        public void StopAndShop()
        {
            Console.WriteLine("Choose your helmet. Are you a boy or a girl?");
            string person = Console.ReadLine();
            switch (person)
            {
                case "boy":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "girl":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
            }
            
        }
    }
}
