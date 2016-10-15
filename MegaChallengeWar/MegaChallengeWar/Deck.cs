using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Deck
    {
        public int cardsInEachSuit = 13;

        //public Array CardID[];

        public enum individualCard
        {

        }

        public individualCard[] Ind;

        public void Card()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                string suitString = suit.ToString();

                for (int i = 1; i <= cardsInEachSuit; i++)
                {
                    //i.Ind = 
                    Guid uniqueCard = Guid.Parse(suitString + "_" + i);
                }
            }
        }
        
        public enum Face
        {
            Ace = 1,
            Jack = 11,
            Queen = 12,
            King = 13,
            Joker = 14
        }

        public enum Suit
        {
            Spades,
            Diamonds,
            Clubs,
            Hearts
        }
    }
}

//Use for loop to set unique identifier into each card

