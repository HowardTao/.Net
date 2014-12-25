using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_數組和高級集合
{
   public class Cow:Animal
    {
       /// <summary>
       /// Cow 特有的Milk方法
       /// </summary>
       public void Milk()
       {
           Console.WriteLine("{0} has been milked", name);
       }

       public Cow(string newName)
           : base(newName)
       {
 
       }
    }
}
