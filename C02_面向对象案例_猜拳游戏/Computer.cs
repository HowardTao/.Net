using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_面向对象案例_猜拳游戏
{
    /// <summary>
    /// 电脑类
    /// </summary>
    class Computer
    {
        Random r = new Random();

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
        /// 电脑出拳方法
        /// </summary>
        /// <returns></returns>
        public int ShowFist()
        {
            int comSelect = r.Next(1, 4);
            Console.WriteLine("电脑出了:{0}", IntToFist(comSelect));
            return comSelect;
        }
    }
}
