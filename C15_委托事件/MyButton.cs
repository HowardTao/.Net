using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_委托事件
{
    /// <summary>
    /// 自定义委托类
    /// </summary>
    /// <param name="clickTime"></param>
    public delegate void MyClickDelegate(DateTime clickTime);

    class MyButton:System.Windows.Forms.Button
    {
        public MyClickDelegate myClickDelegate;
        public MyButton()
        {
            base.Click += MyButton_Click;
        }

        void MyButton_Click(object sender, EventArgs e)
        {
            if (myClickDelegate != null)
            {
                myClickDelegate(System.DateTime.Now);
            }
        }
    }
}
