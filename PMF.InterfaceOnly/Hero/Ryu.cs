using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Hero
{
    public class Ryu : Hero, ICanTektektuguem, ICanKick, ICanPunch
    {
        public Ryu(int hitPoints) : base(hitPoints)
        {
        }

        public int TektektuguemDamage => 10;
        public int KickDamage => 10;
        public int PunchDamage => 10;
    }
}