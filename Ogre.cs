namespace EnemyInterfaceExample
{
    internal class Ogre : IEnemy
    {
        public Ogre(int hp)
        {
            HitPoints = hp;
        }

        public int HitPoints { get; set; }

        public int TakeDamage(int damageToTake)
        {
            HitPoints -= damageToTake;

            return HitPoints;
        }
    }
}