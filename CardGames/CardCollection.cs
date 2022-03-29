using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    interface CardCollection
    {
        List<Card> GetCards();
        void AddCard(Card card);
        void RemoveCard(Card card);
        void Empty();
        
        
        



    }
}
