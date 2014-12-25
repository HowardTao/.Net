using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C18_泛型
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 泛型
        private void button1_Click(object sender, EventArgs e)
        {
            IntList intList = new IntList(3);
            intList.Add(5);
            intList.Add(7);
            intList.Add(20);
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            MyGenericList<string> strList = new MyGenericList<string>(3);
            strList.Add("111");
            strList.Add("222");
            strList.Add("33333");
            for (int i = 0; i < strList.Count; i++)
            {
                Console.WriteLine(strList[i]);
            }
        } 
        #endregion

        #region 泛型复习
        private void button2_Click(object sender, EventArgs e)
        {
            //1.泛型：带类型参数的类（接口/结构）和方法
            //1.1 在CLR第一次遇到MList<string>语法时，会在内存中生成一个新的类MList'1[string]
            MyList<Form1> myList = new MyList<Form1>();
            Form1 form1 = Form1.GetObject<Form1>();
        }

        #region 3.0 泛型方法
        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetObject<T>() where T : new()
        {
            return new T();
        }
        #endregion 
        #endregion

        #region 泛型方法的重载
        private void button3_Click(object sender, EventArgs e)
        {
            //1.两个方法虽然都叫SayA，并且参数列表为空，看上去就是一个“重载”；实际是两个方法
            SayA();
            SayA<string>();
             
            //2.真正的重载：两个带不同个数的类型参数的泛型方法构成重载
            //**泛型方法的类型参数和方法参数列表都是构成重载的元素**
            SayB<string>();
            SayB<string, int>();
            
        }

        //泛型和非泛型方法，其实没有重载
        void SayA()
        {

        }
        void SayA<T>()
        {

        }

        //
        void SayB<T>() 
        {

        }
        void SayB<T, K>()
        {

        }
        void SayB<T>(string str)
        {

        }
        #endregion

        #region 泛型方法的重写
        private void button4_Click(object sender, EventArgs e)
        {
            Son son = new Son();
            son.Shout<Form1>();
        } 
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            //协变普通代码
            TestSonDelegate testSonDelegate = new TestSonDelegate(TestSon);
            testSonDelegate += TestFather;
            testSonDelegate(new Son());

            TestObjDelegate<Son> testObjDelegate = TestSon;
            testObjDelegate = TestFather;
            testObjDelegate(new Son());
        }

        public void TestSon(Son sonObj)
        {
            sonObj.TestSon();
        }

        public void TestFather(Father faObj)
        {
            faObj.TestFather();
        }

    }


    #region 1.0 泛型类
    /// <summary>
    /// 集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T> where T : new()
    {
        T[] arrT;

        public T Say(T a)
        {
            return new T();
        }
    } 
    #endregion

    #region 2.0  泛型接口（接口的本质，就是一个特殊的抽象类）
    /// <summary>
    /// 泛型接口（接口的本质，就是一个特殊的抽象类）
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IList<T>
    {
        T Say(T s);
    }

    public interface IList2<T>
    {
        T Say(T s);
    }

    /// <summary>
    /// 泛型接口实现类
    /// </summary>
    public class YouList : IList<int>, IList<string>, IList2<string>
    {

        public int Say(int s)
        {
            throw new NotImplementedException();
        }

        public string Say(string s)
        {
            throw new NotImplementedException();
        }
        //实现显示接口
        string IList2<string>.Say(string s)
        {
            throw new NotImplementedException();
        }

    } 
    #endregion


    public class Father
    {
        public virtual T Shout<T>() where T:new () 
        {
            return new T();
        }

        public void TestFather()
        {
            Console.WriteLine("father");
        }
    }

    public class Son : Father
    {
        //*********子类重写父类方法的是方法体实现代码，而不是方法签名
        //泛型方法的约束会自动从父类继承下来，注意：类型参数的名称即时和父类不一样，也会继承约束
        //因为重写的父类的Shout方法，在父类中已经为T设置了构造函数约束，所以子类不需要再进行约束了
        public override K Shout<K>()
        {
            return new K();
        }

        public void TestSon()
        {

        }
    }

    public delegate void TestFatherDelegate(Father father);

    public delegate void TestSonDelegate(Son son);

    public delegate void TestObjDelegate<T>(T obj);

}
