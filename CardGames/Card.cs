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
        
        string getSuitString()
        {
            switch(Suit)
            {
                case 0:
                    return "♣";
                case 1:
                    return "♦";
                case 2:
                    return "♥";
                case 3:
                    return "♠";
                default:
                    return " ";
            }
        }
        
        public void DisplayCard(int x, int y, int width, int height)
        {

            
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < height; i++)
            {
                
                if (i == 0)
                {
                    Console.WriteLine("┌─────────┐");
                }
                else if (i == height - 1)
                {
                    Console.WriteLine("└─────────┘");
                }
                else if (i == 1)
                {
                    Console.WriteLine("│ {0}       │", Value);
                }
                else if (i == height - 2)
                {
                    Console.WriteLine("│       {0} │", Value);
                }
                else if (i == height / 2)
                {
                    Console.WriteLine("│    {0}    │", Value);
                }
                else
                {
                    Console.WriteLine("│         │");
                }
                Console.SetCursorPosition(x, y + 1);

            }


        }

    }
}
