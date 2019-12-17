using System;

namespace PMF.CompositionOverInheritance.Monster
{
    public static class MonsterFactory
    {
        public static Monster CreateMonster(MonsterType monsterType)
        {
            Monster monster;
 
            switch(monsterType)
            {
                case MonsterType.Horse:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    monster.AddAttackType(AttackType.Kicking, 5);
                    break;
                case MonsterType.Orc:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    monster.AddAttackType(AttackType.Kicking, 5);
                    monster.AddAttackType(AttackType.Punching, 5);
                    break;
                case MonsterType.Crocodile:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    break;
                case MonsterType.MikeTyson:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Biting, 5);
                    monster.AddAttackType(AttackType.Punching, 5);
                    break;
                case MonsterType.Camel:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Kicking, 5);
                    break;
                case MonsterType.Kangaroo:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Kicking, 5);
                    monster.AddAttackType(AttackType.Punching, 5);
                    break;
                case MonsterType.MantisShrimp:
                    monster = new Monster(10);
                    monster.AddAttackType(AttackType.Punching, 5);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(monsterType), monsterType, null);
            }
 
            return monster;
        }
    }

    public enum MonsterType
    {
        Horse, // BitingKickingMonster
        Orc, // BitingKickingPunchingMonster
        Crocodile, // BitingMonster
        MikeTyson, // BitingPunchingMonster
        Camel, // KickingMonster
        Kangaroo, // KickingPunchingMonster
        MantisShrimp //PunchingMonster
    }
}