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
        // Afisati toti divizorii numarului n. , and pt 15 sunt 1,3,5, 15 :)

        Console.WriteLine("Introdu un numar n : ");
        int n = int.Parse(Console.ReadLine());

        for (int a = 1; n > a; a++) {

            if (n % a == 0) {
                Console.WriteLine(a);

            }

        }


    }

}


