using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Monster
{
    public class MikeTyson : Monster, ICanBite, ICanPunch
    {
        public MikeTyson(int hitPoints) : base (hitPoints) { }

        public int BiteDamage => 5;

        public int PunchDamage => 5;
    }
}