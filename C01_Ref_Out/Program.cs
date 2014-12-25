using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 19;

            #region Ref
            TestRef(ref i);
            Console.WriteLine(i);

            Person p = new Person() { Age = 17, Name = "wangwu" };
            TestRef2(ref p);
            Console.WriteLine(p.Name);

            Test3(p);
            Console.WriteLine(p.Name); 
            #endregion

            #region Out
            TestOut(out i);
            Console.WriteLine(i);
            int num;
            bool b = MyIntParse("123", out num);
            Console.WriteLine(b + ":" + num);
            b = MyIntParse("123a", out num);
            Console.WriteLine(b + ":" + num);

            b = int.TryParse("456", out num);
            Console.WriteLine(b + ":" + num); 
            #endregion

            Console.ReadKey();
        }


        #region Ref实例
        //1.ref/out是用来修饰方法的参数的
        //2.调用的时候给ref/out赋值,不能赋值一个常量,只能给变量.变量前面也要加1个ref/out
        //3.在给ref/out参数赋值的时候,赋值的是变量的地址
        //4.ref在方法中可以对其值不修改
        //5.ref在传递之前必须赋值
        static void TestRef(ref int num)
        {
            num = num + 1;
        }

        static void TestRef2(ref Person p)
        {
            //p = new Person() { Name = "zhangsan" };
            p.Name = "xiaoming";
        }

        static void Test3(Person p)
        {
            //p = new Person() { Name = "huahua" };
            p.Name = "lisi";
        } 
        #endregion

        #region Out实例
        //1.out必须在方法结束之前为其赋值/在方法中如果要使用out必须先为他赋值.
        //2.out在调用之前可以不赋值,因为在方法中一定会为其赋值(根据第一条)
        //3.out侧重输出
        static void TestOut(out int i)
        {
            i = 12;
        }

        static bool MyIntParse(string str, out int num)
        {
            try
            {
                num = int.Parse(str);
                return true;
            }
            catch
            {
                num = 0;
                return false;
            }
        } 
        #endregion

    }
}
