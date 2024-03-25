using System.Diagnostics.Tracing;

namespace FizzBuzz;

internal class Program
{
    static void Main(string[] args)
    {
        bool number;
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

        string Result = FizzBuzz.test(gamenumber);

        Console.WriteLine($" \n wynik to : {Result} \n");
    }

}
