namespace StuScoreManagement.Forms
{
    partial class StudentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.CodeLable = new System.Windows.Forms.Label();
            this.CodeTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.NameLable = new System.Windows.Forms.Label();
            this.GenderLable = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.birthLable = new System.Windows.Forms.Label();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NativeTB = new System.Windows.Forms.TextBox();
            this.NativeLable = new System.Windows.Forms.Label();
            this.scoreDataGridView = new System.Windows.Forms.DataGridView();
            this.ChooseCourseBt = new System.Windows.Forms.ToolStripButton();
            this.DropCourseBt = new System.Windows.Forms.ToolStripButton();
            this.EditUserInfoBt = new System.Windows.Forms.ToolStripButton();
            this.ChangePswBt = new System.Windows.Forms.ToolStripButton();
            this.SaveBt = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SignOutBt = new System.Windows.Forms.ToolStripButton();
            this.AlterScoreBt = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeLable
            // 
            this.CodeLable.AutoSize = true;
            this.CodeLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeLable.Location = new System.Drawing.Point(50, 57);
            this.CodeLable.Name = "CodeLable";
            this.CodeLable.Size = new System.Drawing.Size(40, 16);
            this.CodeLable.TabIndex = 1;
            this.CodeLable.Text = "编号";
            // 
            // CodeTB
            // 
            this.CodeTB.Enabled = false;
            this.CodeTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CodeTB.Location = new System.Drawing.Point(96, 52);
            this.CodeTB.Name = "CodeTB";
            this.CodeTB.Size = new System.Drawing.Size(145, 26);
            this.CodeTB.TabIndex = 2;
            // 
            // NameTB
            // 
            this.NameTB.Enabled = false;
            this.NameTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTB.Location = new System.Drawing.Point(312, 52);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(107, 26);
            this.NameTB.TabIndex = 4;
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameLable.Location = new System.Drawing.Point(266, 57);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(40, 16);
            this.NameLable.TabIndex = 3;
            this.NameLable.Text = "姓名";
            // 
            // GenderLable
            // 
            this.GenderLable.AutoSize = true;
            this.GenderLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenderLable.Location = new System.Drawing.Point(462, 57);
            this.GenderLable.Name = "GenderLable";
            this.GenderLable.Size = new System.Drawing.Size(40, 16);
            this.GenderLable.TabIndex = 5;
            this.GenderLable.Text = "性别";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.Enabled = false;
            this.GenderComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(508, 52);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 24);
            this.GenderComboBox.TabIndex = 6;
            // 
            // birthLable
            // 
            this.birthLable.AutoSize = true;
            this.birthLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.birthLable.Location = new System.Drawing.Point(12, 112);
            this.birthLable.Name = "birthLable";
            this.birthLable.Size = new System.Drawing.Size(72, 16);
            this.birthLable.TabIndex = 7;
            this.birthLable.Text = "出生日期";
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.BirthDateTimePicker.Enabled = false;
            this.BirthDateTimePicker.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDateTimePicker.Location = new System.Drawing.Point(96, 105);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(145, 26);
            this.BirthDateTimePicker.TabIndex = 8;
            // 
            // NativeTB
            // 
            this.NativeTB.Enabled = false;
            this.NativeTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NativeTB.Location = new System.Drawing.Point(312, 105);
            this.NativeTB.Name = "NativeTB";
            this.NativeTB.Size = new System.Drawing.Size(107, 26);
            this.NativeTB.TabIndex = 10;
            // 
            // NativeLable
            // 
            this.NativeLable.AutoSize = true;
            this.NativeLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NativeLable.Location = new System.Drawing.Point(266, 110);
            this.NativeLable.Name = "NativeLable";
            this.NativeLable.Size = new System.Drawing.Size(40, 16);
            this.NativeLable.TabIndex = 9;
            this.NativeLable.Text = "籍贯";
            // 
            // scoreDataGridView
            // 
            this.scoreDataGridView.AllowUserToAddRows = false;
            this.scoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scoreDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.scoreDataGridView.Location = new System.Drawing.Point(0, 168);
            this.scoreDataGridView.MultiSelect = false;
            this.scoreDataGridView.Name = "scoreDataGridView";
            this.scoreDataGridView.ReadOnly = true;
            this.scoreDataGridView.RowTemplate.Height = 23;
            this.scoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scoreDataGridView.Size = new System.Drawing.Size(648, 137);
            this.scoreDataGridView.TabIndex = 11;
            // 
            // ChooseCourseBt
            // 
            this.ChooseCourseBt.Image = ((System.Drawing.Image)(resources.GetObject("ChooseCourseBt.Image")));
            this.ChooseCourseBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChooseCourseBt.Name = "ChooseCourseBt";
            this.ChooseCourseBt.Size = new System.Drawing.Size(52, 22);
            this.ChooseCourseBt.Text = "选课";
            this.ChooseCourseBt.Click += new System.EventHandler(this.ChooseCourseBt_Click);
            // 
            // DropCourseBt
            // 
            this.DropCourseBt.Image = ((System.Drawing.Image)(resources.GetObject("DropCourseBt.Image")));
            this.DropCourseBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropCourseBt.Name = "DropCourseBt";
            this.DropCourseBt.Size = new System.Drawing.Size(52, 22);
            this.DropCourseBt.Text = "退课";
            this.DropCourseBt.Click += new System.EventHandler(this.DropCourseBt_Click);
            // 
            // EditUserInfoBt
            // 
            this.EditUserInfoBt.Image = ((System.Drawing.Image)(resources.GetObject("EditUserInfoBt.Image")));
            this.EditUserInfoBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditUserInfoBt.Name = "EditUserInfoBt";
            this.EditUserInfoBt.Size = new System.Drawing.Size(100, 22);
            this.EditUserInfoBt.Text = "修改个人信息";
            this.EditUserInfoBt.Click += new System.EventHandler(this.EditUserInfoBt_Click);
            // 
            // ChangePswBt
            // 
            this.ChangePswBt.Image = ((System.Drawing.Image)(resources.GetObject("ChangePswBt.Image")));
            this.ChangePswBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangePswBt.Name = "ChangePswBt";
            this.ChangePswBt.Size = new System.Drawing.Size(76, 22);
            this.ChangePswBt.Text = "修改密码";
            this.ChangePswBt.Click += new System.EventHandler(this.ChangePswBt_Click);
            // 
            // SaveBt
            // 
            this.SaveBt.Enabled = false;
            this.SaveBt.Image = ((System.Drawing.Image)(resources.GetObject("SaveBt.Image")));
            this.SaveBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(52, 22);
            this.SaveBt.Text = "保存";
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseCourseBt,
            this.DropCourseBt,
            this.EditUserInfoBt,
            this.ChangePswBt,
            this.SaveBt,
            this.SignOutBt,
            this.AlterScoreBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 25);
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
            // AlterScoreBt
            // 
            this.AlterScoreBt.Enabled = false;
            this.AlterScoreBt.Image = ((System.Drawing.Image)(resources.GetObject("AlterScoreBt.Image")));
            this.AlterScoreBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlterScoreBt.Name = "AlterScoreBt";
            this.AlterScoreBt.Size = new System.Drawing.Size(76, 22);
            this.AlterScoreBt.Text = "成绩录入";
            this.AlterScoreBt.Click += new System.EventHandler(this.AlterScoreBt_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 305);
            this.Controls.Add(this.scoreDataGridView);
            this.Controls.Add(this.NativeTB);
            this.Controls.Add(this.NativeLable);
            this.Controls.Add(this.BirthDateTimePicker);
            this.Controls.Add(this.birthLable);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.GenderLable);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.CodeTB);
            this.Controls.Add(this.CodeLable);
            this.Controls.Add(this.toolStrip1);
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMainForm";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodeLable;
        private System.Windows.Forms.TextBox CodeTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label GenderLable;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label birthLable;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.TextBox NativeTB;
        private System.Windows.Forms.Label NativeLable;
        private System.Windows.Forms.DataGridView scoreDataGridView;
        private System.Windows.Forms.ToolStripButton ChooseCourseBt;
        private System.Windows.Forms.ToolStripButton DropCourseBt;
        private System.Windows.Forms.ToolStripButton EditUserInfoBt;
        private System.Windows.Forms.ToolStripButton ChangePswBt;
        private System.Windows.Forms.ToolStripButton SaveBt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SignOutBt;
        private System.Windows.Forms.ToolStripButton AlterScoreBt;
    }
}