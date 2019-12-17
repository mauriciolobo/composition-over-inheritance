using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Monster
{
    public class Camel : Monster, ICanKick
    {
        public Camel(int hitPoints) : base(hitPoints) { }
        
        public int KickDamage => 5;
    }
}