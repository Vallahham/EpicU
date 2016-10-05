using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClasses
{
    public partial class Default : System.Web.UI.Page
    {
        Character hero = new Character();
        Character monster = new Character();

        String characterStats(Character temp)
        {
            return temp.Name + " Health: " + temp.Health + 
                " Damage Maximum: " + temp.DamageMaximum + " Attack Bonus: " + temp.AttackBonus;
        }

        void gameplayStats(Character opponent1, Character opponent2)
        {

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
            hero.Name = "Hercules";
            hero.Health = 50;
            hero.DamageMaximum = 10;
            hero.AttackBonus = false;

          
            monster.Name = "Hydra";
            monster.Health = 75;
            monster.DamageMaximum = 15;
            monster.AttackBonus = true;

            opponent1Label.Text = characterStats(hero);
            opponent2Label.Text = characterStats(monster);

            gameplayStats(hero, monster);
        }

        protected void fightButton_Click(object sender, EventArgs e)
        {
            //gameplayStats();
        }
    }
}