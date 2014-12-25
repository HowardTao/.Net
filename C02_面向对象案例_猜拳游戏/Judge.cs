using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_面向对象案例_猜拳游戏
{
    /// <summary>
    /// 裁判类
    /// </summary>
    class Judge
    {
        /// <summary>
        /// 裁决方法
        /// 1.剪刀 2.石头 3 布
        /// </summary>
        /// <param name="p1">玩家出拳</param>
        /// <param name="p2">电脑出拳</param>
        public void CaiJue(int p1, int p2)
        {
            if (p1 - p2 == -2 || p1 - p2 == 1)
            {
                Console.WriteLine("玩家胜利!");
            }
            else if (p1 == p2)
            {
                Console.WriteLine("平局!");
            }
            else
            {
                Console.WriteLine("玩家失败!");
            }
        }
    }
}
