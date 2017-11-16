using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Alg
{
    public class Algoritm
    {
         public void Average(params double[] val)
         {
             double numaruldenumere = val.Length;
             double sumaponderi = 0;
             double numarator = 0;
             double produs = 1;
             double mponder = 0;
             double mgeom = 0;


            

             for(int i =0; i<val.Length;i++)
             {
                Console.WriteLine("i = {0}",i);
                Console.WriteLine("val[i] = {0}", val[i]);

                 sumaponderi += i;
                numarator += val[i] * i;
                 produs = produs * val[i];

             }


             Console.WriteLine("Suma ponderilor {0}, numarator {1}, produs {2}",sumaponderi,numarator,produs);

             mponder = numarator / sumaponderi;
             Console.WriteLine("Media ponderata : {0}", mponder);

            Console.WriteLine(val.Length);
            int l = val.Length;
             double a = 1 / l;
            
            Console.WriteLine(a);
             mgeom = Math.Pow(produs, (1 / val.Length));
             Console.WriteLine("Media geometrica : {0}", mgeom);

            
         }
         

        public void Verif(params int [] numbers)
        {
          
            Console.WriteLine("Introduceti numarul pe care doriti sa il cautati");
            string x1 = Console.ReadLine();
            int n = Int32.Parse(x1);
        
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    Console.WriteLine("Numarul cautat se gaseste pe pozitia {0}", i);
                }
            }

        }


        public int VerifNrPrim(int n)
        {

            int x = 0;

            if (n == 0 || n == 1)
            {
                Console.Write(n);
                Console.WriteLine(" Numarul trebuie sa fie diferit de 0 si 1");
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        x++;
                    }

                }
                if (x == 0)
                {

                    
                    return 1;
                }
                else
                {

                   
                    return 0;
                }

            }
            return 2;

        }

        public void SumaNrPrim()
        {
            int s = 0;
            {
                for (int i = 2; i <= 100; i++)
                {
                    if (VerifNrPrim(i) == 1)
                    {
                        Console.WriteLine("i : {0}",i);
                        for (int j = 2; j <= 100; j++)
                        {
                            if (VerifNrPrim(j) == 1)
                            {
                                Console.WriteLine("j : {0}", j);
                                s = i + j;
                                if (s % 2 == 0)
                                    Console.WriteLine("i+j = {0}" ,s);

                            }
                        }
                    }

                }

            }
        }

    }
}
