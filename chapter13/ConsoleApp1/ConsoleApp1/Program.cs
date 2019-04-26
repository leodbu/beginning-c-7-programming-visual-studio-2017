using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch13CardLib;
using static System.Console;

namespace Ch13CardClient
{
   public class Program
   {
      static void Main(string[] args)
      {
            Deck deck1 = new Deck();
            try
            {
                Card myCard = deck1.GetCard(60);
            } catch (CardOutOfRangeException e)
            {
                WriteLine(e.Message);
                ReadKey();
                WriteLine(e.DeckContents[0]);
            }
         Deck myDeck = new Deck();
         myDeck.Shuffle();
         for (int i = 0; i < 52; i++)
         {
            Card tempCard = myDeck.GetCard(i);
            Write(tempCard.ToString());
            if (i != 51)
               Write(", ");
            else
               WriteLine();
         }
         ReadKey();
      }
   }
}
