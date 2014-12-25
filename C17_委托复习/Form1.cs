using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C17_委托复习
{

    public delegate void SayHiDelegate(string strName);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvokeInstanceMethod_Click(object sender, EventArgs e)
        {
            SayHiDelegate sayHiDelegate = new SayHiDelegate(SayHiChina);

            sayHiDelegate += new SayHiDelegate(SayHiChina);

            sayHiDelegate += new SayHiDelegate(SayHiStatic);

            TestSayHi(sayHiDelegate);
        }

        string strGender = "男";

        void TestSayHi(SayHiDelegate sayHiDelegate)
        {
            sayHiDelegate("test");
        }

        public void SayHiChina(string str)
        {
            MessageBox.Show("Hello~" + str + ",gender=" + this.strGender);
        }

        public static void SayHiStatic(string str)
        {
            MessageBox.Show("SayHiStatic =" + str);
        }
    }
}
