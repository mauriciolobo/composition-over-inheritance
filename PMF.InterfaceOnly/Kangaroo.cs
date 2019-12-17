namespace PMF.InterfaceOnly
{
    public class Kangaroo : Monster, IMonsterCanKick, IMonsterCanPunch
    {
        public Kangaroo(int hitPoints): base(hitPoints) { }

        public int PunchDamage => 5;

        public int KickDamage => 5;
    }
}