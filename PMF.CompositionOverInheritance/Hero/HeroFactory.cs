using System;
using PMF.CompositionOverInheritance.Monster;

namespace PMF.CompositionOverInheritance.Hero
{
    public static class HeroFactory
    {
        public static Hero CreateHero(HeroType heroType)
        {
            Hero hero;

            switch (heroType)
            {
                case HeroType.Ryu:
                    hero = new Hero(50);
                    hero.AddAttackType(AttackType.Tektektugueming, 10);
                    hero.AddAttackType(AttackType.Punching, 10);
                    hero.AddAttackType(AttackType.Kicking, 10);
                    break;
                case HeroType.Guile:
                    hero = new Hero(50);
                    hero.AddAttackType(AttackType.Punching, 10);
                    hero.AddAttackType(AttackType.Kicking, 10);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(heroType), heroType, null);
            }

            return hero;
        }
    }

    public enum HeroType
    {
        Ryu, // TektektuguemingPunchingKickingHero
        Guile // PunchingKickingHero
    }
}