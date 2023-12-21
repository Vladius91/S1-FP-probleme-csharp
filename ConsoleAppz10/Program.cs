using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        // Test de primalitate: determinati daca un numar n este prim.

        Console.WriteLine("Introdu un numar n : ");
        int n = int.Parse(Console.ReadLine());



        if (n == 2)
        {
            Console.WriteLine($"Numarul {n} este un numar prim ");
            Environment.Exit(0);
        }

        if (n == 3)
        {
            Console.WriteLine($"Numarul {n} este un numar prim ");
            Environment.Exit(0);
        }

        if (n == 1)
        {
            Console.WriteLine($"Numarul {n} este un numar prim ");
            Environment.Exit(0);
        }

        if (n % 2 == 0)
        {
            Console.WriteLine($"Numarul {n} NU este un numar prim ");

        }
        if (n % 3 == 0)
        {
            Console.WriteLine($"Numarul {n} NU este un numar prim ");

        }
        else Console.WriteLine($"Numarul {n} este Prim");

        
       

    }
    }




