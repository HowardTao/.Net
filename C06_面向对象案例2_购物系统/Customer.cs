using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C06_面向对象案例2_购物系统
{
    /// <summary>
    /// 客户类
    /// </summary>
     class Customer
    {
         /// <summary>
        /// 用户的钱包
         /// </summary>
         private int money = 2000;

         /// <summary>
         /// 构造函数,用户初始化对象的钱包
         /// </summary>
         /// <param name="money"></param>
         public Customer(int money)
         {
             this.money = money;
         }

         /// <summary>
         /// 買東西的方法
         /// </summary>
         /// <param name="proName"></param>
         /// <param name="num"></param>
         /// <param name="shop"></param>
        public void BuyStuff(string proName,int num,Shop shop)
        {
            bool isE = false;
            State state = this.GetState(proName, num, shop,ref isE);
            if (state == State.無貨)
            {
                Console.WriteLine("你怎麼沒有呢?那我去別家買唄!");
            }
            else if (state == State.數量不足)
            {
                Console.WriteLine("你怎麼不多備點貨呢?看來我還是去別家吧!");
            }
            else if (state == State.有貨且數量充足)
            {
                //開始買了...
                if (isE)
                {
                    shop.SellStuff(proName, num, ref money);
                    Console.WriteLine("商品購買成功,身上的現金:" + this.money);
                }
                else
                {
                    Console.WriteLine("不好意思,我回去和媳婦商量一下......");
                }
            }
        }

         /// <summary>
         /// 獲取商店貨物的狀態
         /// </summary>
         /// <param name="proName"></param>
         /// <param name="num"></param>
         /// <param name="shop"></param>
         /// <param name="isE"></param>
         /// <returns></returns>
        public State GetState(string proName,int num,Shop shop,ref bool isE)
        {
            int totalPrice = 0;
            State state = shop.GetState(proName, num, ref totalPrice);
            //判斷錢是否足夠
            isE = this.money >= totalPrice;
            return state;
        }
    }
}
