namespace NetDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentVersion = new System.Windows.Forms.Label();
            this.currentBuild = new System.Windows.Forms.Label();
            this.btn_DownloadUdate = new System.Windows.Forms.Button();
            this.prog_DownloadUpdate = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "检查更新(&C)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 200);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(392, 151);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "更新说明：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前版本：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Build：";
            // 
            // currentVersion
            // 
            this.currentVersion.AutoSize = true;
            this.currentVersion.Location = new System.Drawing.Point(99, 20);
            this.currentVersion.Name = "currentVersion";
            this.currentVersion.Size = new System.Drawing.Size(0, 17);
            this.currentVersion.TabIndex = 4;
            // 
            // currentBuild
            // 
            this.currentBuild.AutoSize = true;
            this.currentBuild.Location = new System.Drawing.Point(99, 46);
            this.currentBuild.Name = "currentBuild";
            this.currentBuild.Size = new System.Drawing.Size(0, 17);
            this.currentBuild.TabIndex = 4;
            // 
            // btn_DownloadUdate
            // 
            this.btn_DownloadUdate.Location = new System.Drawing.Point(293, 75);
            this.btn_DownloadUdate.Name = "btn_DownloadUdate";
            this.btn_DownloadUdate.Size = new System.Drawing.Size(123, 34);
            this.btn_DownloadUdate.TabIndex = 5;
            this.btn_DownloadUdate.Text = "下载更新(&D)";
            this.btn_DownloadUdate.UseVisualStyleBackColor = true;
            this.btn_DownloadUdate.Click += new System.EventHandler(this.btn_DownloadUdate_Click);
            // 
            // prog_DownloadUpdate
            // 
            this.prog_DownloadUpdate.Location = new System.Drawing.Point(25, 128);
            this.prog_DownloadUpdate.Name = "prog_DownloadUpdate";
            this.prog_DownloadUpdate.Size = new System.Drawing.Size(392, 23);
            this.prog_DownloadUpdate.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 376);
            this.Controls.Add(this.prog_DownloadUpdate);
            this.Controls.Add(this.btn_DownloadUdate);
            this.Controls.Add(this.currentBuild);
            this.Controls.Add(this.currentVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大石锅子更新程序";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label currentVersion;
        private Label currentBuild;
        private Button btn_DownloadUdate;
        private ProgressBar prog_DownloadUpdate;
    }
}