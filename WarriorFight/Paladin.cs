using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight
{
    class Palladin : Warrior
    {
        public Palladin(int attackMin = 20, int attackMax = 75, int deffense = 10, int evasion = 25, float life = 400) : base(attackMin, attackMax, deffense, evasion, life)
        {
        }

        public static int SpecialAttack( int attackMax)
        {
            int special = attackMax * 2;
            return special;
        }

        public static int SpecialAttack2(int attackMin)
        {
            int special = attackMin * 2;
            return special;
        }

        public static void Weapon()
        {
            Console.WriteLine(@"     / \    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@" ____| |____ ");
            Console.WriteLine(@"|____| |____|");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     | |    ");
            Console.WriteLine(@"     *|*  ");
            Console.WriteLine(@"       *    ");
        }
    }
}
