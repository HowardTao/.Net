using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_垃圾回收
{
    class Person
    {
        //析构函数
        //不能有访问修饰符,不能有参数
        //在对象被垃圾回收器回收的时候,析构函数被GC字段调用
        //执行一些清理善后的操作的时候
        ~Person()
        {
            Console.WriteLine("我是析构函数.");
        }
    }
}
