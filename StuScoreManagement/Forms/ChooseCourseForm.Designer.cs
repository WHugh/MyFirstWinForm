namespace StuScoreManagement.Forms
{
    partial class ChooseCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseCourseForm));
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.课程编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已选人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ViewBt = new System.Windows.Forms.ToolStripButton();
            this.EditBt = new System.Windows.Forms.ToolStripButton();
            this.CreatCourseBt = new System.Windows.Forms.ToolStripButton();
            this.DeleteCourseBt = new System.Windows.Forms.ToolStripButton();
            this.SaveBt = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AllowUserToAddRows = false;
            this.courseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程编号,
            this.课程名称,
            this.学分,
            this.已选人数});
            this.courseDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.courseDataGridView.Location = new System.Drawing.Point(0, 28);
            this.courseDataGridView.MultiSelect = false;
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.ReadOnly = true;
            this.courseDataGridView.RowTemplate.Height = 23;
            this.courseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courseDataGridView.Size = new System.Drawing.Size(445, 279);
            this.courseDataGridView.TabIndex = 0;
            // 
            // 课程编号
            // 
            this.课程编号.HeaderText = "课程编号";
            this.课程编号.Name = "课程编号";
            // 
            // 课程名称
            // 
            this.课程名称.HeaderText = "课程名称";
            this.课程名称.Name = "课程名称";
            // 
            // 学分
            // 
            this.学分.HeaderText = "学分";
            this.学分.Name = "学分";
            // 
            // 已选人数
            // 
            this.已选人数.HeaderText = "已选人数";
            this.已选人数.Name = "已选人数";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewBt,
            this.EditBt,
            this.CreatCourseBt,
            this.DeleteCourseBt,
            this.SaveBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(445, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ViewBt
            // 
            this.ViewBt.Image = ((System.Drawing.Image)(resources.GetObject("ViewBt.Image")));
            this.ViewBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewBt.Name = "ViewBt";
            this.ViewBt.Size = new System.Drawing.Size(52, 22);
            this.ViewBt.Text = "查看";
            this.ViewBt.Click += new System.EventHandler(this.ViewBt_Click);
            // 
            // EditBt
            // 
            this.EditBt.Image = ((System.Drawing.Image)(resources.GetObject("EditBt.Image")));
            this.EditBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(52, 22);
            this.EditBt.Text = "编辑";
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // CreatCourseBt
            // 
            this.CreatCourseBt.Image = ((System.Drawing.Image)(resources.GetObject("CreatCourseBt.Image")));
            this.CreatCourseBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreatCourseBt.Name = "CreatCourseBt";
            this.CreatCourseBt.Size = new System.Drawing.Size(52, 22);
            this.CreatCourseBt.Text = "新增";
            this.CreatCourseBt.Click += new System.EventHandler(this.CreatCourseBt_Click);
            // 
            // DeleteCourseBt
            // 
            this.DeleteCourseBt.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCourseBt.Image")));
            this.DeleteCourseBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCourseBt.Name = "DeleteCourseBt";
            this.DeleteCourseBt.Size = new System.Drawing.Size(52, 22);
            this.DeleteCourseBt.Text = "删除";
            this.DeleteCourseBt.Click += new System.EventHandler(this.DeleteCourseBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Image = ((System.Drawing.Image)(resources.GetObject("SaveBt.Image")));
            this.SaveBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(52, 22);
            this.SaveBt.Text = "保存";
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // ChooseCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 307);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.courseDataGridView);
            this.Name = "ChooseCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseCourse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChooseCourseForm_FormClosed);
            this.Load += new System.EventHandler(this.ChooseCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ViewBt;
        private System.Windows.Forms.ToolStripButton EditBt;
        private System.Windows.Forms.ToolStripButton CreatCourseBt;
        private System.Windows.Forms.ToolStripButton DeleteCourseBt;
        private System.Windows.Forms.ToolStripButton SaveBt;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学分;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已选人数;
    }
}