using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //枚举为值类型
            Point p = new Point();
            p.X = 120;
            p.Y = 100;
            Point p1 = new Point();
            Console.WriteLine(p1.X+":"+p1.Y);
            p1.X = 190;
            Console.WriteLine(p.X);

            Person person = new Person() { Name = "tom" };
            Point point1 = new Point(10, 10, person);
            Point point2 = point1;
            point2.p.Name = "jerry";
            Console.WriteLine(point1.p.Name);

            Console.ReadKey();
        }
    }
}
