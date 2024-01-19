using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti un numar:");
        int numar = int.Parse(Console.ReadLine());

        if (EstePalindrom(numar))
        {
            Console.WriteLine($"{numar} este palindrom.");
        }
        else
        {
            Console.WriteLine($"{numar} nu este palindrom.");
        }
    }

    static bool EstePalindrom(int n)
    {
        int numarInitial = n;
        int invers = 0;

        while (n > 0)
        {
            int cifra = n % 10;
            invers = invers * 10 + cifra;
            n = n / 10;
        }

        return (invers == numarInitial);
    }
}