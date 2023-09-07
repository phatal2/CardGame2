using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    internal class Player
    {
        private string name;
        private Card[] hand;
        public Player(string name)
        {
            this.name = name;
            hand = new Card[5];
        }
        public string GetName()
        {
            return name;
        }
        public Card[] GetHand()
        {
            return hand;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetHand(Card[] hand)
        {
            this.hand = hand;
        }
        public void Take(Card c)
        {
            for (int i = 0; i < hand.Length; i++)
            {
                if (hand[i] == null)
                {
                    hand[i] = c;
                    return;
                }
            }
        }
        public Card Put(int i)
        {
            Card c = hand[i];
            hand[i] = null;
            return c;
        }
    }
}
