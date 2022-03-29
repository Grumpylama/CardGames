using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    public class Card
    {
        public int Value { get; private set; }

        public int Suit { get; private set; }

        public Card(int value, int suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
        
        public void DisplayCard(int x, int y, int size)
        {

            
            Console.SetCursorPosition(x, y);


        }

    }
}
