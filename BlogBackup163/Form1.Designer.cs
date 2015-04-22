namespace BlogBackup163
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
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.btnExquery = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGetCookie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(228, 12);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtxtLog.Size = new System.Drawing.Size(199, 360);
            this.rtxtLog.TabIndex = 1;
            this.rtxtLog.Text = "1.输入用户名，点击打开(页面会打开网易博客的登录页面)，输入自己的信息登录(代码开源，该程序不经过任何第三方服务器).\n2.登录成功后，点击\"获取登录状态\";\n" +
    "3.获取成功之后，点击执行备份。会自动在程序目录下新建一个blog文件夹执行备份。";
            // 
            // btnExquery
            // 
            this.btnExquery.Location = new System.Drawing.Point(446, 198);
            this.btnExquery.Name = "btnExquery";
            this.btnExquery.Size = new System.Drawing.Size(100, 23);
            this.btnExquery.TabIndex = 2;
            this.btnExquery.Text = "执行备份";
            this.btnExquery.UseVisualStyleBackColor = true;
            this.btnExquery.Click += new System.EventHandler(this.btnExquery_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(446, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(199, 360);
            this.webBrowser1.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(446, 100);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGetCookie
            // 
            this.btnGetCookie.Location = new System.Drawing.Point(446, 152);
            this.btnGetCookie.Name = "btnGetCookie";
            this.btnGetCookie.Size = new System.Drawing.Size(100, 23);
            this.btnGetCookie.TabIndex = 7;
            this.btnGetCookie.Text = "获取登录状态";
            this.btnGetCookie.UseVisualStyleBackColor = true;
            this.btnGetCookie.Click += new System.EventHandler(this.btnGetCookie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetCookie);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnExquery);
            this.Controls.Add(this.rtxtLog);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlogBackUp163 V0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Button btnExquery;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGetCookie;
        private System.Windows.Forms.Label label1;

    }
}

