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
        //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        // regula a + b > c ; a + c > b ; c + b > a ; asa se arata ca 3 laturi pot fi un triunghi


        Console.WriteLine("Introdu un numar a : ");
            int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar b :");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar c :");
        int c = int.Parse(Console.ReadLine());

        if (a + b > c );

        if (a + c > b)
        {
            if (c + b > a) ;
            Console.WriteLine($"Laturile {a} , {b} , {c} , pot fi un triunghi");
        }

        else Console.WriteLine($" Laturile {a} , {b} , {c} NU pot deveni triunghi");
    }
    }


