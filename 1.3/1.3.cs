using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determinati daca n se divide cu k, unde n si k sunt date de intrare. , (adc n este multiplu de k)

            Console.WriteLine("Introdu un numar `n`: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu un numar `k`: ");
            int k = int.Parse(Console.ReadLine());

            if( n % k == 0) {
                Console.WriteLine("Pentru numerele introduse anterior: n se divide cu k");
            }
            else
            {
                Console.WriteLine("Pentru numerele introduse anterior: n NU se divide cu k");

            }
        }
    }
}