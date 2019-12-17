namespace PMF.InterfaceOnly
{
    public class MikeTyson : Monster, IMonsterCanBite, IMonsterCanPunch
    {
        public MikeTyson(int hitPoints) : base (hitPoints) { }

        public int BiteDamage => 5;

        public int PunchDamage => 5;
    }
}