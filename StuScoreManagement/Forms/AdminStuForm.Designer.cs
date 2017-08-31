namespace StuScoreManagement.Forms
{
    partial class AdminStuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStuForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DeleteBt = new System.Windows.Forms.ToolStripButton();
            this.CreateBt = new System.Windows.Forms.ToolStripButton();
            this.EditBt = new System.Windows.Forms.ToolStripButton();
            this.ViewBt = new System.Windows.Forms.ToolStripButton();
            this.SearchBt = new System.Windows.Forms.ToolStripButton();
            this.AllUserDataGridView = new System.Windows.Forms.DataGridView();
            this.ResetBt = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewBt,
            this.EditBt,
            this.CreateBt,
            this.DeleteBt,
            this.SearchBt,
            this.ResetBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(396, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DeleteBt
            // 
            this.DeleteBt.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBt.Image")));
            this.DeleteBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(52, 22);
            this.DeleteBt.Text = "删除";
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // CreateBt
            // 
            this.CreateBt.Image = ((System.Drawing.Image)(resources.GetObject("CreateBt.Image")));
            this.CreateBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateBt.Name = "CreateBt";
            this.CreateBt.Size = new System.Drawing.Size(52, 22);
            this.CreateBt.Text = "新增";
            this.CreateBt.Click += new System.EventHandler(this.CreateBt_Click);
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
            // ViewBt
            // 
            this.ViewBt.Image = ((System.Drawing.Image)(resources.GetObject("ViewBt.Image")));
            this.ViewBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewBt.Name = "ViewBt";
            this.ViewBt.Size = new System.Drawing.Size(52, 22);
            this.ViewBt.Text = "查看";
            this.ViewBt.Click += new System.EventHandler(this.ViewBt_Click);
            // 
            // SearchBt
            // 
            this.SearchBt.Image = ((System.Drawing.Image)(resources.GetObject("SearchBt.Image")));
            this.SearchBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(52, 22);
            this.SearchBt.Text = "查找";
            this.SearchBt.Click += new System.EventHandler(this.SearchBt_Click);
            // 
            // AllUserDataGridView
            // 
            this.AllUserDataGridView.AllowUserToAddRows = false;
            this.AllUserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUserDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AllUserDataGridView.Location = new System.Drawing.Point(0, 29);
            this.AllUserDataGridView.MultiSelect = false;
            this.AllUserDataGridView.Name = "AllUserDataGridView";
            this.AllUserDataGridView.ReadOnly = true;
            this.AllUserDataGridView.RowTemplate.Height = 23;
            this.AllUserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllUserDataGridView.Size = new System.Drawing.Size(396, 411);
            this.AllUserDataGridView.TabIndex = 1;
            // 
            // ResetBt
            // 
            this.ResetBt.Image = ((System.Drawing.Image)(resources.GetObject("ResetBt.Image")));
            this.ResetBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetBt.Name = "ResetBt";
            this.ResetBt.Size = new System.Drawing.Size(52, 22);
            this.ResetBt.Text = "恢复";
            this.ResetBt.Click += new System.EventHandler(this.ResetBt_Click);
            // 
            // AdminStuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 440);
            this.Controls.Add(this.AllUserDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdminStuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminStuForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminStuForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton DeleteBt;
        private System.Windows.Forms.ToolStripButton ViewBt;
        private System.Windows.Forms.ToolStripButton EditBt;
        private System.Windows.Forms.ToolStripButton CreateBt;
        private System.Windows.Forms.ToolStripButton SearchBt;
        private System.Windows.Forms.DataGridView AllUserDataGridView;
        private System.Windows.Forms.ToolStripButton ResetBt;
    }
}