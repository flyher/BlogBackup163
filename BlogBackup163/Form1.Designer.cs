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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.btnExquery = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGetCookie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackBlogImg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabP = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxtPhotoContent = new System.Windows.Forms.RichTextBox();
            this.btnBackUpPhoto = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabP.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(16, 335);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.rtxtLog.Size = new System.Drawing.Size(723, 133);
            this.rtxtLog.TabIndex = 1;
            this.rtxtLog.Text = "";
            // 
            // btnExquery
            // 
            this.btnExquery.Location = new System.Drawing.Point(60, 169);
            this.btnExquery.Name = "btnExquery";
            this.btnExquery.Size = new System.Drawing.Size(100, 27);
            this.btnExquery.TabIndex = 2;
            this.btnExquery.Text = "执行备份";
            this.btnExquery.UseVisualStyleBackColor = true;
            this.btnExquery.Click += new System.EventHandler(this.btnExquery_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(67, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(93, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(6, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 22);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(522, 279);
            this.webBrowser1.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(60, 71);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 27);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGetCookie
            // 
            this.btnGetCookie.Location = new System.Drawing.Point(60, 119);
            this.btnGetCookie.Name = "btnGetCookie";
            this.btnGetCookie.Size = new System.Drawing.Size(100, 27);
            this.btnGetCookie.TabIndex = 7;
            this.btnGetCookie.Text = "获取登录状态";
            this.btnGetCookie.UseVisualStyleBackColor = true;
            this.btnGetCookie.Click += new System.EventHandler(this.btnGetCookie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名:";
            // 
            // btnBackBlogImg
            // 
            this.btnBackBlogImg.Location = new System.Drawing.Point(60, 218);
            this.btnBackBlogImg.Name = "btnBackBlogImg";
            this.btnBackBlogImg.Size = new System.Drawing.Size(100, 27);
            this.btnBackBlogImg.TabIndex = 9;
            this.btnBackBlogImg.Text = "备份图片";
            this.btnBackBlogImg.UseVisualStyleBackColor = true;
            this.btnBackBlogImg.Click += new System.EventHandler(this.btnBackBlogImg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBackBlogImg);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.btnGetCookie);
            this.groupBox1.Controls.Add(this.btnExquery);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Location = new System.Drawing.Point(534, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 279);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工具栏";
            // 
            // tabP
            // 
            this.tabP.Controls.Add(this.tabPage1);
            this.tabP.Controls.Add(this.tabPage2);
            this.tabP.Controls.Add(this.tabPage3);
            this.tabP.Location = new System.Drawing.Point(12, 12);
            this.tabP.Name = "tabP";
            this.tabP.SelectedIndex = 0;
            this.tabP.Size = new System.Drawing.Size(731, 317);
            this.tabP.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "博文及图片";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxtPhotoContent);
            this.tabPage2.Controls.Add(this.btnBackUpPhoto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "相册";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxtPhotoContent
            // 
            this.rtxtPhotoContent.Location = new System.Drawing.Point(7, 7);
            this.rtxtPhotoContent.Name = "rtxtPhotoContent";
            this.rtxtPhotoContent.Size = new System.Drawing.Size(561, 278);
            this.rtxtPhotoContent.TabIndex = 2;
            this.rtxtPhotoContent.Text = "";
            // 
            // btnBackUpPhoto
            // 
            this.btnBackUpPhoto.Location = new System.Drawing.Point(607, 203);
            this.btnBackUpPhoto.Name = "btnBackUpPhoto";
            this.btnBackUpPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnBackUpPhoto.TabIndex = 1;
            this.btnBackUpPhoto.Text = "开始";
            this.btnBackUpPhoto.UseVisualStyleBackColor = true;
            this.btnBackUpPhoto.Click += new System.EventHandler(this.btnBackUpPhoto_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(723, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "帮助";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(699, 284);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 480);
            this.Controls.Add(this.tabP);
            this.Controls.Add(this.rtxtLog);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlogBackUp163";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabP.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Button btnExquery;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGetCookie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackBlogImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabP;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBackUpPhoto;
        private System.Windows.Forms.RichTextBox rtxtPhotoContent;
    }
}

