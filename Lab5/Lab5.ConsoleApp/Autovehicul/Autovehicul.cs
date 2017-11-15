using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Autovehicul
{
    public  class Autovehicul
    {
        private int nrwheels;
        private int speed;
        private string gearbox;
        private string brand;
        private string fuel;
        private double weight;

        public int Nrwheels
        {
            get { return nrwheels; }
            set
            {
                if (value < 2)
                {
                    Console.WriteLine(" You're walking, let me fix that for you ");
                    nrwheels = 2;
                    Console.WriteLine("Here! Take my motorcicle");
                }
                else
                    nrwheels = value;

            }

        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Gearbox
        {
            get { return gearbox; }

            /*  set
              {
                  switch (gearbox)
                  {
                      case "Manual":
                          {
                              gearbox = value;
                              Console.WriteLine("Manual. You are a good driver is good");
                          }
                          break;
                      case "Automatic":
                          {
                              gearbox = value;
                              Console.WriteLine("Automatic. This is easier");
                          }
                          break;
                      default:
                          {
                              gearbox = value;
                              Console.WriteLine("Maybe you invented a new gearbox");
                          }
                          break;

                  }
              } */

            set { gearbox = value; }
        }
        

        public string Brand
        {
            get { return brand;}
            set { brand = value; }
        }
        
        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Autovehicul()
        {
        }

        
        public Autovehicul(int nrwheels,int speed, string gearbox, string brand, string fuel,double weight)
        {
            this.nrwheels = nrwheels;
            this.speed = speed;
            this.gearbox = gearbox;
            this.brand = brand;
            this.fuel = fuel;

        }

        

        public  void Driving()
        {
            Console.WriteLine(" For how many years have you been driving ? ");
            string type = Console.ReadLine();
            Console.WriteLine("You have been driving for {0} years",type);

        }

       

        public virtual void Display()
        {
            Console.WriteLine("Nrwheels {0}, Speed {1}, Gearbox {2}, Brand {3}, Fuel {4}, Weight{5}",nrwheels,speed,gearbox,brand,fuel,weight);
        }

    }
}
