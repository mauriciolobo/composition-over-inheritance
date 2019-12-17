using PMF.InterfaceOnly.AttackType;

namespace PMF.InterfaceOnly.Monster
{
    public class Crocodile : Monster, ICanBite
    {
        public Crocodile(int hitPoints) : base (hitPoints) { }

        public int BiteDamage => 5;
    }
}