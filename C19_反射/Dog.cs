using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19_反射
{
   public class Dog
    {
       public string name;
       public int age;

       public void Shout()
       {
           Console.WriteLine(this.name);
       }

    }
}
