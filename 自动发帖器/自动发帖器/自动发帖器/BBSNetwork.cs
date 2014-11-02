using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace 自动发帖器
{
    public class BBSNetwork
    {
        public string BBSusername, BBSpassword;
        public bool success;

        static public string getPostUrl(string page)
        {
            string pattern = "mod=post&action=reply&fid=[0-9]+&tid=[0-9]+";
            MatchCollection matches = Regex.Matches(page, pattern);
            string ans = matches[0].ToString();
            return "http://discuz.doubi.me/forum.php?" + ans + "&extra=&replysubmit=yes&infloat=yes&handlekey=fastpost&inajax=1";
        }
        static public string getPostTime(string page)
        {
            string pattern = "<input type=\"hidden\" name=\"posttime\" id=\"posttime\" value=\"[0-9]+\" />";
            MatchCollection matches = Regex.Matches(page, pattern);
            string[] ans = matches[0].ToString().Split('\"');
            return ans[ans.Length - 2];
        }
        static public string getFormHash(string page)
        {
            string pattern = "<input type=\"hidden\" name=\"formhash\" value=\".+\" />";
            MatchCollection matches = Regex.Matches(page, pattern);
            string[] ans = matches[0].ToString().Split('\"');
            return ans[ans.Length - 2];
        }
        static public string getPageNum(string page)
        {
            string pattern = "<span title=\".+\"> / [0-9]+ 页</span>";
            MatchCollection matches = Regex.Matches(page, pattern);
            if (matches.Count == 0)
            {
                return "1";
            }
            return matches[0].ToString().Split(' ')[5];
        }
        CookieContainer cc = new CookieContainer();
        public BBSNetwork(string username, string password)
        {
            BBSusername = username;
            BBSpassword = password;
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://discuz.doubi.me/member.php?mod=logging&action=login&loginsubmit=yes&infloat=yes&lssubmit=yes&inajax=1");
            myReq.CookieContainer = cc;
            myReq.ContentType = "application/x-www-form-urlencoded";
            myReq.Method = "POST";
            string postData = "fastloginfield=username&username=" + username + "&password=" + password + "&quickforward=yes&handlekey=ls";
            byte[] postDataByte = Encoding.Default.GetBytes(postData);
            Stream ReqStream = myReq.GetRequestStream();
            ReqStream.Write(postDataByte, 0, postDataByte.Length);
            ReqStream.Close();
            HttpWebResponse myRep = (HttpWebResponse)myReq.GetResponse();
            StreamReader myReader = new StreamReader(myRep.GetResponseStream());
            string ans = myReader.ReadToEnd();
            if (ans.IndexOf("discuz.doubi.me")>=0)
            {
                success = true;
            }
            else 
            {
                success = false;
            }
        }
        public string Get(string url)
        {
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(url);
            myReq.Method = "GET";
            myReq.CookieContainer = cc;
            HttpWebResponse myRep = (HttpWebResponse)myReq.GetResponse();
            StreamReader myReader = new StreamReader(myRep.GetResponseStream());
            return myReader.ReadToEnd();
        }
        public void PostMessage(string tid, string message)
        {
            string pageUrl = "http://discuz.doubi.me/forum.php?mod=viewthread&tid=" + tid;
            string page = Get(pageUrl);
            string PostUrl = getPostUrl(page);
            string PostTime = getPostTime(page);
            string FormHash = getFormHash(page);
            string PostData = "message=" + message + "&posttime=" + PostTime + "&formhash=" + FormHash + "&usesig=1&subject=++";
            byte[] PostDataByte = Encoding.UTF8.GetBytes(PostData);
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(PostUrl);
            myReq.CookieContainer = cc;
            myReq.Method = "POST";
            myReq.ContentType = "application/x-www-form-urlencoded";
            Stream reqStream = myReq.GetRequestStream();
            reqStream.Write(PostDataByte, 0, PostDataByte.Length);
            reqStream.Close();
            HttpWebResponse myRep = (HttpWebResponse)myReq.GetResponse();
            StreamReader myReader = new StreamReader(myRep.GetResponseStream());
            string ans = myReader.ReadToEnd();
        }
        public void PostSubject(string fid, string subject, string message)
        {
            string pageUrl = "http://discuz.doubi.me/forum.php?mod=forumdisplay&fid=" + fid;
            string page = Get(pageUrl);
            string PostTime = getPostTime(page);
            string FormHash = getFormHash(page);
            string PostData = "subject=" + subject + "&message=" + message + "&formhash=" + FormHash + "&usesig=1&posttime=" + PostTime;
            byte[] PostDataByte = Encoding.UTF8.GetBytes(PostData);
            string PostUrl = "http://discuz.doubi.me/forum.php?mod=post&action=newthread&fid=" + fid + "&topicsubmit=yes&infloat=yes&handlekey=fastnewpost&inajax=1";
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(PostUrl);
            myReq.CookieContainer = cc;
            myReq.Method = "POST";
            myReq.ContentType = "application/x-www-form-urlencoded";
            Stream reqStream = myReq.GetRequestStream();
            reqStream.Write(PostDataByte, 0, PostDataByte.Length);
            reqStream.Close();
            HttpWebResponse myRep = (HttpWebResponse)myReq.GetResponse();
            StreamReader myReader = new StreamReader(myRep.GetResponseStream());
            string ans = myReader.ReadToEnd();
            Console.Write(ans);
        }
        public string GetFidName(string fid)
        {
            string pageUrl = "http://discuz.doubi.me/forum.php?mod=forumdisplay&fid=" + fid;
            string page = Get(pageUrl);
            string pattern = "<meta name=\"keywords\" content=\".+\" />";
            MatchCollection matches = Regex.Matches(page, pattern);
            return matches[0].ToString().Split('\"')[3];
        }
        public string[] GetAllTidInFid(string fid)
        {
            string baseUrl = "http://discuz.doubi.me/forum.php?mod=forumdisplay&fid=" + fid + "&page=";
            int page_num = int.Parse(getPageNum(Get(baseUrl + "1")));
            string ans = "";
            for(int i = 1; i <= page_num; ++i)
            {
                string page = Get(baseUrl + i.ToString());
                string pattern = "<a href=\"forum\\.php\\?mod=viewthread&amp;tid=[0-9]+&amp;extra=page%3D[0-9]+\" onclick=\"atarget\\(this\\)\" class=\"s xst\">.+</a>";
                MatchCollection matches = Regex.Matches(page, pattern);
                for(int j = 0; j < matches.Count; ++j)
                {
                    string tid = matches[j].ToString().Split('&')[1].Split('=')[1];
                    ans = ans + tid + ";";
                }
            }
            //------------------------------------------------------------------------------------------------------------
            ans = ans.Substring(0, ans.Length - 1);// When there aren't any tid in this fid, it will occur exception 
            //------------------------------------------------------------------------------------------------------------
            return ans.Split(';');
        }
        public List<string> GetContent(string tid)
        {
            int page_num = int.Parse(getPageNum(Get("http://discuz.doubi.me/forum.php?mod=viewthread&tid=" + tid)));
            List<string> ans = new List<string>();
            for (int i = 1; i <= page_num; ++i)
            {
                string page = Get("http://discuz.doubi.me/forum.php?mod=viewthread&tid=" + tid + "&extra=&page=" + i.ToString());
                string pattern = "<table cellspacing=\"0\" cellpadding=\"0\"><tr><td class=\"t_f\" id=\"[\\s\\S]*?</table>";
                MatchCollection matches = Regex.Matches(page, pattern);
                Console.WriteLine(i.ToString() + " " + matches.Count.ToString());
                for (int j = 0; j < matches.Count; ++j)
                {
                    string cont = matches[j].ToString().Split('>')[3].Split('<')[0].Trim();
                    ans.Add(cont);
                }
            }
            return ans;
        }
        public string getTidTitle(string tid)
        {
            string page = Get("http://discuz.doubi.me/forum.php?mod=viewthread&tid=" + tid);
            string pattern = "<span id=\"thread_subject\">.*</span>";
            MatchCollection matches = Regex.Matches(page, pattern);
            return matches[0].ToString().Split('>')[1].Split('<')[0];
        }
        public string[] getAllFid()
        {
            string page = Get("http://discuz.doubi.me/forum.php");
            string pattern = "od=forumdisplay&fid=[0-9]+\"><img src=\"static/image/common/forum.gif\" alt=\".*\" /></a>";
            MatchCollection matches = Regex.Matches(page, pattern);
            string ans = "";
            for (int i = 0; i < matches.Count; ++i)
            {
                ans += matches[i].ToString().Split('>')[0].Split('=')[2].Split('\"')[0] + ";";
            }
            return ans.Substring(0, ans.Length - 1).Split(';');
        }
        public void logout()
        {
            string page = Get("http://discuz.doubi.me/forum.php");
            string formHash = getFormHash(page);
            string ans = Get("http://discuz.doubi.me/member.php?mod=logging&action=logout&formhash=" + formHash);
        }
    }
}
