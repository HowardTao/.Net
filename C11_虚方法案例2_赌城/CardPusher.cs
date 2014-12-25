using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11_虚方法案例2_赌城
{
    /// <summary>
    /// 发牌机类
    /// </summary>
    class CardPusher
    {
        /// <summary>
        /// 牌数组
        /// </summary>
        Card[] cards = new Card[3];

        Random r = new Random();

        /// <summary>
        /// 构造函数-为每个元素赋值
        /// </summary>
        public CardPusher()
        {
            cards[0] = new CardA();
            cards[1] = new CardB();
            cards[2] = new CardC();
        }

        /// <summary>
        /// 随机返回一个子牌类对象
        /// </summary>
        /// <returns></returns>
        public Card GetCard()
        {
            int index = r.Next(0, cards.Length);
            return this.cards[index];
        }

    }
}
