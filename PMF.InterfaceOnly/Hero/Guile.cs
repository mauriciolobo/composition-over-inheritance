using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Hero
{
    public class Guile : Hero, ICanKick, ICanPunch
    {
        public Guile(int hitPoints) : base(hitPoints)
        {
        }

        public int KickDamage => 10;
        public int PunchDamage => 10;
    }
}