using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C16_委托事件案例_三击按钮
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.myTripleButton1.myClickDelegate += myTripleButton1_myClickDelegate;
        }

        void myTripleButton1_myClickDelegate(DateTime clickTime)
        {
            MessageBox.Show("三击事件--->"+clickTime);

        }
    }
}
