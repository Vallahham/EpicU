using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int RandomNumber()
        {
            Random random = new Random();
            //Random random = new System.Random();
            return random.Next(DamageMaximum);
        }

        public int Attack()
        {
            int damage = RandomNumber();
            return damage;       
        }

        public int Defend(int damage)
        {
            Health -= damage;
            return Health;
        }
    }
}

