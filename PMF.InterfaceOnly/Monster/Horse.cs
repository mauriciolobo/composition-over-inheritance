using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Monster
{
    public class Horse : Monster, ICanBite, ICanKick
    {
        public Horse(int hitPoints) : base(hitPoints) { }

        public int BiteDamage => 5;

        public int KickDamage => 5;
    }
}