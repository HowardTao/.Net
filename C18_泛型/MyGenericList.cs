using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C18_泛型
{
   public  class MyGenericList<MyType>
    {
       MyType[] arr;
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
       public MyGenericList(int length)
       {
           arr = new MyType[length];
       }

       #region 1.0 void Add(int element) -- 向集合中追加元素
       /// <summary>
       /// 向集合中追加元素
       /// </summary>
       /// <param name="element"></param>
       public void Add(MyType element)
       {
           //判断当前已添加元素的个数是否大于数组的容量
           if (count >= arr.Length)
           {
               //创建2倍的新数组
               MyType[] arrNew = new MyType[arr.Length * 2];
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
       public MyType this[int index]
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

       /// <summary>
       /// 获取迭代器对象
       /// </summary>
       /// <returns></returns>
       public IEnumerator<MyType> GetEnumerator()
       {
           //返回一个迭代器对象,并传入了数据数组和数组真实元素的个数
           return new MyEnumerator<MyType>(arr, count);
       }

       /// <summary>
       /// 迭代器类
       /// </summary>
       /// <typeparam name="T"></typeparam>
       public class MyEnumerator<T> : IEnumerator<T>
       {
           T[] arr;
           int currentIndex = -1;
           int count;

           /// <summary>
           /// 通过构造函数,出入要遍历的数组对象,并传入数组里的真实数据的长度
           /// </summary>
           /// <param name="arr"></param>
           /// <param name="count"></param>
           public MyEnumerator(T[] arr, int count)
           {
               this.arr = arr;
               this.count = count;
           }

           /// <summary>
           /// 根据当前循环的下标,返回数组中对应的元素
           /// </summary>
           public T current
           {
               get
               {
                   T obj = arr[currentIndex];
                   return obj;
               }
           }

           object System.Collections.IEnumerator.Current
           {
               get { return null; }
           }

           /// <summary>
           /// 将当前循环的下标+1,并判断,如果下标超过了数组真实数据长度,则返回false,否则返回true
           /// </summary>
           /// <returns></returns>
           public bool MoveNext()
           {
               currentIndex++;
               if (currentIndex < count)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }

           public void Reset()
           {

           }

           public void Dispose()
           {

           }



           T IEnumerator<T>.Current
           {
               get { throw new NotImplementedException(); }
           }
       }

    }
}
