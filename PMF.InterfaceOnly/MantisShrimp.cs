namespace PMF.InterfaceOnly
{
    public class MantisShrimp : Monster, IMonsterCanPunch
    {
        public MantisShrimp(int hitPoints) : base(hitPoints) { }

        public int PunchDamage => 5;
    }
}