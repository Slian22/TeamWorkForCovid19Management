
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueCast
{
    static class Program
    {
        public const string url = "https://3g.dxy.cn/newh5/view/pneumonia";
        public const string urlnews = "https://file1.dxycdn.com/2020/0130/492/3393874921745912795-115.json";
        public const string urloverall = "https://3g.dxy.cn/newh5/view/pneumonia";
        public const string navurl = "http://nav.werty.cn/";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
