using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12_抽象类
{
    abstract class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void Run()
        {
            Console.WriteLine("Run");
        }

        /// <summary>
        /// 1.抽象方法用abstract修饰
        /// 2.抽象方法不能有方法体.大括弧也不能有
        /// 3.抽象方法必须要再抽象类中
        /// 4.抽象类不能实例化.因为有抽象成员,而抽象成员是没有方法体的
        /// 5.子类必须重写父类的抽象方法
        /// 6.在子类中无法通过base关键字调用父类的抽象方法
        /// 7.抽象方法是光说不做,只是定义了具有这样的行为,但是具体的实现交给子类
        /// 8.抽象类中可以有非抽象成员.为了继承给子类
        /// 9.抽象类中可以拥有虚方法
        /// 10.子类必须重写父类的方法,父类没有必要实例化,就用抽象类
        /// 11.抽象类是被继承的,为了多态
        /// 12.抽象成员不能是私有的,因为子类不能重写方法
        /// </summary>
        public abstract void SayHi();

        public virtual void Sing()
        {

        }

    }
}
