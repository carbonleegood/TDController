namespace Controller
{
    partial class PathEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelPoint = new System.Windows.Forms.Button();
            this.btnLoadPath = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.btnStopGenPath = new System.Windows.Forms.Button();
            this.btnStartGenPath = new System.Windows.Forms.Button();
            this.btnReversePath = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnStopMove = new System.Windows.Forms.Button();
            this.dgbPath = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearPath = new System.Windows.Forms.Button();
            this.tbPathName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPath)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelPoint
            // 
            this.btnDelPoint.Location = new System.Drawing.Point(26, 237);
            this.btnDelPoint.Name = "btnDelPoint";
            this.btnDelPoint.Size = new System.Drawing.Size(75, 23);
            this.btnDelPoint.TabIndex = 9;
            this.btnDelPoint.Text = "删除点";
            this.btnDelPoint.UseVisualStyleBackColor = true;
            this.btnDelPoint.Click += new System.EventHandler(this.btnDelPoint_Click);
            // 
            // btnLoadPath
            // 
            this.btnLoadPath.Location = new System.Drawing.Point(26, 124);
            this.btnLoadPath.Name = "btnLoadPath";
            this.btnLoadPath.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPath.TabIndex = 8;
            this.btnLoadPath.Text = "加载路径";
            this.btnLoadPath.UseVisualStyleBackColor = true;
            this.btnLoadPath.Click += new System.EventHandler(this.btnLoadPath_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(26, 153);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSavePath.TabIndex = 7;
            this.btnSavePath.Text = "保存路径";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // btnStopGenPath
            // 
            this.btnStopGenPath.Location = new System.Drawing.Point(26, 52);
            this.btnStopGenPath.Name = "btnStopGenPath";
            this.btnStopGenPath.Size = new System.Drawing.Size(75, 23);
            this.btnStopGenPath.TabIndex = 6;
            this.btnStopGenPath.Text = "停止采集";
            this.btnStopGenPath.UseVisualStyleBackColor = true;
            this.btnStopGenPath.Click += new System.EventHandler(this.btnStopGenPath_Click);
            // 
            // btnStartGenPath
            // 
            this.btnStartGenPath.Location = new System.Drawing.Point(26, 23);
            this.btnStartGenPath.Name = "btnStartGenPath";
            this.btnStartGenPath.Size = new System.Drawing.Size(75, 23);
            this.btnStartGenPath.TabIndex = 5;
            this.btnStartGenPath.Text = "开始采集";
            this.btnStartGenPath.UseVisualStyleBackColor = true;
            this.btnStartGenPath.Click += new System.EventHandler(this.btnStartGenPath_Click);
            // 
            // btnReversePath
            // 
            this.btnReversePath.Location = new System.Drawing.Point(26, 266);
            this.btnReversePath.Name = "btnReversePath";
            this.btnReversePath.Size = new System.Drawing.Size(75, 23);
            this.btnReversePath.TabIndex = 10;
            this.btnReversePath.Text = "反转路径";
            this.btnReversePath.UseVisualStyleBackColor = true;
            this.btnReversePath.Click += new System.EventHandler(this.btnReversePath_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(26, 311);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 11;
            this.btnMove.Text = "走路径";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnStopMove
            // 
            this.btnStopMove.Location = new System.Drawing.Point(26, 340);
            this.btnStopMove.Name = "btnStopMove";
            this.btnStopMove.Size = new System.Drawing.Size(75, 23);
            this.btnStopMove.TabIndex = 12;
            this.btnStopMove.Text = "停止走路径";
            this.btnStopMove.UseVisualStyleBackColor = true;
            this.btnStopMove.Click += new System.EventHandler(this.btnStopMove_Click);
            // 
            // dgbPath
            // 
            this.dgbPath.AllowUserToAddRows = false;
            this.dgbPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dgbPath.Location = new System.Drawing.Point(144, 23);
            this.dgbPath.Name = "dgbPath";
            this.dgbPath.RowTemplate.Height = 23;
            this.dgbPath.Size = new System.Drawing.Size(444, 343);
            this.dgbPath.TabIndex = 13;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.Width = 200;
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.Name = "y";
            this.y.Width = 200;
            // 
            // btnClearPath
            // 
            this.btnClearPath.Location = new System.Drawing.Point(26, 208);
            this.btnClearPath.Name = "btnClearPath";
            this.btnClearPath.Size = new System.Drawing.Size(75, 23);
            this.btnClearPath.TabIndex = 14;
            this.btnClearPath.Text = "清空路径";
            this.btnClearPath.UseVisualStyleBackColor = true;
            this.btnClearPath.Click += new System.EventHandler(this.btnClearPath_Click);
            // 
            // tbPathName
            // 
            this.tbPathName.Location = new System.Drawing.Point(26, 97);
            this.tbPathName.Name = "tbPathName";
            this.tbPathName.Size = new System.Drawing.Size(75, 21);
            this.tbPathName.TabIndex = 15;
            // 
            // PathEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 396);
            this.Controls.Add(this.tbPathName);
            this.Controls.Add(this.btnClearPath);
            this.Controls.Add(this.dgbPath);
            this.Controls.Add(this.btnStopMove);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnReversePath);
            this.Controls.Add(this.btnDelPoint);
            this.Controls.Add(this.btnLoadPath);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.btnStopGenPath);
            this.Controls.Add(this.btnStartGenPath);
            this.Name = "PathEditor";
            this.Text = "PathEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dgbPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelPoint;
        private System.Windows.Forms.Button btnLoadPath;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Button btnStopGenPath;
        private System.Windows.Forms.Button btnStartGenPath;
        private System.Windows.Forms.Button btnReversePath;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnStopMove;
        private System.Windows.Forms.DataGridView dgbPath;
        private System.Windows.Forms.Button btnClearPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.TextBox tbPathName;
    }
}