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
        // (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.

                Console.WriteLine("Introdu un numar a : ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar b :");
        int b = int.Parse(Console.ReadLine());
        (a, b) = (b, a);

        Console.WriteLine($" Acum a = {a} si b = {b}");



    }

}


