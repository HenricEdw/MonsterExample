using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var zombie = new Zombie(2);

            var hero = new Player(4);

            var ogre = new Ogre(7);

            CheckIfAlive(hero, ogre);

            CheckIfAlive(hero, zombie);

            Console.ReadLine();
        }

        private static void CheckIfAlive(IPlayer hero, IEnemy ogre)
        {
            var isDead = hero.Attack(ogre) <= 0;

            if (isDead)
            {
                Console.WriteLine("Hooray, the hero wins!");
            }
            else
            {
                Console.WriteLine("Sorry, the hero needs to try again. The monster yet lives!");
            }
        }
    }
}
