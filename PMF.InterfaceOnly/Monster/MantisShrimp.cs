using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Monster
{
    public class MantisShrimp : Monster, ICanPunch
    {
        public MantisShrimp(int hitPoints) : base(hitPoints) { }

        public int PunchDamage => 5;
    }
}