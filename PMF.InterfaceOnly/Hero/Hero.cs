namespace PMF.InterfaceOnly.Hero
{
    public abstract class Hero
    {
        protected Hero(int hitPoints)
        {
            HitPoints = hitPoints;
        }

        public int HitPoints { get; }
    }
}