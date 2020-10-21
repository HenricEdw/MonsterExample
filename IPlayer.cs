using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyInterfaceExample
{
    interface IPlayer
    {
        int Damage { get; set; }

        int Attack(IEnemy enemy);
    }
}
