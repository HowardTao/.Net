using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_虚方法案例1_洗澡机
{
    class Boy:Person
    {
        public override void WashBody()
        {
            Console.WriteLine("我是男孩,我開始洗澡了......");
            Console.WriteLine("一分鐘完成......");
        }
    }
}
