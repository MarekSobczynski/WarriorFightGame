using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight
{
    class Wizzard : Warrior
    {
        public Wizzard(int attackMin = 40, int attackMax = 120, int deffense = 3, int evasion = 45, float life = 250) : base(attackMin, attackMax, deffense, evasion, life)
        {
        }

        public static float SpecialAttack(float life)
        {
            float special = life + 100;
            return special;
        }

        public static void Weapon()
        {
            Console.WriteLine(@"      /\  ");
            Console.WriteLine(@"     /  \ ");
            Console.WriteLine(@"     \  / ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
            Console.WriteLine(@"      ||  ");
        }
    }
}
