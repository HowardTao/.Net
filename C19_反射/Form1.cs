using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace C19_反射
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 反射获取成员
        private void button1_Click(object sender, EventArgs e)
        {
            //*************普通方式创建和调用******************
            Dog d = new Dog();
            d.name = "tttt";
            d.Shout();

            //***************反射获取类成员*********************
            //1.获取当前正在运行的程序集（Assembly）对象
            //获取当前运行对象所属的类所在的程序集对象
            Assembly ass = this.GetType().Assembly;
            //2.获取程序集中的Dog类的类型（Type）对象
            Type tDog = ass.GetType("C19_反射.Dog");
            //3.获取Dog类的name字段对象
            FieldInfo fieldInfo = tDog.GetField("name");
            //4.获取Dog类的Shout()方法对象
            MethodInfo methodInfo = tDog.GetMethod("Shout");

            //**************反射调用类成员************************
            //1.根据Dog的Type对象，实例化一个Dog对象
            Dog d2 = Activator.CreateInstance(tDog) as Dog;
            //Dog d3 = Activator.CreateInstance<Dog>();//一般不用

            //2.使用Dog类的name字段对象，为d2实例的name字段赋值
            fieldInfo.SetValue(d2, "小白");

            //3.使用Dog类的Shout()方法对象，调用d2实例的Shout()方法
            //其实就是执行方法体代码，并将d2设置为方法里的this
            methodInfo.Invoke(d2, null);


        } 
        #endregion

        #region 反射加载当前程序域里的程序集
        private void button2_Click(object sender, EventArgs e)
        {
            C19_反射_BLL.Class1 c = new C19_反射_BLL.Class1();
            //对于正在运行的程序域来说，并不是所有的外部添加的程序集引用在运行的时候会立即加载到当前的程序域中
            //而是当代码里有使用到外部引用的程序集的时候，才会被JIT加载进来
            Assembly[] ass = AppDomain.CurrentDomain.GetAssemblies();
        } 
        #endregion

        #region 反射加载程序集
        private void button3_Click(object sender, EventArgs e)
        {
            string strPath = @"C:\Project\Study\C19_反射\libs\C18_泛型.exe";
            Assembly ass = Assembly.LoadFrom(strPath);
        } 
        #endregion

        #region 反射获取Type
        private void button4_Click(object sender, EventArgs e)
        {
            Assembly ass = this.GetType().Assembly;
            //通过程序集获取Type
            //1.通过类的全名称获取类的类型对象
            Type t = ass.GetType("C19_反射.Dog");
            //2.通过程序集获取所有公共类型对象
            Type[] typesPublic = ass.GetExportedTypes();
            //3.通过程序集获取所有的类型
            Type[] typesAll = ass.GetTypes();

            //获取单个类型对象
            //1.通过类直接获取类型对象
            Type t2 = typeof(Dog);
            //2.通过对象来获取类型对象
            Type t3 = this.GetType();

            Dog d = new Dog();
            Type t4 = d.GetType();
        } 
        #endregion


    }
}
