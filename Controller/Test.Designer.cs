namespace Controller
{
    partial class Test
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
            this.lsResult = new System.Windows.Forms.ListView();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetSkillList = new System.Windows.Forms.Button();
            this.btnGetPlayerInfo = new System.Windows.Forms.Button();
            this.btnMonsterList = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChangeAngleToTarget = new System.Windows.Forms.Button();
            this.btnAutoMove = new System.Windows.Forms.Button();
            this.btnChangeAngle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEnterGame = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClickKey = new System.Windows.Forms.Button();
            this.btnPressKey = new System.Windows.Forms.Button();
            this.btnRCSlot = new System.Windows.Forms.Button();
            this.btnLCSlot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnloadDll = new System.Windows.Forms.Button();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.btnStopWork = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsResult
            // 
            this.lsResult.Location = new System.Drawing.Point(12, 133);
            this.lsResult.Name = "lsResult";
            this.lsResult.Size = new System.Drawing.Size(439, 216);
            this.lsResult.TabIndex = 0;
            this.lsResult.UseCompatibleStateImageBehavior = false;
            this.lsResult.View = System.Windows.Forms.View.Details;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(53, 12);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(125, 21);
            this.tb1.TabIndex = 1;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(53, 43);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(125, 21);
            this.tb2.TabIndex = 2;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(53, 74);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(125, 21);
            this.tb3.TabIndex = 3;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(53, 105);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(125, 21);
            this.tb4.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(472, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 337);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGetSkillList);
            this.tabPage1.Controls.Add(this.btnGetPlayerInfo);
            this.tabPage1.Controls.Add(this.btnMonsterList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "获取信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGetSkillList
            // 
            this.btnGetSkillList.Location = new System.Drawing.Point(17, 74);
            this.btnGetSkillList.Name = "btnGetSkillList";
            this.btnGetSkillList.Size = new System.Drawing.Size(75, 23);
            this.btnGetSkillList.TabIndex = 3;
            this.btnGetSkillList.Text = "技能列表";
            this.btnGetSkillList.UseVisualStyleBackColor = true;
            this.btnGetSkillList.Click += new System.EventHandler(this.btnGetSkillList_Click);
            // 
            // btnGetPlayerInfo
            // 
            this.btnGetPlayerInfo.Location = new System.Drawing.Point(17, 12);
            this.btnGetPlayerInfo.Name = "btnGetPlayerInfo";
            this.btnGetPlayerInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetPlayerInfo.TabIndex = 2;
            this.btnGetPlayerInfo.Text = "角色信息";
            this.btnGetPlayerInfo.UseVisualStyleBackColor = true;
            this.btnGetPlayerInfo.Click += new System.EventHandler(this.btnGetPlayerInfo_Click);
            // 
            // btnMonsterList
            // 
            this.btnMonsterList.Location = new System.Drawing.Point(17, 43);
            this.btnMonsterList.Name = "btnMonsterList";
            this.btnMonsterList.Size = new System.Drawing.Size(75, 24);
            this.btnMonsterList.TabIndex = 1;
            this.btnMonsterList.Text = "怪物列表";
            this.btnMonsterList.UseVisualStyleBackColor = true;
            this.btnMonsterList.Click += new System.EventHandler(this.btnMonsterList_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChangeAngleToTarget);
            this.tabPage2.Controls.Add(this.btnAutoMove);
            this.tabPage2.Controls.Add(this.btnChangeAngle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "控制";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChangeAngleToTarget
            // 
            this.btnChangeAngleToTarget.Location = new System.Drawing.Point(116, 22);
            this.btnChangeAngleToTarget.Name = "btnChangeAngleToTarget";
            this.btnChangeAngleToTarget.Size = new System.Drawing.Size(75, 23);
            this.btnChangeAngleToTarget.TabIndex = 3;
            this.btnChangeAngleToTarget.Text = "目标转向";
            this.btnChangeAngleToTarget.UseVisualStyleBackColor = true;
            this.btnChangeAngleToTarget.Click += new System.EventHandler(this.btnChangeAngleToTarget_Click);
            // 
            // btnAutoMove
            // 
            this.btnAutoMove.Location = new System.Drawing.Point(19, 52);
            this.btnAutoMove.Name = "btnAutoMove";
            this.btnAutoMove.Size = new System.Drawing.Size(75, 23);
            this.btnAutoMove.TabIndex = 2;
            this.btnAutoMove.Text = "自动寻路";
            this.btnAutoMove.UseVisualStyleBackColor = true;
            this.btnAutoMove.Click += new System.EventHandler(this.btnAutoMove_Click);
            // 
            // btnChangeAngle
            // 
            this.btnChangeAngle.Location = new System.Drawing.Point(19, 22);
            this.btnChangeAngle.Name = "btnChangeAngle";
            this.btnChangeAngle.Size = new System.Drawing.Size(75, 23);
            this.btnChangeAngle.TabIndex = 1;
            this.btnChangeAngle.Text = "人物转向";
            this.btnChangeAngle.UseVisualStyleBackColor = true;
            this.btnChangeAngle.Click += new System.EventHandler(this.btnChangeAngle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEnterGame);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(321, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "登录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEnterGame
            // 
            this.btnEnterGame.Location = new System.Drawing.Point(15, 22);
            this.btnEnterGame.Name = "btnEnterGame";
            this.btnEnterGame.Size = new System.Drawing.Size(75, 23);
            this.btnEnterGame.TabIndex = 2;
            this.btnEnterGame.Text = "进入游戏";
            this.btnEnterGame.UseVisualStyleBackColor = true;
            this.btnEnterGame.Click += new System.EventHandler(this.btnEnterGame_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClickKey);
            this.tabPage4.Controls.Add(this.btnPressKey);
            this.tabPage4.Controls.Add(this.btnRCSlot);
            this.tabPage4.Controls.Add(this.btnLCSlot);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(321, 311);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "操作";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnClickKey
            // 
            this.btnClickKey.Location = new System.Drawing.Point(100, 43);
            this.btnClickKey.Name = "btnClickKey";
            this.btnClickKey.Size = new System.Drawing.Size(75, 23);
            this.btnClickKey.TabIndex = 3;
            this.btnClickKey.Text = "点键";
            this.btnClickKey.UseVisualStyleBackColor = true;
            this.btnClickKey.Click += new System.EventHandler(this.btnClickKey_Click);
            // 
            // btnPressKey
            // 
            this.btnPressKey.Location = new System.Drawing.Point(100, 14);
            this.btnPressKey.Name = "btnPressKey";
            this.btnPressKey.Size = new System.Drawing.Size(75, 23);
            this.btnPressKey.TabIndex = 2;
            this.btnPressKey.Text = "压键";
            this.btnPressKey.UseVisualStyleBackColor = true;
            this.btnPressKey.Click += new System.EventHandler(this.btnPressKey_Click);
            // 
            // btnRCSlot
            // 
            this.btnRCSlot.Location = new System.Drawing.Point(19, 43);
            this.btnRCSlot.Name = "btnRCSlot";
            this.btnRCSlot.Size = new System.Drawing.Size(75, 23);
            this.btnRCSlot.TabIndex = 1;
            this.btnRCSlot.Text = "右键点槽";
            this.btnRCSlot.UseVisualStyleBackColor = true;
            this.btnRCSlot.Click += new System.EventHandler(this.btnRCSlot_Click);
            // 
            // btnLCSlot
            // 
            this.btnLCSlot.Location = new System.Drawing.Point(19, 12);
            this.btnLCSlot.Name = "btnLCSlot";
            this.btnLCSlot.Size = new System.Drawing.Size(75, 23);
            this.btnLCSlot.TabIndex = 0;
            this.btnLCSlot.Text = "左键点槽";
            this.btnLCSlot.UseVisualStyleBackColor = true;
            this.btnLCSlot.Click += new System.EventHandler(this.btnLCSlot_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "参数1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "参数2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "参数3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "参数4";
            // 
            // btnUnloadDll
            // 
            this.btnUnloadDll.Location = new System.Drawing.Point(376, 45);
            this.btnUnloadDll.Name = "btnUnloadDll";
            this.btnUnloadDll.Size = new System.Drawing.Size(75, 23);
            this.btnUnloadDll.TabIndex = 10;
            this.btnUnloadDll.Text = "卸载DLL";
            this.btnUnloadDll.UseVisualStyleBackColor = true;
            // 
            // btnStartWork
            // 
            this.btnStartWork.Location = new System.Drawing.Point(376, 75);
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.Size = new System.Drawing.Size(75, 23);
            this.btnStartWork.TabIndex = 11;
            this.btnStartWork.Text = "启动工作线程";
            this.btnStartWork.UseVisualStyleBackColor = true;
            this.btnStartWork.Click += new System.EventHandler(this.btnStartWork_Click);
            // 
            // btnStopWork
            // 
            this.btnStopWork.Location = new System.Drawing.Point(376, 102);
            this.btnStopWork.Name = "btnStopWork";
            this.btnStopWork.Size = new System.Drawing.Size(75, 23);
            this.btnStopWork.TabIndex = 12;
            this.btnStopWork.Text = "停止工作线程";
            this.btnStopWork.UseVisualStyleBackColor = true;
            this.btnStopWork.Click += new System.EventHandler(this.btnStopWork_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 362);
            this.Controls.Add(this.btnStopWork);
            this.Controls.Add(this.btnStartWork);
            this.Controls.Add(this.btnUnloadDll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lsResult);
            this.Name = "Test";
            this.Text = "测试窗口";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsResult;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMonsterList;
        private System.Windows.Forms.Button btnChangeAngle;
        private System.Windows.Forms.Button btnGetPlayerInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEnterGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAutoMove;
        private System.Windows.Forms.Button btnChangeAngleToTarget;
        private System.Windows.Forms.Button btnGetSkillList;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRCSlot;
        private System.Windows.Forms.Button btnLCSlot;
        private System.Windows.Forms.Button btnClickKey;
        private System.Windows.Forms.Button btnPressKey;
        private System.Windows.Forms.Button btnUnloadDll;
        private System.Windows.Forms.Button btnStartWork;
        private System.Windows.Forms.Button btnStopWork;
    }
}

