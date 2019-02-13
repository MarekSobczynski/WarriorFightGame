using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorFight
{
    class Warrior
    {
        public int attackMin;
        public int attackMax;
        public float deffense;
        public float evasion;
        public float life;

        public Warrior(int attackMin, int attackMax, float deffense, float evasion, float life)
        {
            this.attackMin = attackMin;
            this.attackMax = attackMax;
            this.deffense = deffense;
            this.evasion = evasion;
            this.life = life;
        }

        public float Deffense(float deffense)
        {
            deffense = deffense + (deffense / 2);
            return deffense;
        }

        public  float Attack( int attackMin , int atttackMax)
        {
            Random random = new Random();
           float dmg = random.Next(attackMin, atttackMax);
            if(dmg == atttackMax)
            {                
                dmg = dmg + (dmg * (20 / 100));
            }
            return dmg;
        }

        public  float Dmg(float dmg, float deffense)
        {
            float damage = dmg - deffense;             
            return damage;
        }
    
        public  bool Evasion (float evasion)
        {
            bool result = false;
            Random random = new Random();
            int rnd = random.Next(100);
            if(rnd >= 100 - evasion)
            {
                result = true;
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
} 
