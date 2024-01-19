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


        static void Main()
        {
            Console.WriteLine("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Descompunerea in factori primi a numarului {n} este:");
            AfisareDescompunereFactoriPrimi(n);
        }

        static void AfisareDescompunereFactoriPrimi(int numar)
        {
            for (int i = 2; i <= numar; i++)
            {
                int putere = 0;

                while (numar % i == 0)
                {
                    putere++;
                    numar /= i;
                }

                if (putere > 0)
                {
                    Console.Write($"{i}^{putere} ");

                    if (numar > 1)
                    {
                        Console.Write("x ");
                    }
                }
            }
        }
    }
}           
           




