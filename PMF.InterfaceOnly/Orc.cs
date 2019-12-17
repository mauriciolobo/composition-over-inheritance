namespace PMF.InterfaceOnly
{
    public class Orc : Monster, IMonsterCanBite, IMonsterCanKick, IMonsterCanPunch
    {
        public Orc(int hitPoints) : base(hitPoints) { }

        public int BiteDamage => 5;

        public int KickDamage => 5;

        public int PunchDamage => 5;
    }
}