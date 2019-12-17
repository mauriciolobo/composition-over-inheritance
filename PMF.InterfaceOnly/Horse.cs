namespace PMF.InterfaceOnly
{
    public class Horse : Monster, IMonsterCanBite, IMonsterCanKick
    {
        public Horse(int hitPoints) : base(hitPoints) { }

        public int BiteDamage => 5;

        public int KickDamage => 5;
    }
}