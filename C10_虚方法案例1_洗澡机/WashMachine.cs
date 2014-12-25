using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_虚方法案例1_洗澡机
{
    /// <summary>
    /// 洗澡機類
    /// </summary>
    class WashMachine
    {
        public void Wash(Person p)
        {
            Console.WriteLine("準備熱水....");
            //調用的是子類,因爲子類重寫了父類的WashBody方法
            p.WashBody();
            Console.WriteLine("自動烘乾.....");
            Console.WriteLine("完成......");
        }
    }
}
