using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_面向对象案例2_购物系统
{
    class Shop
    {
        /// <summary>
        /// 商店的钱包
        /// </summary>
        int money = 3899;

        /// <summary>
        /// 商店類的倉庫對象
        /// </summary>
        private WareHouse wareHouse = new WareHouse();

        /// <summary>
        /// 顯示商品信息
        /// </summary>
        public void Show()
        {
            Console.WriteLine("*******************歡迎管理購物系統*******************");
            wareHouse.ShowGoods();
        }

        /// <summary>
        /// 根據商品的數量和名稱返回狀態
        /// </summary>
        /// <param name="proName"></param>
        /// <param name="num"></param>
        /// <param name="totalPrice"></param>
        /// <returns></returns>
        public State GetState(string proName, int num, ref int totalPrice)
        {
            //1.判斷有沒有商品
            int index = wareHouse.GetIndexByProName(proName);
            if (index != -1)
            {
                //表示有貨
                //1.1 在判斷數量是否充足
                int count = wareHouse.GetCountByProName(proName);
                if (count >= num)
                {
                    //表示有貨且數量充足
                    //輸出總價格
                    totalPrice = num * wareHouse.GetPriceByProName(proName);
                    return State.有貨且數量充足;
                }
                else
                {
                    return State.數量不足;
                }
            }
            else
            {
                return State.無貨;
            }
        }

        /// <summary>
        /// 商店買東西
        /// </summary>
        /// <param name="proName"></param>
        /// <param name="num"></param>
        /// <param name="money"></param>
        public void SellStuff(string proName, int num, ref int money)
        {
            //1.更新倉庫的數量
            wareHouse.UpdateGoods(proName, num);
            //2.將顧客的錢減掉
            int totalPrice = num * wareHouse.GetPriceByProName(proName);
            money -= totalPrice;
            //3.增加自己的櫃檯現金
            this.money += totalPrice;
            Console.WriteLine("貨物售出成功,櫃檯現金:" + this.money);
        }
    }

}
