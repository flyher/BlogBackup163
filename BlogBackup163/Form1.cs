using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flyher.Road.Example;
using HtmlAgilityPack;
using System.Net;
using Flyher.Road.Net;
using System.IO;
using System.Web;
using System.Threading;

namespace BlogBackup163
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Blog163 bg = new Blog163();
        CookieContainer myCookieContainer = new CookieContainer();
        ConHttp ch = new ConHttp();
        HtmlPack hp = new HtmlPack();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://wap.blog.163.com/w2/login.do");
        }

        private void btnGetCookie_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Document.Cookie != null)
            {
                string cookieStr = webBrowser1.Document.Cookie;
                string[] cookstr = cookieStr.Split(';');
                foreach (string str in cookstr)
                { 
                    string[] cookieNameValue = str.Split('=');
                    if (cookieNameValue.Length != 2)
                    {
                        Cookie ck = new Cookie(cookieNameValue[0].Trim().ToString(), cookieNameValue[1].Trim().ToString()+"==");
                        ck.Domain = "wap.blog.163.com";
                        myCookieContainer.Add(ck);  
                    }
                    else
                    { 
                        Cookie ck = new Cookie(cookieNameValue[0].Trim().ToString(), cookieNameValue[1].Trim().ToString());
                        ck.Domain = "wap.blog.163.com";
                        myCookieContainer.Add(ck);                        
                    }
                }
                Invoke(new Action(() =>
                {
                    rtxtLog.AppendText("\n登录状态获取成功!\n");
                    rtxtLog.Focus();
                }));
            }
        }

        private void btnExquery_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            Thread t1 = new Thread(() => { Exquery(userName); });
            t1.IsBackground = true;
            t1.Start();
        }
        public void Exquery(string userName)
        {
            try
            {
                string blogUrl = "http://" + userName + ".wap.blog.163.com/w2/blogList.do?p=1";
                string html = ch.GetResponseHtml(blogUrl, "get", "", "application/x-www-form-urlencoded", "utf-8", myCookieContainer);
                HtmlNode hn = hp.ConvertHtml(html);

                int page = bg.PageCount(hn);

                Invoke(new Action(() =>
                {
                    rtxtLog.Text += "博客页数:" + page.ToString() + "\n";
                    rtxtLog.Focus();
                }));
                List<string> lst = new List<string>();
                for (int i = 1; i <= page; i++)
                {
                    if (i == 2)
                    {
                        string b = "";
                    }
                    string urlPage = "http://" + userName + ".wap.blog.163.com/w2/blogList.do?p=" + i.ToString();
                    string htmlPage = ch.GetResponseHtml(urlPage, "get", "", "application/x-www-form-urlencoded", "utf-8", myCookieContainer);
                    HtmlNode hnPage = hp.ConvertHtml(htmlPage);

                    int count = bg.ArtCount(hnPage);
                    for (int j = 1; j <= count; j++)
                    {
                        string title = bg.ArtTitle(hnPage, j);
                        string url = HttpUtility.UrlDecode(bg.ArtUrl(hnPage, j)).Replace("&amp;", "&") + "&showRest=true";
                        string pushTime = bg.ArtPushTime(hnPage, j);
                        string readcount = bg.ArtReadCount(hnPage, j);
                        string commentCount = bg.ArtCommentCount(hnPage, j);
                        string htmlArt = ch.GetResponseHtml(url, "get", "", "application/x-www-form-urlencoded", "utf-8", myCookieContainer);

                        CreateLogHtmlId("blog",("[" + i.ToString() + "_" + j.ToString() + "]" + "[" + pushTime + "]" + title).Replace(":", "#").Replace("\\", "_").Replace("/", ""), htmlArt);
                        Invoke(new Action(() =>
                        {
                            rtxtLog.AppendText("正在抓取:" + page.ToString() + "(" + i.ToString() + "-" + j.ToString() + ")\n");
                        }));
                    }

                }
            }
            catch (Exception err)
            {
                CreateLogHtmlId("log","error","[message]"+err.Message.ToString()+"[data]"+err.Data.ToString()+"[source]"+err.Source.ToString());
            }
            Invoke(new Action(() =>
            {
                rtxtLog.AppendText("备份成功！");
            }));
        }

        /// <summary>
        /// 保存获取的html源码
        /// </summary>
        public void CreateLogHtmlId(string path,string id, string json)
        {
            if (!Directory.Exists(path))
            {
                //创建日志文件夹
                Directory.CreateDirectory(path);
            }
            path += "\\" + id.ToString() + ".html";
            if (!System.IO.File.Exists(path))
            {
                System.IO.FileStream fs = System.IO.File.Create(path);
                fs.Close();
            }
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path, true))
            {
                if (json != null)
                {
                    sw.Write(json);
                }
                else
                {
                    //sw.Write("Exception is NULL");
                }
            }

        }
    }
}
