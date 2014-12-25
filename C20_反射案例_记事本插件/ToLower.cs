using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C20_反射案例_记事本Interface;

namespace C20_反射案例_记事本插件
{
   public class ToLower:IPlug
    {
        public string ProcessText(string text)
        {
            return text.ToLower();
        }
    }
}
