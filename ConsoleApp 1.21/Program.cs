using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ghiceste un numar intre 1 si 1024!");
        int guess = GuessNumber(1, 1024);
        Console.WriteLine($"Numarul ghicit este: {guess}");
    }

    static int GuessNumber(int lowerBound, int upperBound)
    {
        int guess;
        string input;

        do
        {
          
            guess = (lowerBound + upperBound) / 2;

            Console.Write($"Numarul este mai mare sau egal decat {guess}? (da/nu): ");
            input = Console.ReadLine();

            if (input.ToLower() == "da")
            {
          
                lowerBound = guess + 1;
            }
            else if (input.ToLower() == "nu")
            {
                upperBound = guess - 1;
            }
            else
            {
                Console.WriteLine("Te rog sa raspunzi cu 'da' sau 'nu'.");
            }

        } while (lowerBound <= upperBound);

        return guess;
    }
}
