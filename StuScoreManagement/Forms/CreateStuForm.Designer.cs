namespace StuScoreManagement.Forms
{
    partial class CreateStuForm
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
            this.nameLable = new System.Windows.Forms.Label();
            this.genderLable = new System.Windows.Forms.Label();
            this.birthLable = new System.Windows.Forms.Label();
            this.nativeLable = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NativeTB = new System.Windows.Forms.TextBox();
            this.SaveBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLable.Location = new System.Drawing.Point(48, 54);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(40, 16);
            this.nameLable.TabIndex = 0;
            this.nameLable.Text = "姓名";
            // 
            // genderLable
            // 
            this.genderLable.AutoSize = true;
            this.genderLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.genderLable.Location = new System.Drawing.Point(276, 54);
            this.genderLable.Name = "genderLable";
            this.genderLable.Size = new System.Drawing.Size(40, 16);
            this.genderLable.TabIndex = 1;
            this.genderLable.Text = "性别";
            // 
            // birthLable
            // 
            this.birthLable.AutoSize = true;
            this.birthLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.birthLable.Location = new System.Drawing.Point(16, 127);
            this.birthLable.Name = "birthLable";
            this.birthLable.Size = new System.Drawing.Size(72, 16);
            this.birthLable.TabIndex = 2;
            this.birthLable.Text = "出生日期";
            // 
            // nativeLable
            // 
            this.nativeLable.AutoSize = true;
            this.nativeLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nativeLable.Location = new System.Drawing.Point(276, 127);
            this.nativeLable.Name = "nativeLable";
            this.nativeLable.Size = new System.Drawing.Size(40, 16);
            this.nativeLable.TabIndex = 3;
            this.nativeLable.Text = "籍贯";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameTB.Location = new System.Drawing.Point(94, 51);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(155, 26);
            this.NameTB.TabIndex = 4;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(322, 51);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(170, 24);
            this.GenderComboBox.TabIndex = 5;
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.BirthDateTimePicker.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDateTimePicker.Location = new System.Drawing.Point(94, 123);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(155, 26);
            this.BirthDateTimePicker.TabIndex = 6;
            // 
            // NativeTB
            // 
            this.NativeTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NativeTB.Location = new System.Drawing.Point(322, 123);
            this.NativeTB.Name = "NativeTB";
            this.NativeTB.Size = new System.Drawing.Size(170, 26);
            this.NativeTB.TabIndex = 7;
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveBt.Location = new System.Drawing.Point(223, 193);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(75, 31);
            this.SaveBt.TabIndex = 8;
            this.SaveBt.Text = "保存";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // CreateStuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 267);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.NativeTB);
            this.Controls.Add(this.BirthDateTimePicker);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.nativeLable);
            this.Controls.Add(this.birthLable);
            this.Controls.Add(this.genderLable);
            this.Controls.Add(this.nameLable);
            this.Name = "CreateStuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateStuForm";
            this.Load += new System.EventHandler(this.CreateStuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label genderLable;
        private System.Windows.Forms.Label birthLable;
        private System.Windows.Forms.Label nativeLable;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.TextBox NativeTB;
        private System.Windows.Forms.Button SaveBt;
    }
}