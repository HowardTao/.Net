using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_面向对象案例2_购物系统
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(10000);
            Shop shop = new Shop();
            while (true)
            {
                shop.Show();
                Console.WriteLine("請問你要買點啥呢?");
                string proName = Console.ReadLine();
                Console.WriteLine("請問你要賣多少?");
                int num = int.Parse(Console.ReadLine());

                c.BuyStuff(proName, num, shop);
                Console.WriteLine("請問你要繼續購物嗎?Y/N");
                string s = Console.ReadLine ();
                if(s=="N")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
