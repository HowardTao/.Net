using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C15_委托事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.myButton1.myClickDelegate = new MyClickDelegate(MyClick);

            //1.手动创建自定义按钮
            MyButtonSelf btnMySelf = new MyButtonSelf();
            //2.将按钮添加到窗体上
            this.Controls.Add(btnMySelf);
            //3.设置按钮位置及文本
            btnMySelf.Text = "Self按钮";
            btnMySelf.Location = new Point(150, 30);
            btnMySelf.AddClickMethod(MyClick);

            MyButtonEvent btnEvent = new MyButtonEvent();
            this.Controls.Add(btnEvent);
            btnEvent.Text = "Event按钮";
            btnEvent.Location = new Point(250, 30);
            //4.为委托追加方法
            btnEvent.myClickDelegate += MyClick;
        }

        public void MyClick(DateTime clickTime)
        {
            MessageBox.Show("我被点击了---->" + clickTime);
        }

        #region 1.委托当参数
        private void btnParam_Click(object sender, EventArgs e)
        {
            InvokeTest(MyClick);
        }

        /// <summary>
        /// 委托单参数
        /// </summary>
        /// <param name="myDelegate"></param>
        public void InvokeTest(MyClickDelegate myDelegate)
        {
            myDelegate(System.DateTime.Now);
        } 
        #endregion

        #region 2.委托当返回值
        private void btnReturn_Click(object sender, EventArgs e)
        {
            MyClickDelegate myDelegate = InvokeTest("1");
            myDelegate(DateTime.Now);
        }

        /// <summary>
        /// 委托当返回值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public MyClickDelegate InvokeTest(string str)
        {
            switch (str)
            {
                case "1":
                    return MyClick;
                default:
                    return MyClick;
            }
        } 
        #endregion

        #region 3.自定义循环方法
        private void btnEach_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list.Add("刘德华");
            list.Add("张学友");
            list.Add("郭富城");
            list.Add("黎明");
            Each(list, ShowName);
        }

        public delegate void EachFuncDelegate(int index, object item);

        void ShowName(int index, object item)
        {
            MessageBox.Show("index:" + index + ";Name:" + item);
        }
        /// <summary>
        /// 遍历集合,并一次调用的回调方法
        /// </summary>
        /// <param name="list">集合</param>
        /// <param name="func">回调方法委托</param>
        public void Each(ArrayList list, EachFuncDelegate func)
        {
            for (int i = 0; i < list.Count; i++)
            {
                func(i, list[i]);
            }
        } 
        #endregion

        #region 4.利用接口排序
        private void btnSortByInterface_Click(object sender, EventArgs e)
        {
            List<Dog> list = new List<Dog>();
            list.Add(new Dog() { name = "小白", age = 10 });
            list.Add(new Dog() { name = "小黑", age = 1 });
            list.Add(new Dog() { name = "小黃", age = 5 });
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ":" + list[i].name + ",age:" + list[i].age);
            }
            list.Sort(new CompareDog());
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ":" + list[i].name + ",age:" + list[i].age);
            }
        } 
        #endregion

        #region 5.利用委托排序
        private void btnSortByDelegate_Click(object sender, EventArgs e)
        {
            List<Dog> list = new List<Dog>();
            list.Add(new Dog() { name = "小白", age = 10 });
            list.Add(new Dog() { name = "小黑", age = 1 });
            list.Add(new Dog() { name = "小黃", age = 5 });
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ":" + list[i].name + ",age:" + list[i].age);
            }
            list.Sort(ComparisonDog);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + ":" + list[i].name + ",age:" + list[i].age);
            }
        }

        int ComparisonDog(Dog x, Dog y)
        {
            return x.age - y.age;
        } 
        #endregion

        #region 6.获取最大值
        private void btnMax_Click(object sender, EventArgs e)
        {
            int[] arrInt = new int[5] { 1, 40, 11, 52, 5 };
            int maxInt = MaxValue<int>(arrInt, (x, y) => x - y);
            Console.WriteLine(maxInt);

            string[] arrStr = new string[] { "aaa", "dd", "ffffff" };
            string maxLenStr = MaxValue<string>(arrStr, (x, y) => x.Length - y.Length);
            Console.WriteLine(maxLenStr);

            Dog[] dogs = new Dog[] { new Dog { age = 1, name = "小白" }, new Dog { age = 5, name = "小黑" }, new Dog { age = 2, name = "小黃" } };
            Dog maxAgeDog = MaxValue<Dog>(dogs, (x, y) => x.age - y.age);
            Console.WriteLine(maxAgeDog.age);
        }

        /// <summary>
        /// 通用Max方法
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="arr">对象数组</param>
        /// <param name="func">比较方法</param>
        /// <returns></returns>
        T MaxValue<T>(T[] arr, Comparison<T> func)
        {
            T maxInt = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                //使用委托来完成元素的大小比较
                if (func(maxInt, arr[i]) < 0)
                {
                    maxInt = arr[i];
                }
            }
            return maxInt;
        } 
        #endregion

        #region 7.改造字符串
        private void btnChangeStr_Click(object sender, EventArgs e)
        {
            string[] strArr = { "sss", "dddd", "嘎嘎嘎" };
            string[] strNew = ChangeStrArr(strArr, ChangeStr);
            for (int i = 0; i < strNew.Length; i++)
            {
                Console.WriteLine(strNew[i]);
            }
        }

        public delegate string ChangeStrDelegate(string str);

        string[] ChangeStrArr(string[] arrStr, ChangeStrDelegate myDelegate)
        {
            string[] arrStrNew = new string[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                //调用传入的委托对象的方法
                arrStrNew[i] = myDelegate(arrStr[i]);
            }
            return arrStrNew;
        }

        string ChangeStr(string str)
        {
            return str + "123";
        } 
        #endregion
        

    }
}
