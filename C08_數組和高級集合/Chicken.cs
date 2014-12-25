using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08_數組和高級集合
{
   public class Chicken:Animal
    {
       public void LayEgg()
       {
           Console.WriteLine("{0} has been laid an egg.", name);
       }

       public Chicken(string newName)
           : base(newName)
       {

       }

    }
}
