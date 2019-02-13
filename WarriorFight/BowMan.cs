using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight
{
    class BowMan : Warrior
    {
       
     
        public BowMan(int attackMin = 40, int attackMax = 100, int deffense = 5, int evasion = 35 , float life = 300) : base(attackMin, attackMax, deffense, evasion, life)
        {
          
       }

        public static float SpecialAttack( int attackMax)
        {
            
          float special = attackMax * 2;

            return special;
        }


        public static void Weapon()
        {
            Console.WriteLine(@"            //|  ");
            Console.WriteLine(@"           // |  ");
            Console.WriteLine(@"          //  |  ");
            Console.WriteLine(@"         //   |  ");
            Console.WriteLine(@"        //    |   ");
            Console.WriteLine(@"       //     |  ");
            Console.WriteLine(@"      //      |    ");
            Console.WriteLine(@"_____||_______|______///  ");
            Console.WriteLine(@"     ||       |      \\\  ");
            Console.WriteLine(@"      \\      |    ");
            Console.WriteLine(@"       \\     |    ");
            Console.WriteLine(@"        \\    |   ");
            Console.WriteLine(@"         \\   |   ");
            Console.WriteLine(@"          \\  |   ");
            Console.WriteLine(@"           \\ |   ");
            Console.WriteLine(@"            \\|     ");
        }


    }
}
