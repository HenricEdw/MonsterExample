namespace EnemyInterfaceExample
{
    public interface IEnemy
    {
        int HitPoints { get; set; }

        int TakeDamage(int damageToTake);
    }
}