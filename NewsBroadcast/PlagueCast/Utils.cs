using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueCast
{
    public static class Utils
    {
        private static WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };

        public static string httpGet(string url) {
            try
            {
                HttpWebRequest req = BomberUtils.MakeHttpGet(url);
                return BomberUtils.GetHttpResponse(req);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                try
                {
                    return BomberUtils.httpGetSlice(url);
                }
                catch (Exception ex2) {
                    Console.WriteLine(ex2.ToString());
                    return null;
                }
            }
        }
        

        public static string SearchJson(string html, string begin) {
            int beginIndex = html.IndexOf(begin);
            if (beginIndex == -1) { return null; }
            beginIndex += begin.Length;

            char[] begins = "[{".ToCharArray();
            int small = 0, medium = 0;
            int ptr = beginIndex;
            while (!begins.Contains(html[ptr])) {
                ptr++;
            }
            StringBuilder sb = new StringBuilder();
            bool insideComma = false;
            bool ignoreBackSlash = false;
            do
            {
                if (!ignoreBackSlash)
                {
                    if (html[ptr] == '\"') { insideComma = !insideComma; }
                    if (!insideComma)
                    {
                        if (html[ptr] == '[') { small++; }
                        if (html[ptr] == '{') { medium++; }
                        if (html[ptr] == ']') { small--; }
                        if (html[ptr] == '}') { medium--; }
                    }
                    else
                    {
                        if (html[ptr] == '\\') { ignoreBackSlash = false; }
                    }
                }
                else
                {
                    ignoreBackSlash = false;
                }
                sb.Append(html[ptr]);
                ptr++;
            }
            while (small != 0 || medium != 0);
            return sb.ToString();
        }

        public static DateTime parstUnixTime(long time) {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            DateTime dt = startTime.AddSeconds(time/1000);
            return dt;
        }

    }

    public static class BomberUtils
    {


        public static string useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:72.0) Gecko/20100101 Firefox/72.0";
        

        public static HttpWebRequest MakeHttpGet(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Timeout = 9999;
            req.Method = "GET";
            req.Headers.Add("Accept-Encoding", "gzip, deflate");
            req.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            return req;
        }

        public static string GetHttpResponse(HttpWebRequest req)
        {
            string result = "";
            try
            {
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                MemoryStream ms = new MemoryStream();
                byte[] buffer = new byte[1024];
                int len = 0;
                int err = 0;
                while (err < 64)
                {
                    try
                    {
                        while ((len = stream.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            ms.Write(buffer, 0, len);
                        }
                        err = 65;
                    }
                    catch (IOException ex)
                    {
                        Console.Write(err);
                        err++;
                        System.Threading.Thread.Sleep(25);
                    }
                }
                ms.Seek(0, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(ms, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
                ms.Dispose();
                return result;
            }
            catch (WebException ex)
            {
                if (null == ex.Response)
                {
                    throw ex;
                }
                if ((int)((HttpWebResponse)ex.Response).StatusCode < 400)
                {
                    return ex.Message;
                }
                throw ex;
            }
        }

        public static string httpGetSlice(string url) {
            long len = GetHttpLength(url);
            long sliceSize = 10240;
            using (MemoryStream ms = new MemoryStream())
            {
                for (long ptr = 0; ptr < len; ptr += sliceSize)
                {
                    long end = ptr + sliceSize;
                    if (end > len) { end = len; }
                    end--;
                    downloadPart(url, ptr, end, ms);
                }
                using (StreamReader reader = new StreamReader(ms, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        static long GetHttpLength(string url)
        {
            var length = 0l;
            try
            {
                var req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
                req.Method = "HEAD";
                req.Timeout = 5000;
                var res = (HttpWebResponse)req.GetResponse();
                if (res.StatusCode == HttpStatusCode.OK)
                {
                    length = res.ContentLength;
                }
                

                res.Close();
                return length;
            }
            catch (WebException wex)
            {
                throw;
            }
        }

        public static void downloadPart(string url, long start, long end, Stream sout) {
            HttpWebRequest req = BomberUtils.MakeHttpGet(url);
            req.AddRange(start, end);
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            if (resp.StatusCode == HttpStatusCode.PartialContent || (resp.StatusCode==HttpStatusCode.OK && resp.ContentLength==end-start+1))
            {
                copyStream(resp.GetResponseStream(), sout);
            }
            else {
                throw new Exception("Server not support slice");
            }
        }

        private static void copyStream(Stream sin, Stream sout) {
            byte[] buffer = new byte[1024];
            int len = 0;
            while ((len = sin.Read(buffer, 0, buffer.Length)) != 0)
            {
                sout.Write(buffer, 0, len);
            }     
        }

    }

    public static class JsonConvert {
        private static System.Web.Script.Serialization.JavaScriptSerializer jsonc = new System.Web.Script.Serialization.JavaScriptSerializer();
        public static T DeserializeObject<T>(string json) {
            return jsonc.Deserialize<T>(json);
        }

    }
}
