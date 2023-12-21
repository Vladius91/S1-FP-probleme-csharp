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
        // Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 


        Console.WriteLine("Introdu un numar a : ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar b : ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar c : ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar d : ");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar e : ");
        int e = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 4; i++)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

            if (c > d)
            {
                int temp = c;
                c = d;
                d = temp;
            }

            if (d > e)
            {
                int temp = d;
                d = e;
                e = temp;
            }
        }

        Console.WriteLine($"Ordinea cresctoare este {a}, {b}, {c}, {d}, {e}.");








    }


}




