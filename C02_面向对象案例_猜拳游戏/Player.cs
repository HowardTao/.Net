using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_面向对象案例_猜拳游戏
{
    /// <summary>
    /// 玩家类
    /// </summary>
    class Player
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        #region ReadInt -- 从控制台接收一个指定范围的整形数字
        /// <summary>
        /// 从控制台接收一个指定范围的整形数字
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns></returns>
        private int ReadInt(int min, int max)
        {
            while (true)
            {
                //从控制台接收用户的输入
                string str = Console.ReadLine();
                int userSelect;
                //将用户输入的字符串转换为int类型
                if (int.TryParse(str, out userSelect))
                {
                    //是不是指定的范围
                    if (userSelect >= min && userSelect <= max)
                    {
                        return userSelect;
                    }
                    else
                    {
                        Console.WriteLine("请输入一个{0}-{1}范围的数", min, max);
                    }
                }
                else
                {
                    Console.WriteLine("请输入一个整数");
                }
            }
        } 
        #endregion

        #region IntToFist -- 将用户选择的数字转换成对象的拳头
        /// <summary>
        /// 将用户选择的数字转换成对象的拳头
        /// </summary>
        /// <param name="userSelect"></param>
        /// <returns></returns>
        private string IntToFist(int userSelect)
        {
            string fist = string.Empty;
            switch (userSelect)
            {
                case 1:
                    fist = "剪刀";
                    break;
                case 2:
                    fist = "石头";
                    break;
                case 3:
                    fist = "布";
                    break;
                default:
                    break;
            }
            return fist;
        } 
        #endregion

        /// <summary>
        /// 全家出拳的方法
        /// </summary>
        /// <returns></returns>
        public int ShowFist()
        {
            Console.WriteLine("请问,你要出什么拳?1.剪刀 2.石头 3.布");
            int userSelect = ReadInt(1, 3);
            Console.WriteLine("玩家:{0}出了1个{1}", name, IntToFist(userSelect));
            return userSelect;
        }

    }
}
