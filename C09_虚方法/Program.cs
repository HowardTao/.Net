using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09_虚方法
{
    class Program
    {
        static void Main(string[] args)
        {

            //如果子类重写了父类的虚方法,那么通过父类变量来调用 这个方法的时候,就会调用子类的
            //父类 p = new 子类();
            //如果父类和子类存在同名成员
            Person p1 = new Teacher();
            p1.SayHi();

            Person p2 = new Person();
            p2.SayHi();

            Teacher t = new Teacher();
            t.SayHi();

            Person p3 = new NanjingRen();
            p3.SayHi();

            Console.ReadKey();
        }
    }
}
