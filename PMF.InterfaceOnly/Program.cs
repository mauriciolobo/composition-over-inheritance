using System;
using PMF.InterfaceOnly.Hero;
using PMF.InterfaceOnly.Monster;

namespace PMF.InterfaceOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a new Monster -> Horse");
            var horse = new Horse(10);
            Console.WriteLine($"Horse kick damage: {horse.KickDamage}");

            Console.WriteLine("Creating a new Hero -> Guile");
            var guile = new Guile(10);
            Console.WriteLine($"Guile kick damage: {guile.KickDamage}");
        }
    }
}
