namespace PMF.InterfaceOnly
{
    public class Crocodile : Monster, IMonsterCanBite
    {
        public Crocodile(int hitPoints) : base (hitPoints) { }

        public int BiteDamage => 5;
    }
}