using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_定義類示例
{
   public class Card
    {
       public readonly Suit suit;
       public readonly Rank rank;

       public Card(Suit newSuit, Rank newRank)
       {
           suit = newSuit;
           rank = newRank;
       }

       private Card() { }

       //重寫的tostring()方法將已存儲的枚舉值的字符串表示寫入到返回的字符串中
       public override string ToString()
       {
           return "The" + rank + "of" + suit + "s";
       }

    }
}
