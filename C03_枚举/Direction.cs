using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_枚举
{
    //1.使用enum关键字来定义1个枚举
    //2.枚举里面只能定义枚举成员,每个成员用逗号分隔
    //3.枚举的成员不需要用引号引起来,直接写就可以
    //4.给枚举类型赋值的时候,只能通过枚举点出来
    //5.枚举是一个值类型
    //6.每个枚举成员都对应了一个整型数值,这个数值默认从0开始依次递增
    //7.可以通过强制转换得到该枚举值所代表的数值.Direction dir = Direction.West;int i = (int)dir;
    //8.可以通过强制转换将一个整型数字强制转换诶其代表的枚举值.int i = 3;Direction dir = (Direction)i;
    //9.可以手动为每一个枚举成员赋值,其所代表的整型数值.
    //10.将字符串转换枚举值  Direction d = (Direction)Enum.Parse(typeof(Direction),str);
    //11.忽略大小写的转换   Direction d = (Direction)Enum.Parse(typeof(Direction),str,true);
    //12.将枚举值转换为字符串 ToString();
    //13.枚举值所对应的数值默认是int类型
    //14.可以在枚举的名字后面加一个:来指定这个数值的类型,只能是整型的.
    enum Direction:int
    {
        East=12,//0
        South=0,//1
        West=2,//2
        North=3//3
    }
}
