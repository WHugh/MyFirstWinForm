namespace StuScoreManagement.Forms
{
    partial class AdminScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScoreForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.viewBt = new System.Windows.Forms.ToolStripButton();
            this.alterBt = new System.Windows.Forms.ToolStripButton();
            this.screenBt = new System.Windows.Forms.ToolStripButton();
            this.ResetBt = new System.Windows.Forms.ToolStripButton();
            this.searchBt = new System.Windows.Forms.ToolStripButton();
            this.allScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBt,
            this.alterBt,
            this.screenBt,
            this.ResetBt,
            this.searchBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(708, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // viewBt
            // 
            this.viewBt.Image = ((System.Drawing.Image)(resources.GetObject("viewBt.Image")));
            this.viewBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewBt.Name = "viewBt";
            this.viewBt.Size = new System.Drawing.Size(52, 22);
            this.viewBt.Text = "查看";
            this.viewBt.Click += new System.EventHandler(this.viewBt_Click);
            // 
            // alterBt
            // 
            this.alterBt.Image = ((System.Drawing.Image)(resources.GetObject("alterBt.Image")));
            this.alterBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alterBt.Name = "alterBt";
            this.alterBt.Size = new System.Drawing.Size(52, 22);
            this.alterBt.Text = "编辑";
            this.alterBt.Click += new System.EventHandler(this.alterBt_Click);
            // 
            // screenBt
            // 
            this.screenBt.Image = ((System.Drawing.Image)(resources.GetObject("screenBt.Image")));
            this.screenBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.screenBt.Name = "screenBt";
            this.screenBt.Size = new System.Drawing.Size(88, 22);
            this.screenBt.Text = "按成绩筛选";
            this.screenBt.Click += new System.EventHandler(this.screenBt_Click);
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
            // searchBt
            // 
            this.searchBt.Image = ((System.Drawing.Image)(resources.GetObject("searchBt.Image")));
            this.searchBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(76, 22);
            this.searchBt.Text = "查找学生";
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // allScoreDataGridView
            // 
            this.allScoreDataGridView.AllowUserToAddRows = false;
            this.allScoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allScoreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allScoreDataGridView.Location = new System.Drawing.Point(0, 25);
            this.allScoreDataGridView.MultiSelect = false;
            this.allScoreDataGridView.Name = "allScoreDataGridView";
            this.allScoreDataGridView.RowTemplate.Height = 23;
            this.allScoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allScoreDataGridView.Size = new System.Drawing.Size(708, 480);
            this.allScoreDataGridView.TabIndex = 1;
            // 
            // AdminScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 505);
            this.Controls.Add(this.allScoreDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdminScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminScoreForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminScoreForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminScoreForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allScoreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton viewBt;
        private System.Windows.Forms.ToolStripButton alterBt;
        private System.Windows.Forms.ToolStripButton screenBt;
        private System.Windows.Forms.ToolStripButton searchBt;
        private System.Windows.Forms.DataGridView allScoreDataGridView;
        private System.Windows.Forms.ToolStripButton ResetBt;
    }
}