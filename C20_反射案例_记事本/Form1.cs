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
using C20_反射案例_记事本Interface;

namespace C20_反射案例_记事本
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeBtnDll();
        }

        /// <summary>
        /// 读取程序集,并生成插件按钮
        /// </summary>
        public void MakeBtnDll()
        {
            //1.加载正在运行的程序集的物理路径
            string strAssPath = this.GetType().Assembly.Location;
            //2.获取程序集所在文件夹,并转成插件程序集文件夹的路径
            string strDircPath = System.IO.Path.GetDirectoryName(strAssPath) + "\\plugs";
            //3.扫描程序集文件路径,并加载程序集文件
            string[] strDllPaths = System.IO.Directory.GetFiles(strDircPath, "*.dll");
            //4.遍历程序集文件路径,并加载程序集到内存中
            foreach (string  strDll in strDllPaths)
            {
                //4.1根据路径加载程序集文件到内存中
                Assembly ass = Assembly.LoadFrom(strDll);
                //4.2判断程序集中是否有插件类
                //4.2.1获取插件程序集公有的类
                Type[] types = ass.GetExportedTypes();
                //重要:获取插件接口类型对象
                Type plugType = typeof(IPlug);
                //4.2.2循环遍历插件程序集里的类型,判断是否实现了记事本接口
                foreach (Type t in types)
                {
                    //4.2.3判断 t 是否实现了接口IPlug
                    if (plugType.IsAssignableFrom(t))
                    {
                        //4.3创建插件按钮
                        ToolStripMenuItem menuItem = new ToolStripMenuItem(t.Name);
                        this.tsmiPlugs.DropDownItems.Add(menuItem);
                        //为所有的按钮点击事件都绑定同一个方法
                        menuItem.Click += menuItem_Click;
                        //重要:根据插件类型,创建插件类对象,并转成接口对象统一调用
                        IPlug iplugObj = Activator.CreateInstance(t) as IPlug;
                        //将接口对象存入按钮的Tag属性
                        menuItem.Tag = iplugObj;
                    }
                }             
            }

        }

        void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            //从按钮中取出对象的插件对象
            IPlug iPlug = menuItem.Tag as IPlug;
            this.textBox1.Text = iPlug.ProcessText(this.textBox1.Text);
        }
    }
}
