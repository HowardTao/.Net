using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09_虚方法
{
    class Person
    {
        public void Test()
        {

        }

        //用virtual修饰
        //子类可以重写就会调用子类的,也可以不重写调用父类的
        public virtual void SayHi()
        {
            Console.WriteLine("Father");
        }
    }
}
