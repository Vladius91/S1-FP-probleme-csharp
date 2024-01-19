using System;
using System.Collections.Generic;

class Program
{
    //Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

    static void Main()
    {
        Console.WriteLine("Introduceti un numar:");
        int numar = int.Parse(Console.ReadLine());

        if (AreDoarDouaCifreRepetate(numar))
        {
            Console.WriteLine($"{numar} este format doar cu doua cifre care se pot repeta.");
        }
        else
        {
            Console.WriteLine($"{numar} nu este format doar cu doua cifre care se pot repeta.");
        }
    }

    static bool AreDoarDouaCifreRepetate(int n)
    {
        List<int> cifre = new List<int>();

        while (n > 0)
        {
            int cifra = n % 10;

            
            if (!cifre.Contains(cifra))
            {
                cifre.Add(cifra);
            }

            n = n / 10;
        }

       
        return cifre.Count == 2;
    }
}
