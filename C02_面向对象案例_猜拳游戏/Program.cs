using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_面向对象案例_猜拳游戏
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player() { Name = "小明" };
            int p1 = p.ShowFist();
            Computer c = new Computer();
            int p2 = c.ShowFist();
            Judge j = new Judge();
            j.CaiJue(p1, p2);
            Console.ReadKey();
        }
    }
}
