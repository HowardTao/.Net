using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_LSP_里氏替换原则
{
    class Person
    {
        public int Age { get; set; }

        public string Name { get; set; }

        private double height;

        public void SayHi()
        {
            Console.WriteLine("Father");
        }
    }
}
