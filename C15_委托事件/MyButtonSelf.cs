using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_委托事件
{
    class MyButtonSelf:System.Windows.Forms.Button
    {
        //1.私有化委托变量,使得外部无法直接修改此对象
        private MyClickDelegate myClickDelegate;
        //2.提供注册方法的方式,来为委托对象注册
        public void AddClickMethod(MyClickDelegate myDelegate)
        {
            myClickDelegate += myDelegate;
        }

        public MyButtonSelf()
        {
            base.Click += MyButtonSelf_Click;
        }

        void MyButtonSelf_Click(object sender, EventArgs e)
        {
            if (myClickDelegate != null)
            {
                myClickDelegate(System.DateTime.Now);
            }
        }

    }
}
