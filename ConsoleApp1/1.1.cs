using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1 Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 

            Console.WriteLine("Introdu un numar `a`: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Introdu un numar `b`: ");
            double b = double.Parse(Console.ReadLine());


            if(a == 0) {
                Console.WriteLine("x NU poate fi determinat fiindca a = 0, oriicare ar fi x = n, ecuatia ax+b = 0");
            } 

            if(b == 0) { Console.WriteLine("fiindca b = 0, oricare ar fi x = n, trebuie si a = 0 pentru ca ecuatia ax+b = 0 sa fie adevarata"); }


            else {

                double x = -b / a;
                Console.WriteLine($"Pentru ecuatia {a}*x + {b} = 0, rezultatul lui x este= {x}  ");
            }
        }
    }
}