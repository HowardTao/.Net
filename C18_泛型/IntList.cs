using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_泛型
{
   public  class IntList
    {
       int[] arr;
       int count;

       /// <summary>
       /// 获取已存储的元素个数
       /// </summary>
       public int Count
       {
           get { return count; }
       }

       /// <summary>
       /// 构造函数,设置数组长度
       /// </summary>
       /// <param name="length">数组长度</param>
       public IntList(int length)
       {
           arr = new int[length];
       }

       #region 1.0 void Add(int element) -- 向集合中追加元素
       /// <summary>
       /// 向集合中追加元素
       /// </summary>
       /// <param name="element"></param>
       public void Add(int element)
       {
           //判断当前已添加元素的个数是否大于数组的容量
           if (count >= arr.Length)
           {
               //创建2倍的新数组
               int[] arrNew = new int[arr.Length * 2];
               //将arr里的数组复制到新数组中(从新数组的第0个位置开始存放)
               arr.CopyTo(arrNew, 0);
               //将新数组的引用设置给arr
               arr = arrNew;
           }
           arr[count] = element;
           count++;
       } 
       #endregion

       #region 2.0 int this[int index] -- 索引器
       public int this[int index]
       {
           get
           {
               if (index >= arr.Length)
               {
                   throw new Exception("数组下标越界!");
               }
               else
               {
                   return arr[index];
               }
           }
           set
           {
               if (index >= arr.Length)
               {
                   throw new Exception("数组下标越界!");
               }
               else
               {
                   arr[index] = value;
               }
           }

       } 
       #endregion

    }
}
