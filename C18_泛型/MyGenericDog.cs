using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_泛型
{
   public class MyGenericDog <T> 
       where T:new ()  //约束传给T的类,必须包含一个无参的构造函数
    {
       T t;

       public MyGenericDog()
       {
           t = new T();
       }

       /// <summary>
       /// 泛型方法
       /// 可以用在该方法的形参/方法体/返回值三处
       /// </summary>
       /// <typeparam name="K"></typeparam>
       /// <param name="a"></param>
       /// <returns></returns>
       public K Test<K>(K a) where K : new()
       {
           K k1 = new K();
           return k1;
       }
 
    }
}
