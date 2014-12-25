using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_定義類示例
{
   public  class Deck
    {
       private Card[] cards;

       public Deck()
       {
           cards = new Card[52];

           for (int suitVal = 0; suitVal < 4; suitVal++)
           {
               for (int rankVal = 0; rankVal < 14; rankVal++)
               {
                   cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
               }
           }
       }

       /// <summary>
       /// 為指定的索引返回Card對象
       /// </summary>
       /// <param name="cardNum"></param>
       /// <returns></returns>
       public Card GetCard(int cardNum)
       {
           if(cardNum>=0&&cardNum<=51)
           {
               return cards[cardNum];
           }
           else
           {
               throw new Exception("在0~51之間");
           }
       }

       public void Shuffle()
       {
           Card[] newDeck = new Card[52];
           bool[] assigned = new bool[52];
           Random sourceGen = new Random();
           for (int i = 0; i < 52; i++)
           {
               int destCard = 0;
               bool foundCard = false;
               while (foundCard == false)
               {
                   destCard = sourceGen.Next(52);
                   if(assigned [destCard ]==false )
                   {
                       foundCard = true;
                   }
               }
           }
       }



    }
}
