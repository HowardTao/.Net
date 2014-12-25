using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_LSP_里氏替换原则
{
    class Student:Person
    {
        public string StuNo { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Son");
        }

        public void SayHi1()
        {
            Console.WriteLine("Son1");
        }
    }
}
