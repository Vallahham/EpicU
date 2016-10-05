﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeHeroMonsterClasses
{
    public class Character
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public static int RandomNumber()
        {
            Random random = new Random();
            //Random random = new System.Random();
            return random.Next();
        }

        public int Attack()
        {
            int damage = RandomNumber();
            return damage;       
        }

        public double Defend(int damage)
        {
            Health -= damage;
            return Health;
        }


        /*
        private static rnd = new Random();
        public static int GetRandom()
        {
            return rnd.Next();
        }

    */



    }
}

