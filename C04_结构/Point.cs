using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_结构
{
    //使用struct关键字来定义一个结构,级别与类保持一致,写在命名空间下面
    // 结构中可以定义字段,属性,方法,构造函数,也可以通过new关键字创建对象
    //1.结构中的字段不能赋初始值
    //2.无参数的构造函数无论如何c#编译器都会自动生成,所以我们不能为结构定义一个无参数的构造函数
    //3.在构造函数中必须为结构体的所有字段赋值
    //4.在构造函数中为属性赋值,不认为是对字段赋值,因为属性不一定是去操作字段.
    //5.结构是一个值类型的,在传递结构变量的时候会将结构对象里的每一个字段复制一份然后拷贝到新的结构变量的字段中
    //6.不能定义自动属性,因为自动属性会生成一个字段,而这个字段必须要求在构造函数中,但是我们又不知道这个字段叫什么名字
    //7.声明结构体对象可以不new关键字,但是这个时候结构体对象的字段没有初始值.因为没有调用构造函数,而构造函数中必须为字段赋值
    //  所以通过new关键字创建结构体对象,这个对象的字段就有默认值了.
    //8.当我们要表示一个轻量级的对象的时候,就可以定位结构,以提高速度.根据传值的影响来选择,希望传引用就定义类,希望传拷贝就定位结构.
    struct Point
    {
        public Person p;

        private int x;

        public int X
        {
            get { return x; }
            set { this.x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { this.y = value; }
        }

        public void Show()
        {
            Console.WriteLine("x={0},y={1}", this.x, this.y);
        }

        public Point(int x, int y, Person p)
        {
            this.x = x;
            this.y = y;
            this.p = p;
        }

    }
}
