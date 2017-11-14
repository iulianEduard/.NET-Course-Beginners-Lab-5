using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    public class Autovehicul
    {
        public string Type { get; set; }
        public int NrRoti { get; set; }
        public int NrUsi { get; set; }
        public int VitezaNormala { get; set; }
        public int VitezaMax { get; set; } = 100;

        public Autovehicul()
        {

        }
        public Autovehicul(string type, int nrroti, int nrusi, int vitezanormala, int vitezamax)
        {
            NrRoti = nrroti;
            Type = type;
            NrUsi = nrusi;
            VitezaNormala = vitezanormala;
            VitezaMax = vitezamax;
        }
        public void Show()
        {
            Console.WriteLine($"Modelul nou {Type} prinde viteza maxima {VitezaMax} Km/h");
        }
        public void SetCaiPutere(int alfa)
        {
            VitezaMax += alfa;
        }
    }
    public class Tir : Autovehicul
    {
        

        public Tir(string type, int nrroti, int vitezanormala, int vitezamax, int nrusi) : base(type, nrroti, nrusi, vitezanormala, vitezamax )
        {

        }
        public void CresteViteza(int beta)
        {
            if(VitezaNormala + beta >= VitezaMax)
            {
                Console.WriteLine($"Autovehicul {Type} a atins viteza maxima de {VitezaMax}");
            }
            else
            {
                Console.WriteLine($"Autovehicul {Type} merge cu o viteza normala");
            }
        }

        
    }

}
