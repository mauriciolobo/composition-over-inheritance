using System;
using System.Collections.Generic;
using PMF.CompositionOverInheritance.Monster;

namespace PMF.CompositionOverInheritance.Hero
{
    public class Hero
    {
        public Hero(int hitPoints)
        {
            HitPoints = hitPoints;
            AttackTypes = new Dictionary<AttackType, int>();
        }

        public int HitPoints { get; }
        public Dictionary<AttackType, int> AttackTypes { get; }
        public bool CanKick => AttackTypes.ContainsKey(AttackType.Kicking);
        public bool CanPunch => AttackTypes.ContainsKey(AttackType.Punching);
        public bool CanTektektuguem => AttackTypes.ContainsKey(AttackType.Tektektugueming);

        public void AddAttackType(AttackType attackType, int amountOfDamage)
        {
            AttackTypes[attackType] = amountOfDamage;
        }

        public int KickDamage
        {
            get
            {
                if (CanKick)
                {
                    return AttackTypes[AttackType.Kicking];
                }

                throw new NotSupportedException("This monster cannot kick.");
            }
        }

        public int PunchDamage
        {
            get
            {
                if (CanPunch)
                {
                    return AttackTypes[AttackType.Punching];
                }

                throw new NotSupportedException("This monster cannot punch.");
            }
        }

        public int TektektuguemDamage
        {
            get
            {
                if (CanTektektuguem)
                {
                    return AttackTypes[AttackType.Tektektugueming];
                }

                throw new NotSupportedException("This hero cannot tektektuguem.");
            }
        }
    }
}