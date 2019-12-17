namespace PMF.InterfaceOnly
{
    public class Camel : Monster, IMonsterCanKick
    {
        public Camel(int hitPoints) : base(hitPoints) { }
        
        public int KickDamage => 5;
    }
}