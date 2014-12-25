namespace C15_委托事件
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.myButton1 = new C15_委托事件.MyButton();
            this.btnParam = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEach = new System.Windows.Forms.Button();
            this.btnSortByInterface = new System.Windows.Forms.Button();
            this.btnSortByDelegate = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnChangeStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myButton1
            // 
            this.myButton1.Location = new System.Drawing.Point(12, 12);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 23);
            this.myButton1.TabIndex = 0;
            this.myButton1.Text = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // btnParam
            // 
            this.btnParam.Location = new System.Drawing.Point(13, 115);
            this.btnParam.Name = "btnParam";
            this.btnParam.Size = new System.Drawing.Size(125, 23);
            this.btnParam.TabIndex = 1;
            this.btnParam.Text = "委托当参数";
            this.btnParam.UseVisualStyleBackColor = true;
            this.btnParam.Click += new System.EventHandler(this.btnParam_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(187, 115);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "委托当返回值";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEach
            // 
            this.btnEach.Location = new System.Drawing.Point(352, 115);
            this.btnEach.Name = "btnEach";
            this.btnEach.Size = new System.Drawing.Size(125, 23);
            this.btnEach.TabIndex = 3;
            this.btnEach.Text = "自定义循环方法";
            this.btnEach.UseVisualStyleBackColor = true;
            this.btnEach.Click += new System.EventHandler(this.btnEach_Click);
            // 
            // btnSortByInterface
            // 
            this.btnSortByInterface.Location = new System.Drawing.Point(13, 216);
            this.btnSortByInterface.Name = "btnSortByInterface";
            this.btnSortByInterface.Size = new System.Drawing.Size(125, 23);
            this.btnSortByInterface.TabIndex = 4;
            this.btnSortByInterface.Text = "利用接口排序";
            this.btnSortByInterface.UseVisualStyleBackColor = true;
            this.btnSortByInterface.Click += new System.EventHandler(this.btnSortByInterface_Click);
            // 
            // btnSortByDelegate
            // 
            this.btnSortByDelegate.Location = new System.Drawing.Point(187, 216);
            this.btnSortByDelegate.Name = "btnSortByDelegate";
            this.btnSortByDelegate.Size = new System.Drawing.Size(125, 23);
            this.btnSortByDelegate.TabIndex = 5;
            this.btnSortByDelegate.Text = "利用委托排序";
            this.btnSortByDelegate.UseVisualStyleBackColor = true;
            this.btnSortByDelegate.Click += new System.EventHandler(this.btnSortByDelegate_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(352, 216);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(125, 23);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "获取最大值";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnChangeStr
            // 
            this.btnChangeStr.Location = new System.Drawing.Point(518, 216);
            this.btnChangeStr.Name = "btnChangeStr";
            this.btnChangeStr.Size = new System.Drawing.Size(125, 23);
            this.btnChangeStr.TabIndex = 7;
            this.btnChangeStr.Text = "改造字符串";
            this.btnChangeStr.UseVisualStyleBackColor = true;
            this.btnChangeStr.Click += new System.EventHandler(this.btnChangeStr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 360);
            this.Controls.Add(this.btnChangeStr);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSortByDelegate);
            this.Controls.Add(this.btnSortByInterface);
            this.Controls.Add(this.btnEach);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnParam);
            this.Controls.Add(this.myButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton myButton1;
        private System.Windows.Forms.Button btnParam;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEach;
        private System.Windows.Forms.Button btnSortByInterface;
        private System.Windows.Forms.Button btnSortByDelegate;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnChangeStr;
    }
}

