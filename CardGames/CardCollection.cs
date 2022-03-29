using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    public interface CardCollection
    {
        public List<Card> GetCards();
        public void AddCard(Card card);
        public void RemoveCard(Card card);
        public void Empty();
        
        
        



    }
}
