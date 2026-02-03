using System;
using Charakter_sheet;

namespace Charakter_sheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w Horde Holder!");

            // Przykładowe użycie klasy Charakter
            Charakter bohater = new Charakter(10, 12, 8, 14, 16, 10, 1, 8, 30);
            Console.WriteLine($"Bohater: Int={bohater.Int}, Str={bohater.Str}, Dex={bohater.Dex}");

            // Przykładowy rzut kostką
            Dice dice = new Dice();
            int roll = dice.roll(20);
            Console.WriteLine($"Rzut d20: {roll}");

            Console.ReadLine(); // Aby nie zamknęło się od razu
        }
    }
}