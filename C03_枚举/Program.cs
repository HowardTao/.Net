using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_枚举
{
    class Program
    {
        static void Main(string[] args)
        {
            //枚举值类型例子
            Direction dir1 = Direction.East;
            Direction dir2 = dir1;
            dir2 = Direction.South;
            Console.WriteLine(dir1);

            //枚举转换为int
            Direction dir3 = Direction.West;
            int i = (int)dir3;
            Console.WriteLine(i);

            //int转换为枚举
            int j = 3;
            Direction dir4 = (Direction)j;
            Console.WriteLine(dir4);
            Person p = new Person();
            Console.WriteLine(p.dir);

            string str = "east";
            Direction dir5 = (Direction)Enum.Parse(typeof(Direction), str, true);
            string s = dir5.ToString("d");
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
