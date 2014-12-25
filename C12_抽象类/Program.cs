using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12_抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Chinese();
            p.SayHi();
            Console.ReadKey();
        }
    }
}
