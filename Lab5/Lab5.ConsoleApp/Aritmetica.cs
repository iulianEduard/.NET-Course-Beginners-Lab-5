using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp
{
    public class Aritmetica
    {
        public void MediaGeometrica()
        {
            int marimeasirului = 0;
            Console.WriteLine("Introduceti marimea sirului: ");
            marimeasirului = Convert.ToInt32(Console.ReadLine());
            int numereleInmultite = 1;            
            int i = 0;

            while(i < marimeasirului)
            {
                Console.WriteLine("Introduceti urmatorul numar: ");
                int numarulCitit = Convert.ToInt32(Console.ReadLine());
                numereleInmultite = numereleInmultite * numarulCitit;                
                i++;
            }            
            double mediaAritmetica = Math.Sqrt(numereleInmultite);
            Console.WriteLine("Media geometrica este:" + mediaAritmetica);
            Console.ReadLine();            
        }

        public void MediaPonderala()
        {
            int marimeasirului = 0;
            int sumaNumerelor = 0;
            Console.WriteLine("Introduceti marimea sirului: ");

            marimeasirului = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Introduceti numerele: ");

            for (int i = 0; i < marimeasirului; i++)
            {
                Console.WriteLine("Introduceti urmatorul numar: ");
                int numarulCitit = Convert.ToInt32(Console.ReadLine());
                sumaNumerelor += numarulCitit;
            }

            double mediaPonderata = sumaNumerelor / marimeasirului;
            Console.WriteLine("Media ponderilor este: " + mediaPonderata);
            Console.ReadLine();
        }

        public void IndexArray(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    Console.WriteLine(i); ;
                }
            }
            foreach (int c in array)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
        }

        public void Primenumbers()
        {
            
            Console.WriteLine("Numerele prime sunt: ");
            for (int i = 2; i <= 100; i++)
            {
                int EstePrim = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        EstePrim++;                        
                    }
                    if (EstePrim == 2)
                        break;
                }
                if (EstePrim != 2)
                    {
                    Console.WriteLine(i);
                }
                EstePrim = 0;


            }

            Console.ReadLine();

        }
    }
}
