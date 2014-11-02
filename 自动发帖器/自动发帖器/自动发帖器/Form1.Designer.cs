namespace 自动发帖器
{
    partial class 自动发帖器
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_login = new System.Windows.Forms.TabPage();
            this.listView_realLOGIN = new System.Windows.Forms.ListView();
            this.button_login = new System.Windows.Forms.Button();
            this.listView_readCFG = new System.Windows.Forms.ListView();
            this.tabPage_PostSubject = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SubjectSend = new System.Windows.Forms.Button();
            this.textBox_SubjectCount = new System.Windows.Forms.TextBox();
            this.listView_Content1 = new System.Windows.Forms.ListView();
            this.listView_Subject1 = new System.Windows.Forms.ListView();
            this.tabPage_PostMessage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_TidSend = new System.Windows.Forms.Button();
            this.textBox_TidCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_Content2 = new System.Windows.Forms.ListView();
            this.listView_tid = new System.Windows.Forms.ListView();
            this.listView_Subject2 = new System.Windows.Forms.ListView();
            this.tabPage_Intelligence = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button_FindAndSend = new System.Windows.Forms.Button();
            this.textBox_forKeytoSend = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listView_tid2 = new System.Windows.Forms.ListView();
            this.listView_Subject3 = new System.Windows.Forms.ListView();
            this.tabPage_ContentManager = new System.Windows.Forms.TabPage();
            this.button_Write2 = new System.Windows.Forms.Button();
            this.textBox_Tid = new System.Windows.Forms.TextBox();
            this.textBox_Subject = new System.Windows.Forms.TextBox();
            this.button_Read2 = new System.Windows.Forms.Button();
            this.button_Read1 = new System.Windows.Forms.Button();
            this.button_Write1 = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.tabControl.SuspendLayout();
            this.tabPage_login.SuspendLayout();
            this.tabPage_PostSubject.SuspendLayout();
            this.tabPage_PostMessage.SuspendLayout();
            this.tabPage_Intelligence.SuspendLayout();
            this.tabPage_ContentManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_login);
            this.tabControl.Controls.Add(this.tabPage_PostSubject);
            this.tabControl.Controls.Add(this.tabPage_PostMessage);
            this.tabControl.Controls.Add(this.tabPage_Intelligence);
            this.tabControl.Controls.Add(this.tabPage_ContentManager);
            this.tabControl.Location = new System.Drawing.Point(56, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1136, 618);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_login
            // 
            this.tabPage_login.Controls.Add(this.listView_realLOGIN);
            this.tabPage_login.Controls.Add(this.button_login);
            this.tabPage_login.Controls.Add(this.listView_readCFG);
            this.tabPage_login.Location = new System.Drawing.Point(4, 34);
            this.tabPage_login.Name = "tabPage_login";
            this.tabPage_login.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_login.Size = new System.Drawing.Size(1128, 580);
            this.tabPage_login.TabIndex = 0;
            this.tabPage_login.Text = "账户登入";
            this.tabPage_login.UseVisualStyleBackColor = true;
            // 
            // listView_realLOGIN
            // 
            this.listView_realLOGIN.Location = new System.Drawing.Point(696, 74);
            this.listView_realLOGIN.Name = "listView_realLOGIN";
            this.listView_realLOGIN.Scrollable = false;
            this.listView_realLOGIN.Size = new System.Drawing.Size(216, 439);
            this.listView_realLOGIN.TabIndex = 2;
            this.listView_realLOGIN.UseCompatibleStateImageBehavior = false;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(522, 272);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(99, 57);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "登入";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // listView_readCFG
            // 
            this.listView_readCFG.Location = new System.Drawing.Point(236, 74);
            this.listView_readCFG.Name = "listView_readCFG";
            this.listView_readCFG.Scrollable = false;
            this.listView_readCFG.Size = new System.Drawing.Size(219, 439);
            this.listView_readCFG.TabIndex = 0;
            this.listView_readCFG.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage_PostSubject
            // 
            this.tabPage_PostSubject.Controls.Add(this.label11);
            this.tabPage_PostSubject.Controls.Add(this.label10);
            this.tabPage_PostSubject.Controls.Add(this.label9);
            this.tabPage_PostSubject.Controls.Add(this.label3);
            this.tabPage_PostSubject.Controls.Add(this.label2);
            this.tabPage_PostSubject.Controls.Add(this.label1);
            this.tabPage_PostSubject.Controls.Add(this.button_SubjectSend);
            this.tabPage_PostSubject.Controls.Add(this.textBox_SubjectCount);
            this.tabPage_PostSubject.Controls.Add(this.listView_Content1);
            this.tabPage_PostSubject.Controls.Add(this.listView_Subject1);
            this.tabPage_PostSubject.Location = new System.Drawing.Point(4, 34);
            this.tabPage_PostSubject.Name = "tabPage_PostSubject";
            this.tabPage_PostSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PostSubject.Size = new System.Drawing.Size(1128, 580);
            this.tabPage_PostSubject.TabIndex = 1;
            this.tabPage_PostSubject.Text = "板块发帖";
            this.tabPage_PostSubject.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(619, 522);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 24);
            this.label11.TabIndex = 10;
            this.label11.Text = "发送次数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "发帖标题和内容：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "FID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "未选择";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "未选择";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "未选择";
            // 
            // button_SubjectSend
            // 
            this.button_SubjectSend.Location = new System.Drawing.Point(894, 514);
            this.button_SubjectSend.Name = "button_SubjectSend";
            this.button_SubjectSend.Size = new System.Drawing.Size(99, 43);
            this.button_SubjectSend.TabIndex = 4;
            this.button_SubjectSend.Text = "发送";
            this.button_SubjectSend.UseVisualStyleBackColor = true;
            this.button_SubjectSend.Click += new System.EventHandler(this.button_SubjectSend_Click);
            // 
            // textBox_SubjectCount
            // 
            this.textBox_SubjectCount.Location = new System.Drawing.Point(755, 517);
            this.textBox_SubjectCount.Name = "textBox_SubjectCount";
            this.textBox_SubjectCount.Size = new System.Drawing.Size(100, 35);
            this.textBox_SubjectCount.TabIndex = 3;
            // 
            // listView_Content1
            // 
            this.listView_Content1.Location = new System.Drawing.Point(423, 62);
            this.listView_Content1.Name = "listView_Content1";
            this.listView_Content1.Size = new System.Drawing.Size(570, 337);
            this.listView_Content1.TabIndex = 2;
            this.listView_Content1.UseCompatibleStateImageBehavior = false;
            this.listView_Content1.SelectedIndexChanged += new System.EventHandler(this.listView_Content1_SelectedIndexChanged);
            // 
            // listView_Subject1
            // 
            this.listView_Subject1.Location = new System.Drawing.Point(140, 62);
            this.listView_Subject1.Name = "listView_Subject1";
            this.listView_Subject1.Scrollable = false;
            this.listView_Subject1.Size = new System.Drawing.Size(179, 337);
            this.listView_Subject1.TabIndex = 0;
            this.listView_Subject1.UseCompatibleStateImageBehavior = false;
            this.listView_Subject1.SelectedIndexChanged += new System.EventHandler(this.listView_Subject_SelectedIndexChanged);
            // 
            // tabPage_PostMessage
            // 
            this.tabPage_PostMessage.Controls.Add(this.label15);
            this.tabPage_PostMessage.Controls.Add(this.label14);
            this.tabPage_PostMessage.Controls.Add(this.label13);
            this.tabPage_PostMessage.Controls.Add(this.label12);
            this.tabPage_PostMessage.Controls.Add(this.button_TidSend);
            this.tabPage_PostMessage.Controls.Add(this.textBox_TidCount);
            this.tabPage_PostMessage.Controls.Add(this.label6);
            this.tabPage_PostMessage.Controls.Add(this.label5);
            this.tabPage_PostMessage.Controls.Add(this.label4);
            this.tabPage_PostMessage.Controls.Add(this.listView_Content2);
            this.tabPage_PostMessage.Controls.Add(this.listView_tid);
            this.tabPage_PostMessage.Controls.Add(this.listView_Subject2);
            this.tabPage_PostMessage.Location = new System.Drawing.Point(4, 34);
            this.tabPage_PostMessage.Name = "tabPage_PostMessage";
            this.tabPage_PostMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PostMessage.Size = new System.Drawing.Size(1128, 580);
            this.tabPage_PostMessage.TabIndex = 2;
            this.tabPage_PostMessage.Text = "自动顶贴";
            this.tabPage_PostMessage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(515, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 24);
            this.label15.TabIndex = 14;
            this.label15.Text = "顶贴内容：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 450);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 24);
            this.label14.TabIndex = 13;
            this.label14.Text = "TID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 24);
            this.label13.TabIndex = 12;
            this.label13.Text = "FID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(676, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "发送次数：";
            // 
            // button_TidSend
            // 
            this.button_TidSend.Location = new System.Drawing.Point(961, 497);
            this.button_TidSend.Name = "button_TidSend";
            this.button_TidSend.Size = new System.Drawing.Size(99, 43);
            this.button_TidSend.TabIndex = 10;
            this.button_TidSend.Text = "发送";
            this.button_TidSend.UseVisualStyleBackColor = true;
            this.button_TidSend.Click += new System.EventHandler(this.button_TidSend_Click);
            // 
            // textBox_TidCount
            // 
            this.textBox_TidCount.Location = new System.Drawing.Point(812, 505);
            this.textBox_TidCount.Name = "textBox_TidCount";
            this.textBox_TidCount.Size = new System.Drawing.Size(100, 35);
            this.textBox_TidCount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "未选择";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "未选择";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "未选择";
            // 
            // listView_Content2
            // 
            this.listView_Content2.Location = new System.Drawing.Point(672, 104);
            this.listView_Content2.Name = "listView_Content2";
            this.listView_Content2.Size = new System.Drawing.Size(388, 293);
            this.listView_Content2.TabIndex = 3;
            this.listView_Content2.UseCompatibleStateImageBehavior = false;
            this.listView_Content2.SelectedIndexChanged += new System.EventHandler(this.listView_Content2_SelectedIndexChanged);
            // 
            // listView_tid
            // 
            this.listView_tid.Location = new System.Drawing.Point(265, 104);
            this.listView_tid.Name = "listView_tid";
            this.listView_tid.Size = new System.Drawing.Size(380, 293);
            this.listView_tid.TabIndex = 1;
            this.listView_tid.UseCompatibleStateImageBehavior = false;
            this.listView_tid.SelectedIndexChanged += new System.EventHandler(this.listView_tid_SelectedIndexChanged);
            // 
            // listView_Subject2
            // 
            this.listView_Subject2.Location = new System.Drawing.Point(66, 104);
            this.listView_Subject2.Name = "listView_Subject2";
            this.listView_Subject2.Scrollable = false;
            this.listView_Subject2.Size = new System.Drawing.Size(175, 293);
            this.listView_Subject2.TabIndex = 0;
            this.listView_Subject2.UseCompatibleStateImageBehavior = false;
            this.listView_Subject2.SelectedIndexChanged += new System.EventHandler(this.listView_Subject2_SelectedIndexChanged);
            // 
            // tabPage_Intelligence
            // 
            this.tabPage_Intelligence.Controls.Add(this.label19);
            this.tabPage_Intelligence.Controls.Add(this.label18);
            this.tabPage_Intelligence.Controls.Add(this.label17);
            this.tabPage_Intelligence.Controls.Add(this.label16);
            this.tabPage_Intelligence.Controls.Add(this.button_FindAndSend);
            this.tabPage_Intelligence.Controls.Add(this.textBox_forKeytoSend);
            this.tabPage_Intelligence.Controls.Add(this.textBox_key);
            this.tabPage_Intelligence.Controls.Add(this.label8);
            this.tabPage_Intelligence.Controls.Add(this.label7);
            this.tabPage_Intelligence.Controls.Add(this.listView_tid2);
            this.tabPage_Intelligence.Controls.Add(this.listView_Subject3);
            this.tabPage_Intelligence.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Intelligence.Name = "tabPage_Intelligence";
            this.tabPage_Intelligence.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Intelligence.Size = new System.Drawing.Size(1128, 580);
            this.tabPage_Intelligence.TabIndex = 3;
            this.tabPage_Intelligence.Text = "智能顶贴";
            this.tabPage_Intelligence.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(696, 272);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 24);
            this.label19.TabIndex = 17;
            this.label19.Text = "回帖内容:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(696, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 24);
            this.label18.TabIndex = 16;
            this.label18.Text = "搜索的关键字:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(265, 438);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 24);
            this.label17.TabIndex = 15;
            this.label17.Text = "TID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 438);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 24);
            this.label16.TabIndex = 14;
            this.label16.Text = "FID:";
            // 
            // button_FindAndSend
            // 
            this.button_FindAndSend.Location = new System.Drawing.Point(880, 358);
            this.button_FindAndSend.Name = "button_FindAndSend";
            this.button_FindAndSend.Size = new System.Drawing.Size(204, 49);
            this.button_FindAndSend.TabIndex = 13;
            this.button_FindAndSend.Text = "智能顶贴";
            this.button_FindAndSend.UseVisualStyleBackColor = true;
            this.button_FindAndSend.Click += new System.EventHandler(this.button_FindAndSend_Click);
            // 
            // textBox_forKeytoSend
            // 
            this.textBox_forKeytoSend.Location = new System.Drawing.Point(880, 269);
            this.textBox_forKeytoSend.Name = "textBox_forKeytoSend";
            this.textBox_forKeytoSend.Size = new System.Drawing.Size(204, 35);
            this.textBox_forKeytoSend.TabIndex = 12;
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(880, 182);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(204, 35);
            this.textBox_key.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "未选择";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "未选择";
            // 
            // listView_tid2
            // 
            this.listView_tid2.Location = new System.Drawing.Point(269, 100);
            this.listView_tid2.Name = "listView_tid2";
            this.listView_tid2.Size = new System.Drawing.Size(389, 293);
            this.listView_tid2.TabIndex = 3;
            this.listView_tid2.UseCompatibleStateImageBehavior = false;
            this.listView_tid2.SelectedIndexChanged += new System.EventHandler(this.listView_tid2_SelectedIndexChanged);
            // 
            // listView_Subject3
            // 
            this.listView_Subject3.Location = new System.Drawing.Point(66, 100);
            this.listView_Subject3.Name = "listView_Subject3";
            this.listView_Subject3.Scrollable = false;
            this.listView_Subject3.Size = new System.Drawing.Size(175, 293);
            this.listView_Subject3.TabIndex = 2;
            this.listView_Subject3.UseCompatibleStateImageBehavior = false;
            this.listView_Subject3.SelectedIndexChanged += new System.EventHandler(this.listView_Subject3_SelectedIndexChanged);
            // 
            // tabPage_ContentManager
            // 
            this.tabPage_ContentManager.Controls.Add(this.button_Write2);
            this.tabPage_ContentManager.Controls.Add(this.textBox_Tid);
            this.tabPage_ContentManager.Controls.Add(this.textBox_Subject);
            this.tabPage_ContentManager.Controls.Add(this.button_Read2);
            this.tabPage_ContentManager.Controls.Add(this.button_Read1);
            this.tabPage_ContentManager.Controls.Add(this.button_Write1);
            this.tabPage_ContentManager.Location = new System.Drawing.Point(4, 34);
            this.tabPage_ContentManager.Name = "tabPage_ContentManager";
            this.tabPage_ContentManager.Size = new System.Drawing.Size(1128, 580);
            this.tabPage_ContentManager.TabIndex = 4;
            this.tabPage_ContentManager.Text = "发帖内容管理";
            this.tabPage_ContentManager.UseVisualStyleBackColor = true;
            // 
            // button_Write2
            // 
            this.button_Write2.Location = new System.Drawing.Point(865, 495);
            this.button_Write2.Name = "button_Write2";
            this.button_Write2.Size = new System.Drawing.Size(124, 67);
            this.button_Write2.TabIndex = 5;
            this.button_Write2.Text = "保存";
            this.button_Write2.UseVisualStyleBackColor = true;
            this.button_Write2.Click += new System.EventHandler(this.button_Write2_Click);
            // 
            // textBox_Tid
            // 
            this.textBox_Tid.Location = new System.Drawing.Point(576, 44);
            this.textBox_Tid.Multiline = true;
            this.textBox_Tid.Name = "textBox_Tid";
            this.textBox_Tid.Size = new System.Drawing.Size(474, 423);
            this.textBox_Tid.TabIndex = 3;
            // 
            // textBox_Subject
            // 
            this.textBox_Subject.Location = new System.Drawing.Point(74, 44);
            this.textBox_Subject.Multiline = true;
            this.textBox_Subject.Name = "textBox_Subject";
            this.textBox_Subject.Size = new System.Drawing.Size(456, 423);
            this.textBox_Subject.TabIndex = 2;
            // 
            // button_Read2
            // 
            this.button_Read2.Location = new System.Drawing.Point(647, 495);
            this.button_Read2.Name = "button_Read2";
            this.button_Read2.Size = new System.Drawing.Size(124, 67);
            this.button_Read2.TabIndex = 4;
            this.button_Read2.Text = "读取";
            this.button_Read2.UseVisualStyleBackColor = true;
            this.button_Read2.Click += new System.EventHandler(this.button_Read2_Click);
            // 
            // button_Read1
            // 
            this.button_Read1.Location = new System.Drawing.Point(127, 495);
            this.button_Read1.Name = "button_Read1";
            this.button_Read1.Size = new System.Drawing.Size(124, 67);
            this.button_Read1.TabIndex = 0;
            this.button_Read1.Text = "读取";
            this.button_Read1.UseVisualStyleBackColor = true;
            this.button_Read1.Click += new System.EventHandler(this.button_Read1_Click);
            // 
            // button_Write1
            // 
            this.button_Write1.Location = new System.Drawing.Point(345, 495);
            this.button_Write1.Name = "button_Write1";
            this.button_Write1.Size = new System.Drawing.Size(124, 67);
            this.button_Write1.TabIndex = 1;
            this.button_Write1.Text = "保存";
            this.button_Write1.UseVisualStyleBackColor = true;
            this.button_Write1.Click += new System.EventHandler(this.button_Write1_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // 自动发帖器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 702);
            this.Controls.Add(this.tabControl);
            this.Name = "自动发帖器";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动发帖器";
            this.tabControl.ResumeLayout(false);
            this.tabPage_login.ResumeLayout(false);
            this.tabPage_PostSubject.ResumeLayout(false);
            this.tabPage_PostSubject.PerformLayout();
            this.tabPage_PostMessage.ResumeLayout(false);
            this.tabPage_PostMessage.PerformLayout();
            this.tabPage_Intelligence.ResumeLayout(false);
            this.tabPage_Intelligence.PerformLayout();
            this.tabPage_ContentManager.ResumeLayout(false);
            this.tabPage_ContentManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_login;
        private System.Windows.Forms.TabPage tabPage_PostSubject;
        private System.Windows.Forms.TabPage tabPage_PostMessage;
        private System.Windows.Forms.TabPage tabPage_Intelligence;
        private System.Windows.Forms.ListView listView_readCFG;
        private System.Windows.Forms.ListView listView_realLOGIN;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.ListView listView_Subject1;
        private System.Windows.Forms.ListView listView_Content1;
        private System.Windows.Forms.Button button_SubjectSend;
        private System.Windows.Forms.TextBox textBox_SubjectCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Content2;
        private System.Windows.Forms.ListView listView_tid;
        private System.Windows.Forms.ListView listView_Subject2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_TidSend;
        private System.Windows.Forms.TextBox textBox_TidCount;
        private System.Windows.Forms.ListView listView_tid2;
        private System.Windows.Forms.ListView listView_Subject3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_FindAndSend;
        private System.Windows.Forms.TextBox textBox_forKeytoSend;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.TabPage tabPage_ContentManager;
        private System.Windows.Forms.TextBox textBox_Tid;
        private System.Windows.Forms.TextBox textBox_Subject;
        private System.Windows.Forms.Button button_Write1;
        private System.Windows.Forms.Button button_Read1;
        private System.Windows.Forms.Button button_Write2;
        private System.Windows.Forms.Button button_Read2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

