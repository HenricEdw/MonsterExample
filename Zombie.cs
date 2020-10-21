using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyInterfaceExample
{
    internal class Zombie : IEnemy
    {
        public int HitPoints { get; set; }

        public Zombie(int hp)
        {
            HitPoints = hp;
        }

        public int TakeDamage(int damageToTake)
        {
            HitPoints -= damageToTake;
            
            return HitPoints;
        }
    }
}
