using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C14_窗體應用程序
{
    public partial class Form1 : Form
    {

        private Button btn;

        //構造函數
        public Form1()
        {
            InitializeComponent();
            btn = new Button();
            btn.Text = "按鈕";
            btn.Location = new Point(40, 40);
            this.Controls.Add(btn);

            btn.Click += btn_Click;
        }

        void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hhhhh","警告",MessageBoxButtons.OK,MessageBoxIcon.Question);

        }

        //窗體顯示之前，構造函數之後執行
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
