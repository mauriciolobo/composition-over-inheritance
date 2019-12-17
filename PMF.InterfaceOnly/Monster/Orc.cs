using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Monster
{
    public class Orc : Monster, ICanBite, ICanKick, ICanPunch
    {
        public Orc(int hitPoints) : base(hitPoints) { }

        public int BiteDamage => 5;

        public int KickDamage => 5;

        public int PunchDamage => 5;
    }
}