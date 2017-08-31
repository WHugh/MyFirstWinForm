namespace StuScoreManagement.Forms
{
    partial class ScreenScoreForm
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
            this.minLable = new System.Windows.Forms.Label();
            this.MinTB = new System.Windows.Forms.TextBox();
            this.MaxTB = new System.Windows.Forms.TextBox();
            this.maxLable = new System.Windows.Forms.Label();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.ScreenBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLable.Location = new System.Drawing.Point(35, 45);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(72, 16);
            this.nameLable.TabIndex = 0;
            this.nameLable.Text = "课程名称";
            // 
            // minLable
            // 
            this.minLable.AutoSize = true;
            this.minLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minLable.Location = new System.Drawing.Point(51, 101);
            this.minLable.Name = "minLable";
            this.minLable.Size = new System.Drawing.Size(56, 16);
            this.minLable.TabIndex = 2;
            this.minLable.Text = "最小值";
            // 
            // MinTB
            // 
            this.MinTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinTB.Location = new System.Drawing.Point(113, 98);
            this.MinTB.Name = "MinTB";
            this.MinTB.Size = new System.Drawing.Size(121, 26);
            this.MinTB.TabIndex = 3;
            // 
            // MaxTB
            // 
            this.MaxTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaxTB.Location = new System.Drawing.Point(113, 153);
            this.MaxTB.Name = "MaxTB";
            this.MaxTB.Size = new System.Drawing.Size(121, 26);
            this.MaxTB.TabIndex = 4;
            // 
            // maxLable
            // 
            this.maxLable.AutoSize = true;
            this.maxLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxLable.Location = new System.Drawing.Point(51, 156);
            this.maxLable.Name = "maxLable";
            this.maxLable.Size = new System.Drawing.Size(56, 16);
            this.maxLable.TabIndex = 5;
            this.maxLable.Text = "最大值";
            // 
            // NameComboBox
            // 
            this.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameComboBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(113, 46);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(121, 24);
            this.NameComboBox.TabIndex = 6;
            // 
            // ScreenBt
            // 
            this.ScreenBt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScreenBt.Location = new System.Drawing.Point(102, 209);
            this.ScreenBt.Name = "ScreenBt";
            this.ScreenBt.Size = new System.Drawing.Size(75, 31);
            this.ScreenBt.TabIndex = 7;
            this.ScreenBt.Text = "筛选";
            this.ScreenBt.UseVisualStyleBackColor = true;
            this.ScreenBt.Click += new System.EventHandler(this.ScreenBt_Click);
            // 
            // ScreenScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ScreenBt);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.maxLable);
            this.Controls.Add(this.MaxTB);
            this.Controls.Add(this.MinTB);
            this.Controls.Add(this.minLable);
            this.Controls.Add(this.nameLable);
            this.Name = "ScreenScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenScore";
            this.Load += new System.EventHandler(this.ScreenScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label minLable;
        private System.Windows.Forms.TextBox MinTB;
        private System.Windows.Forms.TextBox MaxTB;
        private System.Windows.Forms.Label maxLable;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.Button ScreenBt;
    }
}