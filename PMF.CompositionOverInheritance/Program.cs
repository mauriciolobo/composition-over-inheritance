using System;

namespace PMF.CompositionOverInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a new Monster -> Horse");
            var horse = MonsterFactory.CreateMonster(MonsterType.Horse);
            Console.WriteLine($"Horse kick damage: {horse.KickDamage}");
            Console.WriteLine($"Horse punch damage: {horse.PunchDamage}");  // <--- Exception
        }
    }
}
