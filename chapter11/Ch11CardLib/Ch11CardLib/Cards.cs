﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11CardLib
{
    public class Cards : CollectionBase, ICloneable
    {
        public void Add(Card newCard) => List.Add(newCard);

        public void Remove(Card oldCard) => List.Remove(oldCard);

        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }

            set { List[cardIndex] = value; }
        }

        /// <summary>
        /// Utility method for copying card instances into another Cards
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        /// <param name="targetCards"></param>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        public bool Contains(Card card) => InnerList.Contains(card);

        public object Clone()
        {
            Cards newCards = new Cards();
            foreach(Card sourceCard in List)
            {
                newCards.Add((Card)sourceCard.Clone());
            }

            return newCards;
        }
    }
}
