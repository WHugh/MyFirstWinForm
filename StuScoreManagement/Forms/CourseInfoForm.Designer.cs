namespace StuScoreManagement.Forms
{
    partial class CourseInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseInfoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SaveBt = new System.Windows.Forms.ToolStripButton();
            this.ScreenBt = new System.Windows.Forms.ToolStripButton();
            this.ResetBt = new System.Windows.Forms.ToolStripButton();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CreditLable = new System.Windows.Forms.Label();
            this.ChosenCountLabel = new System.Windows.Forms.Label();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CreditTB = new System.Windows.Forms.TextBox();
            this.ChosenCountTB = new System.Windows.Forms.TextBox();
            this.CourseScoreDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseScoreDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveBt,
            this.ScreenBt,
            this.ResetBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(349, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // ScreenBt
            // 
            this.ScreenBt.Image = ((System.Drawing.Image)(resources.GetObject("ScreenBt.Image")));
            this.ScreenBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScreenBt.Name = "ScreenBt";
            this.ScreenBt.Size = new System.Drawing.Size(52, 22);
            this.ScreenBt.Text = "筛选";
            this.ScreenBt.Click += new System.EventHandler(this.ScreenBt_Click);
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
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeLabel.Location = new System.Drawing.Point(12, 45);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(40, 16);
            this.CodeLabel.TabIndex = 1;
            this.CodeLabel.Text = "编号";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLabel.Location = new System.Drawing.Point(168, 45);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 16);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "名称";
            // 
            // CreditLable
            // 
            this.CreditLable.AutoSize = true;
            this.CreditLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CreditLable.Location = new System.Drawing.Point(12, 86);
            this.CreditLable.Name = "CreditLable";
            this.CreditLable.Size = new System.Drawing.Size(40, 16);
            this.CreditLable.TabIndex = 3;
            this.CreditLable.Text = "学分";
            // 
            // ChosenCountLabel
            // 
            this.ChosenCountLabel.AutoSize = true;
            this.ChosenCountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChosenCountLabel.Location = new System.Drawing.Point(136, 86);
            this.ChosenCountLabel.Name = "ChosenCountLabel";
            this.ChosenCountLabel.Size = new System.Drawing.Size(72, 16);
            this.ChosenCountLabel.TabIndex = 4;
            this.ChosenCountLabel.Text = "已选人数";
            // 
            // CodeTB
            // 
            this.CodeTB.Enabled = false;
            this.CodeTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeTB.Location = new System.Drawing.Point(58, 42);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(64, 26);
            this.CodeTB.TabIndex = 5;
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTB.Location = new System.Drawing.Point(214, 42);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(123, 26);
            this.NameTB.TabIndex = 6;
            // 
            // CreditTB
            // 
            this.CreditTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CreditTB.Location = new System.Drawing.Point(58, 83);
            this.CreditTB.Name = "CreditTB";
            this.CreditTB.Size = new System.Drawing.Size(64, 26);
            this.CreditTB.TabIndex = 7;
            // 
            // ChosenCountTB
            // 
            this.ChosenCountTB.Enabled = false;
            this.ChosenCountTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChosenCountTB.Location = new System.Drawing.Point(214, 83);
            this.ChosenCountTB.Name = "ChosenCountTB";
            this.ChosenCountTB.Size = new System.Drawing.Size(123, 26);
            this.ChosenCountTB.TabIndex = 8;
            // 
            // CourseScoreDataGridView
            // 
            this.CourseScoreDataGridView.AllowUserToAddRows = false;
            this.CourseScoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseScoreDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CourseScoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseScoreDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CourseScoreDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CourseScoreDataGridView.Location = new System.Drawing.Point(0, 129);
            this.CourseScoreDataGridView.MultiSelect = false;
            this.CourseScoreDataGridView.Name = "CourseScoreDataGridView";
            this.CourseScoreDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseScoreDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CourseScoreDataGridView.RowTemplate.Height = 23;
            this.CourseScoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseScoreDataGridView.Size = new System.Drawing.Size(349, 365);
            this.CourseScoreDataGridView.TabIndex = 9;
            // 
            // CourseInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 494);
            this.Controls.Add(this.CourseScoreDataGridView);
            this.Controls.Add(this.ChosenCountTB);
            this.Controls.Add(this.CreditTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.CodeTB);
            this.Controls.Add(this.ChosenCountLabel);
            this.Controls.Add(this.CreditLable);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "CourseInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseInfoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseInfoForm_FormClosed);
            this.Load += new System.EventHandler(this.CourseInfoForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseScoreDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveBt;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CreditLable;
        private System.Windows.Forms.Label ChosenCountLabel;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox CreditTB;
        private System.Windows.Forms.TextBox ChosenCountTB;
        private System.Windows.Forms.DataGridView CourseScoreDataGridView;
        private System.Windows.Forms.ToolStripButton ScreenBt;
        private System.Windows.Forms.ToolStripButton ResetBt;
    }
}