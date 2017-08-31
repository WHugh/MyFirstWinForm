namespace StuScoreManagement.Forms
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SignOutBt = new System.Windows.Forms.ToolStripButton();
            this.ScoreBt = new System.Windows.Forms.Button();
            this.StuBt = new System.Windows.Forms.Button();
            this.CourseBt = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignOutBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SignOutBt
            // 
            this.SignOutBt.Image = ((System.Drawing.Image)(resources.GetObject("SignOutBt.Image")));
            this.SignOutBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SignOutBt.Name = "SignOutBt";
            this.SignOutBt.Size = new System.Drawing.Size(76, 22);
            this.SignOutBt.Text = "退出登录";
            this.SignOutBt.Click += new System.EventHandler(this.SignOutBt_Click);
            // 
            // ScoreBt
            // 
            this.ScoreBt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScoreBt.Location = new System.Drawing.Point(71, 69);
            this.ScoreBt.Name = "ScoreBt";
            this.ScoreBt.Size = new System.Drawing.Size(126, 31);
            this.ScoreBt.TabIndex = 1;
            this.ScoreBt.Text = "成绩管理";
            this.ScoreBt.UseVisualStyleBackColor = true;
            this.ScoreBt.Click += new System.EventHandler(this.ScoreBt_Click);
            // 
            // StuBt
            // 
            this.StuBt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StuBt.Location = new System.Drawing.Point(71, 123);
            this.StuBt.Name = "StuBt";
            this.StuBt.Size = new System.Drawing.Size(126, 31);
            this.StuBt.TabIndex = 2;
            this.StuBt.Text = "学生管理";
            this.StuBt.UseVisualStyleBackColor = true;
            this.StuBt.Click += new System.EventHandler(this.StuBt_Click);
            // 
            // CourseBt
            // 
            this.CourseBt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CourseBt.Location = new System.Drawing.Point(71, 178);
            this.CourseBt.Name = "CourseBt";
            this.CourseBt.Size = new System.Drawing.Size(126, 31);
            this.CourseBt.TabIndex = 3;
            this.CourseBt.Text = "课程管理";
            this.CourseBt.UseVisualStyleBackColor = true;
            this.CourseBt.Click += new System.EventHandler(this.CourseBt_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CourseBt);
            this.Controls.Add(this.StuBt);
            this.Controls.Add(this.ScoreBt);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SignOutBt;
        private System.Windows.Forms.Button ScoreBt;
        private System.Windows.Forms.Button StuBt;
        private System.Windows.Forms.Button CourseBt;
    }
}