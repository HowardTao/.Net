using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_委托事件
{
    class MyButtonEvent:System.Windows.Forms.Button
    {
        //1.私有化委托变量,是的外部无法直接操作修改此对象
        public event MyClickDelegate myClickDelegate;

        public MyButtonEvent()
        {
            base.Click += MyButtonEvent_Click;
        }

        void MyButtonEvent_Click(object sender, EventArgs e)
        {
            if (myClickDelegate != null)
            {
                myClickDelegate(System.DateTime.Now);
            }
        }
    }
}
