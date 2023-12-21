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
        // Se dau 3 numere. Sa se afiseze in ordine crescatoare. 


        Console.WriteLine("Introdu un numar a : ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar b : ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar c : ");
        int c = int.Parse(Console.ReadLine());

        int[] j = { a, b, c };

        Console.Write(" Ordinea initiala ");
        foreach (var item in j)
        {
           

            Console.Write(item + " ");
        }

        if (a < b && b < c)
        {
            (j[0], j[1], j[2]) = (j[0], j[1], j[2]);
        }

        if (a < b && c < b)
        {
            (j[0], j[1], j[2]) = (j[0], j[2], j[1]);
        }

        if (b < a && a < c)
        {
            (j[0], j[1], j[2]) = (j[1], j[0], j[2]);
        }

        if (b < a && c < a)
        {
            (j[0], j[1], j[2]) = (j[1], j[2], j[0]);
        }

        if (c < b && a < b)
        {
            (j[0], j[1], j[2]) = (j[2], j[0], j[1]);
        }

        if (c < b && a < b)
        {
            (j[0], j[1], j[2]) = (j[2], j[1], j[0]);
        }

        Console.Write(" Ordinea crescatore ");
        foreach (var item in j)
        {
           
            Console.Write(item + " ");
        }





    }


}




