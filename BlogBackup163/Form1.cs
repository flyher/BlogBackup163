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
using Flyher.Road.Files;
using HtmlAgilityPack;
using System.Net;
using Flyher.Road.Net;
using System.IO;
using System.Web;
using System.Threading;
using System.Text.RegularExpressions;

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
        FileControl fc = new FileControl();
        RegexMatch rm = new RegexMatch();

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
                   
        private void btnBackBlogImg_Click(object sender, EventArgs e)
        {
            List<string> lst= fc.GetFiles("blog", "*.html", SearchOption.TopDirectoryOnly);
            int count = lst == null ? 0 : lst.Count;

            Invoke(new Action(() =>
            {
                rtxtLog.AppendText("共:" + count.ToString() + "篇博文\n");
            }));
            if (count>0)
            {
                //ExqueryBlogImg(lst);

                Thread t1 = new Thread(() => { ExqueryBlogImg(lst); });
                t1.IsBackground = true;
                t1.Start();
            }
            
        }

        #region 处理博客
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

                        CreateLogHtmlId("blog", ("[" + i.ToString() + "_" + j.ToString() + "]" + "[" + pushTime + "]" + title).Replace(":", "#").Replace("\\", "_").Replace("/", ""), htmlArt,true);
                        Invoke(new Action(() =>
                        {
                            rtxtLog.AppendText("正在抓取:" + page.ToString() + "(" + i.ToString() + "-" + j.ToString() + ")\n");
                        }));
                    }

                }
            }
            catch (Exception err)
            {
                CreateLogHtmlId("log", "error", "[message]" + err.Message.ToString() + "[data]" + err.Data.ToString() + "[source]" + err.Source.ToString(),true);
            }
            Invoke(new Action(() =>
            {
                rtxtLog.AppendText("备份成功！\n");
            }));
        }

        /// <summary>
        /// 保存获取的html源码
        /// </summary>
        public void CreateLogHtmlId(string path, string id, string json,bool ishtml)
        {
            if (!Directory.Exists(path))
            {
                //创建日志文件夹
                Directory.CreateDirectory(path);
            }
            if (ishtml)
            {
                path += "\\" + id.ToString() + ".html";
            }
            else {
                path += "\\" + id.ToString();
            }
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
        #endregion

        #region 处理图片
        public void ExqueryBlogImg(List<string> lst)
        {
            rtxtLog.Focus();
            for (int i = 0; i < lst.Count; i++)
            {
                string path = lst[i];

                StreamReader sr = new StreamReader(path);
                string[] files = path.Split(Convert.ToChar("\\"));
                string file = files[files.Length - 1].Replace(".html", "");

                string article = sr.ReadToEnd();
                Regex r = new Regex("http://img[0-9]{1}.ph.126.net/[^\"]+");
                List<string> lstPics = rm.GetAims(article, r);

                for (int j = 0; j < lstPics.Count; j++)
                {
                    string[] urls = lstPics[j].Split(Convert.ToChar("/"));
                    string picname = urls[urls.Length - 1];
                    string filepath = "img/" + file + "/" + picname;
                    if (!Directory.Exists("img/" + file))
                    {
                        Directory.CreateDirectory("img/" + file);
                    }
                    //if (!Directory.Exists("img"))
                    //{
                    //    Directory.CreateDirectory("img");
                    //}
                    try
                    {
                        Image img = ch.GetResponseImage(lstPics[j], "image/png");
                        img.Save(filepath);
                        rtxtLog.AppendText(filepath + " 成功\n");
                    }
                    catch (Exception err)
                    {
                        rtxtLog.AppendText(filepath + " 失败\n");
                    }
                }
            }

        }

        #endregion
    }
}
