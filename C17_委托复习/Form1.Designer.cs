namespace C17_委托复习
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
            this.btnInvokeInstanceMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInvokeInstanceMethod
            // 
            this.btnInvokeInstanceMethod.Location = new System.Drawing.Point(130, 60);
            this.btnInvokeInstanceMethod.Name = "btnInvokeInstanceMethod";
            this.btnInvokeInstanceMethod.Size = new System.Drawing.Size(192, 23);
            this.btnInvokeInstanceMethod.TabIndex = 0;
            this.btnInvokeInstanceMethod.Text = "委托调用实例方法";
            this.btnInvokeInstanceMethod.UseVisualStyleBackColor = true;
            this.btnInvokeInstanceMethod.Click += new System.EventHandler(this.btnInvokeInstanceMethod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 287);
            this.Controls.Add(this.btnInvokeInstanceMethod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvokeInstanceMethod;
    }
}

