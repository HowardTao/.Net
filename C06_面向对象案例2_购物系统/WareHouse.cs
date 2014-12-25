using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_面向对象案例2_购物系统
{
    /// <summary>
    /// 仓库类
    /// </summary>
    class WareHouse
    {
        /// <summary>
        /// 商品
        /// </summary>
        private string[,] goods = new string[5, 3];

        #region WareHouse -- 构造函数,用户初始化二维商品数组
        /// <summary>
        /// 构造函数,用户初始化二维商品数组
        /// </summary>
        public WareHouse()
        {
            goods[0, 0] = "聯想筆記本";
            goods[0, 1] = "16";
            goods[0, 2] = "4999";

            goods[1, 0] = "IPhone20";
            goods[1, 1] = "28";
            goods[1, 2] = "7899";

            goods[2, 0] = "IPad5     ";
            goods[2, 1] = "29";
            goods[2, 2] = "4599";

            goods[3, 0] = "ITouchN     ";
            goods[3, 1] = "36";
            goods[3, 2] = "2239";

            goods[4, 0] = "蘋果       ";
            goods[4, 1] = "100";
            goods[4, 2] = "1";
        } 
        #endregion

        /// <summary>
        /// 显示商品信息
        /// </summary>
        public void ShowGoods()
        {
            for (int i = 0; i < this.goods.GetLength(0); i++)
            {
                for (int j = 0; j < this.goods.GetLength(1); j++)
                {
                    Console.Write(goods[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 根据商品的名称得到商品的行坐标
        /// </summary>
        /// <param name="proName"></param>
        /// <returns></returns>
        public int GetIndexByProName(string proName)
        {
            //遍历每一行的第一列,取得商品名
            for (int i = 0; i < goods.GetLength(0); i++)
            {
                if (goods[i, 0].Trim().ToLower() == proName.Trim().ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// 根據商品的名稱得到商品的數量
        /// </summary>
        /// <param name="proName"></param>
        /// <returns></returns>
        public int GetCountByProName(string proName)
        {
            return int.Parse(goods[this.GetIndexByProName(proName), 1]);
        }

        /// <summary>
        /// 根據商品名稱得到商品單價
        /// </summary>
        /// <param name="proName"></param>
        /// <returns></returns>
        public int GetPriceByProName(string proName)
        {
            return int.Parse(goods[this.GetIndexByProName(proName), 2]);
        }

        /// <summary>
        /// 根據商品的名稱更新商品的數量
        /// </summary>
        /// <param name="proName"></param>
        /// <param name="num"></param>
        public void UpdateGoods(string proName, int num)
        {
            int nowNum = int.Parse(goods[this.GetIndexByProName(proName), 1]);
            nowNum -= num;
            goods[this.GetIndexByProName(proName), 1] = nowNum.ToString();
        }




    }
}
