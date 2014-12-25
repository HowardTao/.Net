using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C01_Windows應用程序中的OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Clicked!";
            Button newButton = new Button();
            newButton.Text = "New Button!";
            newButton.Click += newButton_Click;
            Controls.Add(newButton);
        }

        void newButton_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Clicked!";
        }
    }
}
