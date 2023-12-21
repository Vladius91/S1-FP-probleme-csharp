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
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 


            Console.WriteLine("Introdu un numar: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Al catelea numar de la dreapta la stanga doresti sa il vezi afisat?");
            int n = int.Parse(Console.ReadLine());

            double putere = Math.Pow(10, n);

            double rezultatLung = k % putere;   

           double putereMinusUnu = Math.Pow(10, n-1);

            double imp = rezultatLung / putereMinusUnu;

           int rezultatFin = Convert.ToInt32(imp);
            Console.WriteLine($"Al {n} numar este {rezultatFin}");

        }
    }

    }

