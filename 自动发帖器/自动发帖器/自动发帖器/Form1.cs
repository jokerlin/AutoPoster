using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 自动发帖器
{
    public partial class 自动发帖器 : Form
    {
        public static string loginConfigFile = "UserLogin.cfg";
        public static string subjectContent = "SubjectManager.cfg";
        public static string tidContent = "TidManager.cfg";
        public static int[] fidArray = new int[] { 2, 37, 38, 39 };
        //------------------------------------------------------------------------------------------------
        public Dictionary<string, string> namepass = new Dictionary<string, string>();
        public Dictionary<int, string> numname = new Dictionary<int, string>();
        public List<BBSNetwork> loginlist = new List<BBSNetwork>();

        public Dictionary<string, string> tico = new Dictionary<string, string>();
        public Dictionary<int, string> numti = new Dictionary<int, string>();

        public Dictionary<int, int> numsub = new Dictionary<int, int>();
        public Dictionary<int, string> numtid = new Dictionary<int, string>();

        public BBSNetwork testlogin = new BBSNetwork("linheng", "linheng");
        public Dictionary<int, string> numcontent = new Dictionary<int, string>();

        
        //------------------------------------------------------------------------------------------------
        private void button_test_Click(object sender, EventArgs e)
        {
            //BBSNetwork bbs = new BBSNetwork("ttttttt", "ttttttt");
            //string[] tidName = testlogin.GetAllTidInFid("2");
            //bbs.PostMessage("35", "test1621test1621test1621");
            //bbs.PostSubject("2", "test1615", "test1615test1615");
            //List<string> tmp = testlogin.GetContent("41");
            //string[] tmp = testlogin.getAllFid();
        }

        public delegate List<string> AddHandler();

        public 自动发帖器()
        {
            InitializeComponent();
            //加载皮肤
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Wave.ssk";
            Sunisoft.IrisSkin.SkinEngine se = null;
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;

            //异步调用
            AddHandler handler = new AddHandler(LoadSubjectName);
            //IAsyncResult result = handler.BeginInvoke(IASyncLoadSubject, handler);
            IAsyncResult result = handler.BeginInvoke(null, null);

            

            LoadUserCFG();
            LoadContent();
            LoadTidContent();
            //LoadSubjectName();
            //LoadSubjectName2();
            //LoadSubjectName3();
        }

        
        private void LoadUserCFG()
        {
            //设置Listview显示样式
            listView_readCFG.View = View.Tile;
            //清空Dictionary
            namepass.Clear();
            numname.Clear();
            try
            {
                StreamReader sr = new StreamReader(loginConfigFile, System.Text.Encoding.Default);
                int count = 0;
                while (sr.Peek() != -1)
                {
                    string user = sr.ReadLine();
                    string username = user.Substring(0, user.IndexOf(":"));
                    string password = user.Substring(user.IndexOf(":") + 1);
                    namepass.Add(username, password);
                    numname.Add(count, username);
                    count++;
                }
                foreach (string key in namepass.Keys)
                {
                    ListViewItem record = new ListViewItem(key);
                    listView_readCFG.Items.Add(record);
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("配置文件未找到！");
            }
        }

        private string[] Loadtid(string fid)
        {
            ////设置Listview显示样式
            //listView_tid.View = View.Tile;
            //listView_tid.MultiSelect = false;

            ////清空Listview
            //listView_tid.Clear();
            //清空List
            numtid.Clear();

            string[] tidName = testlogin.GetAllTidInFid(fid);
            List<string> tidRealName = new List<string>();

            int count = 0;
            foreach (string i in tidName)
            {
                numtid.Add(count, i);
                string tidname = testlogin.getTidTitle(i);
                tidRealName.Add(tidname);
                //ListViewItem record = new ListViewItem(tidname);
                //listView_tid.Items.Add(record);
                count++;
            }
            listviewOpt2(tidRealName);
            return tidName;
        }

        private string[] Loadtid2(string fid)
        {
            ////设置Listview显示样式
            //listView_tid2.View = View.Tile;
            //listView_tid2.MultiSelect = false;

            ////清空Listview
            //listView_tid2.Clear();
            //清空List
            numtid.Clear();

            string[] tidName = testlogin.GetAllTidInFid(fid);
            List<string> tidRealName = new List<string>();

            int count = 0;
            foreach (string i in tidName)
            {
                numtid.Add(count, i);
                string tidname = testlogin.getTidTitle(i);
                tidRealName.Add(tidname);
                //ListViewItem record = new ListViewItem(tidname);
                //listView_tid2.Items.Add(record);
                count++;
            }

            listviewOpt3(tidRealName);
            return tidName;
        }

        private delegate void listOpt(List<string> a);
        private delegate void listOpt2(List<string> a);
        private delegate void listOpt3(List<string> a);

        private void listviewOpt2(List<string> tidRealName)
        {
            if (listView_Subject2.InvokeRequired)
            {
                listOpt2 opt = new listOpt2(listviewOpt2);
                listView_Subject2.Invoke(opt, tidRealName);
            }
            else
            {
                //设置Listview显示样式
                listView_tid.View = View.Tile;
                listView_tid.MultiSelect = false;

                
                //清空Listview
                listView_tid.Clear();
                foreach (string i in tidRealName)
                {
                    ListViewItem record = new ListViewItem(i);
                    listView_tid.Items.Add(record);
                }
                
            }
        }

        private void listviewOpt3(List<string> tidRealName)
        {
            if (listView_Subject3.InvokeRequired)
            {
                listOpt3 opt = new listOpt3(listviewOpt3);
                listView_Subject3.Invoke(opt, tidRealName);
            }
            else
            {
                //设置Listview显示样式
                listView_tid2.View = View.Tile;
                listView_tid2.MultiSelect = false;


                //清空Listview
                listView_tid2.Clear();
                foreach (string i in tidRealName)
                {
                    ListViewItem record = new ListViewItem(i);
                    listView_tid2.Items.Add(record);
                }

            }
        }

        private List<string> LoadSubjectName()
        {

            //清空List
            numsub.Clear();

            //BBSNetwork testlogin = new BBSNetwork("linheng", "linheng");
            List<string> fidName = new List<string>();
            int count = 0;
            foreach (int i in fidArray)
            {
                fidName.Add(testlogin.GetFidName(i.ToString()));

                numsub.Add(count, i);
                count++;
            }
            //foreach (string i in fidName)
            //{
            //    ListViewItem record = new ListViewItem(i);
            //    listView_Subject1.Items.Add(record);
            //}
            listviewOpt(fidName);
            return fidName;
        }

        private void listviewOpt(List<string> fidName)
        {
            if (listView_Subject1.InvokeRequired)
            {
                listOpt opt = new listOpt(listviewOpt);
                listView_Subject1.Invoke(opt, fidName);
            }
            else
            {
                //设置Listview显示样式
                listView_Subject1.View = View.Tile;
                listView_Subject1.MultiSelect = false;

                //清空Listview_realLOGIN
                listView_Subject1.Clear();
                foreach (string i in fidName)
                {

                    ListViewItem record = new ListViewItem(i);
                    listView_Subject1.Items.Add(record);
                }
                LoadSubjectName2();
                LoadSubjectName3();
            }
        }

      
       

        private void LoadContent()
        {
            listView_Content1.View = View.Details;
            listView_Content1.Columns.Add("标题", 80, HorizontalAlignment.Left);
            listView_Content1.Columns.Add("发帖内容", 140, HorizontalAlignment.Left);
            listView_Content1.MultiSelect = false;

            try
            {
                StreamReader sr = new StreamReader(subjectContent, System.Text.Encoding.Default);
                int count = 0;
                while (sr.Peek() != -1)
                {
                    string subject = sr.ReadLine();
                    string title = subject.Substring(0, subject.IndexOf(":::::"));
                    string content = subject.Substring(subject.IndexOf(":") + 5);
                    tico.Add(title, content);
                    numti.Add(count, title);
                    count++;
                }
                foreach (string key in tico.Keys)
                {
                    ListViewItem record = new ListViewItem(key);
                    record.SubItems.Add(key);
                    record.SubItems.Add(tico[key]);

                    listView_Content1.Items.Add(record);
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("配置文件未找到！");
            }

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //设置Listview显示样式
            listView_realLOGIN.View = View.Tile;
            //清空List
            loginlist.Clear();
            //清空Listview_realLOGIN
            listView_realLOGIN.Clear();

            //全选账户
            //foreach (string key in namepass.Keys)
            //{
            //    BBSNetwork newlogin = new BBSNetwork(key,namepass[key]);
            //    if (newlogin.success)
            //    {
            //        loginlist.Add(newlogin);
            //    }
            //}

            //登入选中的账户
            ListView.SelectedIndexCollection listSelected = listView_readCFG.SelectedIndices;
            List<int> indexs = new List<int>();
            for (int i = 0; i < listSelected.Count; i++)
                indexs.Add(listSelected[i]);
            foreach (int item in indexs)
            {
                BBSNetwork newlogin = new BBSNetwork(numname[item], namepass[numname[item]]);
                if (newlogin.success)
                {
                    loginlist.Add(newlogin);
                }
            }

            foreach (BBSNetwork item in loginlist)
            {
                ListViewItem record = new ListViewItem(item.BBSusername);
                listView_realLOGIN.Items.Add(record);
            }

        }

        private void button_GetSubject_Click(object sender, EventArgs e)
        {
            LoadSubjectName();
        }

        private void listView_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Subject1.SelectedItems.Count > 0)
                label1.Text = numsub[listView_Subject1.SelectedIndices[0]].ToString();

        }

        private void listView_Content1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Content1.SelectedItems.Count > 0)
            {
                label2.Text = numti[listView_Content1.SelectedIndices[0]];
                label3.Text = tico[numti[listView_Content1.SelectedIndices[0]]];

            }
        }

        private void button_SubjectSend_Click(object sender, EventArgs e)
        {
            string fidChoose = label1.Text;
            string subjectChoose = label2.Text, subjectMessage = label3.Text;

            for (int i = 0; i < int.Parse(textBox_SubjectCount.Text); i++)
            {
                foreach (BBSNetwork user in loginlist)
                {
                    user.PostSubject(fidChoose, subjectChoose, subjectMessage);
                }
            }
            MessageBox.Show("发帖成功！");
        }

        private void button_GetSubject2_Click(object sender, EventArgs e)
        {
            LoadSubjectName2();
        }

        private void LoadSubjectName2()
        {
            //设置Listview显示样式
            listView_Subject2.View = View.Tile;
            //清空Listview_realLOGIN
            listView_Subject2.Clear();

            //LoadSubjectName();

            foreach (ListViewItem item in listView_Subject1.Items)
                listView_Subject2.Items.Add((ListViewItem)item.Clone());
        }

        private delegate string[] AddHandler2(string fid);

        private void listView_Subject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Subject2.SelectedItems.Count > 0)
            {
                string fid = numsub[listView_Subject2.SelectedIndices[0]].ToString();
                label4.Text = fid;

                //异步调用
                AddHandler2 handler = new AddHandler2(Loadtid);
                //IAsyncResult result = handler.BeginInvoke(IASyncLoadSubject, handler);
                IAsyncResult result = handler.BeginInvoke(fid, null, null);
                
                //Loadtid(fid);
            }
        }

        

        private void listView_tid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_tid.SelectedItems.Count > 0)
            {
                label5.Text = numtid[listView_tid.SelectedIndices[0]];
            }
        }

        private void LoadTidContent()
        {
            listView_Content2.View = View.Details;
            listView_Content2.Columns.Add("发帖内容", 200, HorizontalAlignment.Left);
            listView_Content2.MultiSelect = false;

            try
            {
                StreamReader sr = new StreamReader(tidContent, System.Text.Encoding.Default);
                int count = 0;
                while (sr.Peek() != -1)
                {
                    string content = sr.ReadLine();

                    numcontent.Add(count, content);
                    count++;
                }

                foreach (int key in numcontent.Keys)
                {
                    ListViewItem record = new ListViewItem(numcontent[key]);
                    listView_Content2.Items.Add(record);
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("配置文件未找到！");
            }

        }

        private void listView_Content2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Content2.SelectedItems.Count > 0)
            {
                label6.Text = numcontent[listView_Content2.SelectedIndices[0]];


            }
        }

        private void button_TidSend_Click(object sender, EventArgs e)
        {
            string tidChoose = label5.Text;
            string contentChoose = label6.Text;

            for (int i = 0; i < int.Parse(textBox_TidCount.Text); i++)
            {
                foreach (BBSNetwork user in loginlist)
                {
                    user.PostMessage(tidChoose, contentChoose);
                }
            }
            MessageBox.Show("发帖成功！");
        }

        private delegate string[] AddHandler3(string fid);

        private void listView_Subject3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Subject3.SelectedItems.Count > 0)
            {
                string fid = numsub[listView_Subject3.SelectedIndices[0]].ToString();
                label7.Text = fid;

                //异步调用
                AddHandler3 handler = new AddHandler3(Loadtid2);
                //IAsyncResult result = handler.BeginInvoke(IASyncLoadSubject, handler);
                IAsyncResult result = handler.BeginInvoke(fid, null, null);

                //Loadtid2(fid);
            }
        }

        private void listView_tid2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_tid2.SelectedItems.Count > 0)
            {
                label8.Text = numtid[listView_tid2.SelectedIndices[0]];
            }
        }

        private void button_GetSubject3_Click(object sender, EventArgs e)
        {
            LoadSubjectName3();
        }

        private void LoadSubjectName3()
        {
            //设置Listview显示样式
            listView_Subject3.View = View.Tile;
            //清空Listview_realLOGIN
            listView_Subject3.Clear();

            //LoadSubjectName();

            foreach (ListViewItem item in listView_Subject1.Items)
                listView_Subject3.Items.Add((ListViewItem)item.Clone());
        }

        

        private void button_FindAndSend_Click(object sender, EventArgs e)
        {
            string tid = label8.Text;
            List<string> content = testlogin.GetContent(tid);
            int count = 0;
            foreach (string co in content)
            {
                if (co.IndexOf(textBox_key.Text) >= 0)
                {
                    count++;

                    foreach (BBSNetwork user in loginlist)
                    {
                        user.PostMessage(tid, textBox_forKeytoSend.Text);
                    }


                }
            }
            MessageBox.Show("已针对" + count + "处关键字发送帖子！");
        }

        private void button_Read1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(subjectContent, System.Text.Encoding.Default);

                while (sr.Peek() != -1)
                {
                    string user = sr.ReadLine();
                    textBox_Subject.Text += user + "\r\n";
                }

                sr.Close();
            }
            catch
            {
                MessageBox.Show("配置文件未找到！");
            }
        }

        private void button_Read2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(tidContent, System.Text.Encoding.Default);

                while (sr.Peek() != -1)
                {
                    string user = sr.ReadLine();
                    textBox_Tid.Text += user + "\r\n";
                }

                sr.Close();
            }
            catch
            {
                MessageBox.Show("配置文件未找到！");
            }


        }

        private void button_Write1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(subjectContent, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(textBox_Subject.Text);
            sw.Close();
            fs.Close();
            LoadContent();
        }

        private void button_Write2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(tidContent, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(textBox_Tid.Text);
            sw.Close();
            fs.Close();
            LoadTidContent();
        }




    }
}
