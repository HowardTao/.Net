using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_LSP_里氏替换原则
{
    class Program
    {
        static void Main(string[] args)
        {
            //里氏替换原则:LSP子类可以替换父类的位置,并且程序的功能不受影响
            //父类有的功能子类都有,所以不影响程序功能
            //父类变量指向了一个子类对象
            //当一个父类变量执行一个子类对象的时候,只能通过这个父类变量调用父类的成员.子类独有的成员无法调用
            Person p1 = new Person();
            p1.SayHi();//调用父类

            Student s1 = new Student();
            s1.SayHi();//调用子类

            Person p2 = new Student();
            p2.Age = 19;
            p2.Name = "tom";
            p2.SayHi();//父类


            //子类变量不能指向一个父类对象
            //必须要有继承关系,才可以使用强制转换
            
            Console.ReadKey();
        }
    }
}
