using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class _1
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 

            Console.WriteLine("Introdu un numar `a`: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu un numar `b`: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu un numar `c`: ");
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                double x = -c / b;
                Console.WriteLine($" Pentru ecuatia  ax^2 + bx + c = 0, a = 0; x = {x}");

            }

            

            else
            {


                // calculam delta
                int delta = (b * b) - (4 * a * c);

                if (delta == 0) {
            int  x = -b/2*a;
                    Console.WriteLine($" Pentru ecuatia  ax^2 + bx + c = 0, daca delta = 0 valorea lui x = {x}");
                }
                if (delta < 0)
                {
                    Console.WriteLine($" x va avea valori complexe");

                }


                int deltasqrt = (int)Math.Sqrt(delta);

                int x1 = (-b + deltasqrt) / 2 * a;
                int x2 = (-b - deltasqrt) / 2 * a;

                Console.WriteLine($" Pentru ecuatia  ax^2 + bx + c = 0 valorile lui x sunt de x1 = {x1} si x2 = {x2}");
            }

        }
    }
}
