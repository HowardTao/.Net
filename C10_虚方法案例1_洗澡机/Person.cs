using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10_虚方法案例1_洗澡机
{
    class Person
    {
        public string  Name { get; set; }

        public virtual void WashBody()
        {
            Console.WriteLine("人在洗澡...........");
        }
    }
}
