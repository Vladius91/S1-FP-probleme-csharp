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
        Console.WriteLine("Introduceti doua numere:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int cmmd = CalculCMMD(num1, num2);
        int cmmmc = CalculCMMMC(num1, num2, cmmd);

        Console.WriteLine($"Cel mai mare divizor comun al celor doua numere este: {cmmd}");
        Console.WriteLine($"Cel mai mic multiplu comun al celor doua numere este: {cmmmc}");
    }

    // Algoritmul lui Euclid pentru calcularea celui mai mare divizor comun
    static int CalculCMMD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Calcularea celui mai mic multiplu comun folosind relatia CMMD * CMMMC = |a * b|
    static int CalculCMMMC(int a, int b, int cmmd)
    {
        return Math.Abs(a * b) / cmmd;

    }
    }



