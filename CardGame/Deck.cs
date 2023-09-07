using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards;
        private int top = 0;

        public Deck() 
        {
            cards = new Card[52];
            int index = 0;
            for (int i = 1; i <= 4; i++) 
            { 
                for (int j = 1; j <= 13; j++)
                {
                    cards[index] = new Card(j, i);
                    index++;
                }
            }
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < cards.Length; i++)
            {
                str += cards[i];
            }
            return str;
        }
        public Card Peek() 
        {
            return cards[top]; 
        }
        public void Shuffle() 
        { 
            Random rnd = new Random();
            for (int i = 0; i < cards.Length; i++)
            {
                Swap(i, rnd.Next(i, cards.Length));
            }

        }
        private void Swap(int i, int j)
        {
            Card c = cards[j];
            cards[j] = cards[i];
            cards[i] = c;
        }
        public Card Deal() 
        {
            return cards[top++]; 
        }
        public void Reset() 
        {
            top = 0;
        }
    }
}
