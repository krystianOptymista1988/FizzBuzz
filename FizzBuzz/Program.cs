using System.Diagnostics.Tracing;

namespace FizzBuzz;

internal class Program
{
    static void Main(string[] args)
    { bool number;
        int gamenumber;
        Console.WriteLine("Witaj w grze FizzBuzz\n \n podaj liczbę");
        do
        {
            string words = Console.ReadLine();
            if (number = int.TryParse(words, out gamenumber))
            {

            }
            else
            {
                number = false;
                Console.WriteLine("podaj liczbę całkowitą");
            }
        }
        while (!number);

        string Result = FizzBuzz(gamenumber);

        Console.WriteLine($" \n wynik to : {Result} \n");
    }

    static string FizzBuzz(int gamenumber) 
    {
        int checkFizz = gamenumber % 3;
        int checkBuzz = gamenumber % 5;
 
        if (checkFizz == 0 && checkBuzz == 0)
            return ("FizzBuzz");
        else if (checkBuzz == 0)
            return ("Buzz");
        else if (checkFizz == 0) return ("Fizz");

        else 
        {
            return (gamenumber.ToString()); }
    }
}
