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
        // Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 


        Console.WriteLine("Introdu un numar a : ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar b : ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu un numar n : ");
        int n = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Introdu un numar n : ");
        //  int n = int.Parse(Console.ReadLine());

        int k = 0;

        

        for (int i = a; i < b + 1; i++)
        {
        if (i % n == 0)
            {
                k = k + 1;
                i++;
            }
        else
            {
                k = 0;   
            }
        }

        if (b < a)
        {
            for (int i = b; i < a + 1; i++)
            {
                if (i % n == 0)
                {
                    k = k + 1;
                    i++;
                }
                else
                {
                    k = 0;
                }
            }

        Console.WriteLine($"in intervalul  {a} pana la {b} totalul de numere divizibile cu {n} este egal cu {k} ");


    }

}
}




