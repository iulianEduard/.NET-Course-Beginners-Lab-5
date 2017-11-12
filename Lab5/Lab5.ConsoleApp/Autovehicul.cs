using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    class Autovehicul
    {
        string marca, model;
        int numarroti;
        string tipul;
        int numarusi;

        public string Marca { get { return marca; } set { marca = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int NumarRoti { get { return numarroti; } set { numarroti = value; } }
        public string Tipul { get { return tipul; } set { tipul = value; } }
        public int NumarUsi { get { return numarusi; } set { numarusi = value; } }

        public Autovehicul()
        {
            marca = model = "Audi";
            numarroti = 4;
            tipul = "A4";
            numarusi = 4;

        }

        public Autovehicul(string marca, string model, int numarroti, string tipul, int numarusi)
        {
            this.marca = marca;
            this.model = model;
            this.numarroti = numarroti;
            this.tipul = tipul;
            this.numarusi = numarusi;
        }

        public virtual void GetFromInput()
        {
            Console.WriteLine("introduceti marca auto:");
            marca = Console.ReadLine();
            Console.WriteLine("introduceti modelul auto:");
            model = Console.ReadLine();
            Console.WriteLine("introduceti numar de roti:");
            numarroti = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti tipul de autovehicul:");
            tipul = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de usi:");
            numarusi = int.Parse(Console.ReadLine());
        }

       

            



        }
}

