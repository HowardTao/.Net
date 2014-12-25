using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_委托事件
{
    class CompareDog:IComparer<Dog>
    {
        public int Compare(Dog x, Dog y)
        {
            return x.age - y.age;
        }
    }
}
