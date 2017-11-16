using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    public class Ghiozdan
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Firma { get; set; }
        public string Culoare { get; set; }
        public int Inaltime { get; set; }
        public int Latime { get; set; }
        public double Marime { get; set; }
        public Ghiozdan()
        {

        }
        public Ghiozdan(string name,string material,string firma,string culoare,double marime)
        {
            Name = name;
            Material = material;
            Firma = firma;
            Culoare = culoare;
            Marime = marime;

        }
        public void Display()
        {
            Console.WriteLine($"Ghiozdan {Name} by {Firma}");
            Console.WriteLine($"Material :{Material}");
            Console.WriteLine($"Culoare :{Culoare}");
            Console.WriteLine($"Dimensiuni: {Inaltime} x {Latime}");
            Console.WriteLine($"Marime :{Marime}");

        }
        private double Dimensiuni(int inaltime, int latime)
        {
            return Marime;
        }
        public class Nike : Ghiozdan
        {
            public void Tema()
            {
                Display();
            }
        }
        sealed class Adidas : Ghiozdan
        {
            public Adidas(string name,string firma,string material,string culoare,double marime) : base(name, firma, material,culoare,marime)
            {

            }
        }
    }
}
