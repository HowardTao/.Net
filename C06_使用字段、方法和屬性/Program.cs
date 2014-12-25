using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06_使用字段_方法和屬性
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("創建一個對象。。。");
            MyClass myObj = new MyClass("My Object");
            Console.WriteLine("創建對象成功");
            for (int i = -1; i <=0; i++)
            {
                try
                {
                    Console.WriteLine(i);
                    myObj.Val = i;
                    Console.WriteLine(myObj.Val);
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.GetType().FullName);
                    Console.WriteLine(err.Message);
                }
            }
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
