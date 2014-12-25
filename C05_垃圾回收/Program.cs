using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05_垃圾回收
{
    class Program
    {
        static void Main(string[] args)
        {

            //托管代码.被CLR管理的代码
            //非托管代码.不被CLR管理的代码
            //应用程序域:  

            //分配在栈空间的变量 一旦执行完其所在的作用域 这个变量就会被CLR立即回收.
            //分配在堆里面的对象 当没有任何变量引用它的时候,这个对象就被标记为"垃圾对象",等待垃圾回收器回收.
            //GC会定时的清理堆空间中的垃圾对象.
            //GC清理垃圾对象的频率 程序员无法决定 CLR会自动控制.
            //当1个对象被标记为"垃圾"的时候,这个对象不一定会被立即回收.
            // GC.GetGeneration(p); 得到指定的对象所在的代
            //GC.MaxGeneration;//返回代数. 
            // GC.Collect(); 立即让垃圾回收器对所有的代进行回收.
            // GC.Collect(int gen); 对指定的代立即进行垃圾回收.

            Person p = new Person();
            Console.WriteLine("p对象所在的代:" + GC.GetGeneration(p));

        }
    }
}
