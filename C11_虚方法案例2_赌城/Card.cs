using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11_虚方法案例2_赌城
{
    /// <summary>
    /// 卡牌类
    /// </summary>
    class Card
    {
        public virtual void Show()
        {
            Console.WriteLine("Card");
        }
    }
}
