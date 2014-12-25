using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07_继承
{
    class Person
    {
        public int Age { get; set; }

        public string  Name { get; set; }

        private double height;

        public void SayHi()
        {
            Console.WriteLine("Father");
        }
    }
}
