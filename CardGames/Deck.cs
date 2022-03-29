using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    internal class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(suit,value));
                }
            }
            random = new Random();
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
            random = new Random();
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            while (cards.Count > 0)
            {
                int cardToMove = random.Next(cards.Count);
                newCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = newCards;
        }

        //public IEnumerable<string> GetCardNames()
        //{
        //    string[] cardNames = new string[cards.Count];
        //    for (int i = 0; i < cards.Count; i++)
        //    {
        //        cardNames[i] = cards[i].Name;
        //    }
        //    return cardNames;
        //}

        //public void Sort()
        //{
        //    cards.Sort(new CardComparer_bySuit());
        //}

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public bool ContainsValue(int value)
        {
            foreach (Card card in cards)
            {
                if (card.Value == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
