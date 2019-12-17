using System;
using PMF.CompositionOverInheritance.Hero;
using PMF.CompositionOverInheritance.Monster;

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

            Console.WriteLine("Creating a new Hero -> Guile");
            var guile = HeroFactory.CreateHero(HeroType.Guile);
            Console.WriteLine($"Guile kick damage: {guile.KickDamage}");
            Console.WriteLine($"Guile Tektektuguem damage: {guile.TektektuguemDamage}");  // <--- Exception
        }
    }
}
