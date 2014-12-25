using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C16_委托事件案例_三击按钮
{
    class MyTripleButton:System.Windows.Forms.Button
    {
        /// <summary>
        /// 定义一个用来保存用户方法的委托对象
        /// </summary>
        public event MyClickDelegate myClickDelegate;

        int count = 0;

        Timer timer = new Timer();

        public MyTripleButton()
        {
            base.Click += MyTripleButton_Click;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            count = 0;
        }

        void MyTripleButton_Click(object sender, EventArgs e)
        {
            if (count < 2)
            {
                if (count == 0)
                {
                    timer.Start();
                }
                count++;
            }
            else
            {
                //1.执行用户的方法
                if (myClickDelegate != null)
                {
                    myClickDelegate(System.DateTime.Now);
                }
                //2.清空点击次数
                count = 0;
                //3.重启计时器
                timer.Stop();
                timer.Start();
            }

        }

    }
}
