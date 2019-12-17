using System;
using PMF.CompositionOverInheritance.Hero;
using PMF.CompositionOverInheritance.Monster;

namespace PMF.CompositionOverInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Creating a new Monster -> Horse");
            //var horse = MonsterFactory.CreateMonster(MonsterType.Horse);
            //Console.WriteLine($"Horse kick damage: {horse.KickDamage}");
            //Console.WriteLine($"Horse punch damage: {horse.PunchDamage}");  // <--- Exception

            //Console.WriteLine("Creating a new Hero -> Guile");
            //var guile = HeroFactory.CreateHero(HeroType.Guile);
            //Console.WriteLine($"Guile kick damage: {guile.KickDamage}");
            //Console.WriteLine($"Guile Tektektuguem damage: {guile.TektektuguemDamage}");  // <--- Exception

            var ken = new Ken();
            ken.Punch();
            ken.Kick();
            ken.Tektektuguem();
            //ken.yogaFire(); -- Ken doesn't' have yogaFire

            var dhalsim = new Dhalsim();
            dhalsim.Punch();
            dhalsim.Kick();
            dhalsim.YogaFire();
            //dhalsim.Tektektuguem(); -- Dhalsim doesn't have tektektuguem!
        }
    }

    internal class Ken
    {
        public Action Punch = GameAttacks.BasicAttack("Punch", "Ken", 8);
        public Action Kick = GameAttacks.BasicAttack("Kick", "Ken", 10);
        public Action Tektektuguem = GameAttacks.Tektektuguem("Ken", 20);
    }

    internal class Dhalsim
    {
        public Action Punch = GameAttacks.BasicAttack("Punch", "Dhalsim", 6);
        public Action Kick = GameAttacks.BasicAttack("Kick", "Dhalsim", 12);
        public Action YogaFire = GameAttacks.Tektektuguem("Dhalsim", 20);
    }

    internal static class GameAttacks
    {
        public static Action BasicAttack(string attackName, string heroName, int power)
        {
            return () => Console.WriteLine($"{heroName} {attackName} {power} points");
        }

        public static Action Tektektuguem(string heroName, int power)
        {
            return BasicAttack("tektektuguem", heroName, power);
        }

        public static Action YogaFire(string heroName, int power)
        {
            return BasicAttack("yoga fire", heroName, power);
        }

    }
}
