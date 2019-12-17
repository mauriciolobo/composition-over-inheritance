using System;

namespace PMF.InterfaceOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a new Monster -> Horse");
            var horse = new Horse(10);
            Console.WriteLine($"Horse kick damage: {horse.KickDamage}");
        }
    }
}
