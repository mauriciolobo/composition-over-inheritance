namespace PMF.InterfaceOnly.Monster
{
    public abstract class Monster
    {
        protected Monster(int hitPoints)
        {
            HitPoints = hitPoints;
        }

        public int HitPoints { get; }
    }
}