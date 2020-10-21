using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyInterfaceExample
{
    class Player : IPlayer
    {
        public int Damage { get ; set ; }

        public Player(int damage)
        {
            Damage = damage;
        }

        public int Attack(IEnemy enemy)
        {
            var remainingEnemyHp = enemy.TakeDamage(Damage);

            return remainingEnemyHp;
        }
    }
}
