using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_虚方法案例1_洗澡机
{
    class Program
    {
        static void Main(string[] args)
        {

            //多态的表现形式之一:将父类类型作为方法的参数.
            //屏蔽多个子类的不同,将多个子类当成父类来统一处理
            Person p1 = new Boy();
            Person p2 = new Girl();
            Person p3 = new OldMan();
            WashMachine wm = new WashMachine();
            wm.Wash(p1);
            wm.Wash(p2);
            wm.Wash(p3);
            Console.ReadKey();
        }
    }
}
