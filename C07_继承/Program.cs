using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.继承的好处:方便代码管理,子类可以拥有父类的非私有成员,为了多态
            //2.子类的构造函数,默认会去调用父类的无参的构造函数
            //3.显示指定子类构造函数调用的父类构造函数-->base
            //4.this 可以点出子类的所有成员和父类的非私有成员,base可以点出父类的非私有成员
            //5.单根性,传递性

            Person p = new Person() { Age = 18, Name = "tom" };
            p.SayHi();

            Student s = new Student();
            s.SayHi();
            s.SayHi(123);

            Console.ReadKey();
        }
    }
}
