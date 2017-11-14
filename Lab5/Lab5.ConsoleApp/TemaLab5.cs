using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    public class Copil
    {
        public string Nume { get; set; }
        private string Prenume { get; set; }
        public int Varsta { get; set; }
        public int Scoala { get; set; }
        public int Clasa { get; set; }


        public Copil()
        {

        }

        public Copil(string nume, string prenume, int varsta, int scoala, int clasa)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Scoala = scoala;
            Clasa = clasa;
        }

        public void Show()
        {
            Console.WriteLine($"{Nume} {Prenume} are varsta {Varsta} ani");
            Console.WriteLine($"Scoala: {Scoala} in clasa {Clasa}");
        }

        private void SetScoala( int alfa)
        {
            Varsta += alfa;
        }

    }
    public class Baiat : Copil
    {
        public Baiat(string nume, string prenume, int varsta, int scoala, int clasa) : base (nume, prenume, varsta, scoala, clasa)
        {

        }
        public void ShowMe()
        {
            Show();
        }

        public override string ToString()
        {
            Console.WriteLine("Verificare clasa Baiat ");
            Console.WriteLine($"{Nume} are varsta {Varsta} ani");
            return base.ToString();
            Console.WriteLine($"Scoala: {Scoala} in clasa {Clasa}");
        }
    }

    public class Fata : Copil
    {
        public Fata(string nume, string prenume, int varsta, int scoala, int clasa) : base (nume, prenume, varsta, scoala, clasa)
        {

        }
        public void Show()
        {
            Console.WriteLine("Varificare clasa Fata");
            Console.WriteLine($"{Nume} are varsta {Varsta} si merge la Scoala {Scoala} si este in clasa {Clasa}");
        }
    }

    
}
