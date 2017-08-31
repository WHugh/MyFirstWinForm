namespace StuScoreManagement.Forms
{
    partial class SearchStuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserCodeTB = new System.Windows.Forms.TextBox();
            this.SearchBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入学生编号";
            // 
            // UserCodeTB
            // 
            this.UserCodeTB.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserCodeTB.Location = new System.Drawing.Point(138, 42);
            this.UserCodeTB.Name = "UserCodeTB";
            this.UserCodeTB.Size = new System.Drawing.Size(153, 26);
            this.UserCodeTB.TabIndex = 1;
            // 
            // SearchBt
            // 
            this.SearchBt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBt.Location = new System.Drawing.Point(297, 42);
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(60, 26);
            this.SearchBt.TabIndex = 2;
            this.SearchBt.Text = "查找";
            this.SearchBt.UseVisualStyleBackColor = true;
            this.SearchBt.Click += new System.EventHandler(this.SearchBt_Click);
            // 
            // SearchStuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 114);
            this.Controls.Add(this.SearchBt);
            this.Controls.Add(this.UserCodeTB);
            this.Controls.Add(this.label1);
            this.Name = "SearchStuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchStuForm";
            this.Load += new System.EventHandler(this.SearchStuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserCodeTB;
        private System.Windows.Forms.Button SearchBt;
    }
}