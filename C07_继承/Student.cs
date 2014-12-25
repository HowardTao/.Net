using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_继承
{
    class Student : Person
    {
        public string  StuNo { get; set; }

        public void SayHi(int num)
        {
            Console.WriteLine("Son" + num);
        }
    }
}
