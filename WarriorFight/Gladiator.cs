using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight
{
    class Gladiator : Warrior
    {
        public Gladiator(int attackMin = 20, int attackMax = 60, float deffense = 15, int evasion = 20, float life = 500) : base(attackMin, attackMax, deffense, evasion, life)
        {
        }

        public static float SpecialAttack(float deffense )
        {
          
            float special = deffense * 3;
            return special;
        }
       
        public static void Weapon()
        {
            Console.WriteLine(@"    _______________________    ");
            Console.WriteLine(@"   |                       |   ");
            Console.WriteLine(@"   |                       |   ");
            Console.WriteLine(@"   |       |||||||||       |   ");
            Console.WriteLine(@"   |          |||          |   ");
            Console.WriteLine(@"   |          |||          |   ");
            Console.WriteLine(@"   |          |||          |   ");
            Console.WriteLine(@"   |          |||          |   ");
            Console.WriteLine(@"   |          |||          |   ");
            Console.WriteLine(@"    \       |||||||        /    ");
            Console.WriteLine(@"      \                 /      ");
            Console.WriteLine(@"        \             /        ");
            Console.WriteLine(@"          \         /          ");
            Console.WriteLine(@"            \_____/            ");
            Console.WriteLine(@"                               ");
            Console.WriteLine(@"                               ");
        }


    }
}
  