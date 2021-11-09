using System;

namespace GamblingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to the Gambler Program");
            Gambler gambler = new Gambler();
            gambler.Betting();
        }
    }
}
