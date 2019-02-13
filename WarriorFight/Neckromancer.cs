using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight
{
    class Neckromancer : Warrior
    {
        public Neckromancer(int attackMin = 40, int attackMax = 90, int deffense = 5, int evasion = 40, float life = 250) : base(attackMin, attackMax, deffense, evasion, life)
        {
        }

        public static float SpecialAttack(float life)
        {
            float drainLife = life / 2;
            return drainLife;
        }

        public static void Weapon()
        {
            Console.WriteLine(@"     _____________    ");
            Console.WriteLine(@"    ////_________\\   ");
            Console.WriteLine(@"   ////          \\\  ");
            Console.WriteLine(@"  ///            |||  ");
            Console.WriteLine(@" //              |||  ");
            Console.WriteLine(@"//               ///   ");
            Console.WriteLine(@"\\              ///    ");
            Console.WriteLine(@" \\            ///     ");
            Console.WriteLine(@"              ///      ");
            Console.WriteLine(@"             ///       ");
            Console.WriteLine(@"            ///        ");
            Console.WriteLine(@"           ///         ");
            Console.WriteLine(@"           //          ");
            Console.WriteLine(@"          //           ");
            Console.WriteLine(@"         //            ");
            Console.WriteLine(@"        //             ");
            Console.WriteLine(@"       //              ");
        }
    }
}
