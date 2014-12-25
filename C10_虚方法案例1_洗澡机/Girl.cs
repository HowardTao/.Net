using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_虚方法案例1_洗澡机
{
    class Girl:Person
    {
        public override void WashBody()
        {
            Console.WriteLine("把鏈子拉上.....");
            Console.WriteLine("我是女孩子......");
            Console.WriteLine("一個小時後...洗好了....");
        }
    }
}
