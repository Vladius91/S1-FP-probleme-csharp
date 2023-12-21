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
            // Detreminati daca un an y este an bisect. 

            Console.WriteLine("Introdu un an: ");
                 int n = int.Parse(Console.ReadLine());

            if (n % 4 == 0 ) {
                Console.WriteLine("Acest an este bisect. ");
            }
            else
            {
                Console.WriteLine("Acest an NU este bisect. ");


            }
        }

    }
    }
