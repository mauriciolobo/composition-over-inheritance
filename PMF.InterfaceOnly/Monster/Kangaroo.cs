using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Monster
{
    public class Kangaroo : Monster, ICanKick, ICanPunch
    {
        public Kangaroo(int hitPoints): base(hitPoints) { }

        public int PunchDamage => 5;

        public int KickDamage => 5;
    }
}