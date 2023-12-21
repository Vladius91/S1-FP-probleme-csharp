using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        // Afisati in ordine inversa cifrele unui numar n. 


       int n;
       int reverse = 0;
       int rem;
        Console.Write("Introdu un numar: ");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            rem = n % 10;
            reverse = reverse * 10 + rem;
            n /= 10;
        }
        Console.Write("Numarul inversat: " + reverse);




    
    }
}







    






