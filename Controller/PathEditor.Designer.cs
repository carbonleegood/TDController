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
            this.SuspendLayout();
            // 
            // btnDelPoint
            // 
            this.btnDelPoint.Location = new System.Drawing.Point(26, 184);
            this.btnDelPoint.Name = "btnDelPoint";
            this.btnDelPoint.Size = new System.Drawing.Size(75, 23);
            this.btnDelPoint.TabIndex = 9;
            this.btnDelPoint.Text = "删除点";
            this.btnDelPoint.UseVisualStyleBackColor = true;
            // 
            // btnLoadPath
            // 
            this.btnLoadPath.Location = new System.Drawing.Point(26, 106);
            this.btnLoadPath.Name = "btnLoadPath";
            this.btnLoadPath.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPath.TabIndex = 8;
            this.btnLoadPath.Text = "加载路径";
            this.btnLoadPath.UseVisualStyleBackColor = true;
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(26, 135);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSavePath.TabIndex = 7;
            this.btnSavePath.Text = "保存路径";
            this.btnSavePath.UseVisualStyleBackColor = true;
            // 
            // btnStopGenPath
            // 
            this.btnStopGenPath.Location = new System.Drawing.Point(26, 52);
            this.btnStopGenPath.Name = "btnStopGenPath";
            this.btnStopGenPath.Size = new System.Drawing.Size(75, 23);
            this.btnStopGenPath.TabIndex = 6;
            this.btnStopGenPath.Text = "停止采集";
            this.btnStopGenPath.UseVisualStyleBackColor = true;
            // 
            // btnStartGenPath
            // 
            this.btnStartGenPath.Location = new System.Drawing.Point(26, 23);
            this.btnStartGenPath.Name = "btnStartGenPath";
            this.btnStartGenPath.Size = new System.Drawing.Size(75, 23);
            this.btnStartGenPath.TabIndex = 5;
            this.btnStartGenPath.Text = "开始采集";
            this.btnStartGenPath.UseVisualStyleBackColor = true;
            // 
            // PathEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 314);
            this.Controls.Add(this.btnDelPoint);
            this.Controls.Add(this.btnLoadPath);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.btnStopGenPath);
            this.Controls.Add(this.btnStartGenPath);
            this.Name = "PathEditor";
            this.Text = "PathEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelPoint;
        private System.Windows.Forms.Button btnLoadPath;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Button btnStopGenPath;
        private System.Windows.Forms.Button btnStartGenPath;
    }
}