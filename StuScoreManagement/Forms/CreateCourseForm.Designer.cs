namespace StuScoreManagement.Forms
{
    partial class CreateCourseForm
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
            this.CourseNameTB = new System.Windows.Forms.TextBox();
            this.creditLable = new System.Windows.Forms.Label();
            this.CreditNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CreditNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLable.Location = new System.Drawing.Point(27, 73);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(72, 16);
            this.nameLable.TabIndex = 0;
            this.nameLable.Text = "课程名称";
            // 
            // CourseNameTB
            // 
            this.CourseNameTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CourseNameTB.Location = new System.Drawing.Point(105, 70);
            this.CourseNameTB.Name = "CourseNameTB";
            this.CourseNameTB.Size = new System.Drawing.Size(132, 26);
            this.CourseNameTB.TabIndex = 1;
            // 
            // creditLable
            // 
            this.creditLable.AutoSize = true;
            this.creditLable.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.creditLable.Location = new System.Drawing.Point(59, 122);
            this.creditLable.Name = "creditLable";
            this.creditLable.Size = new System.Drawing.Size(40, 16);
            this.creditLable.TabIndex = 2;
            this.creditLable.Text = "学分";
            // 
            // CreditNumericUpDown
            // 
            this.CreditNumericUpDown.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CreditNumericUpDown.Location = new System.Drawing.Point(105, 120);
            this.CreditNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CreditNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CreditNumericUpDown.Name = "CreditNumericUpDown";
            this.CreditNumericUpDown.Size = new System.Drawing.Size(132, 26);
            this.CreditNumericUpDown.TabIndex = 3;
            this.CreditNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SaveBt
            // 
            this.SaveBt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveBt.Location = new System.Drawing.Point(105, 182);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(75, 34);
            this.SaveBt.TabIndex = 4;
            this.SaveBt.Text = "保存";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // CreateCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.CreditNumericUpDown);
            this.Controls.Add(this.creditLable);
            this.Controls.Add(this.CourseNameTB);
            this.Controls.Add(this.nameLable);
            this.Name = "CreateCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.CreditNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox CourseNameTB;
        private System.Windows.Forms.Label creditLable;
        private System.Windows.Forms.NumericUpDown CreditNumericUpDown;
        private System.Windows.Forms.Button SaveBt;
    }
}