namespace StuScoreManagement.Forms
{
    partial class LoginForm
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
            this.userCodeTB = new System.Windows.Forms.TextBox();
            this.userCodeLable = new System.Windows.Forms.Label();
            this.pswLable = new System.Windows.Forms.Label();
            this.pswTB = new System.Windows.Forms.TextBox();
            this.remPswCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生成绩小系统";
            // 
            // userCodeTB
            // 
            this.userCodeTB.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userCodeTB.Location = new System.Drawing.Point(252, 144);
            this.userCodeTB.Name = "userCodeTB";
            this.userCodeTB.Size = new System.Drawing.Size(168, 30);
            this.userCodeTB.TabIndex = 1;
            // 
            // userCodeLable
            // 
            this.userCodeLable.AutoSize = true;
            this.userCodeLable.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userCodeLable.Location = new System.Drawing.Point(178, 147);
            this.userCodeLable.Name = "userCodeLable";
            this.userCodeLable.Size = new System.Drawing.Size(49, 20);
            this.userCodeLable.TabIndex = 2;
            this.userCodeLable.Text = "编号";
            // 
            // pswLable
            // 
            this.pswLable.AutoSize = true;
            this.pswLable.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pswLable.Location = new System.Drawing.Point(178, 210);
            this.pswLable.Name = "pswLable";
            this.pswLable.Size = new System.Drawing.Size(49, 20);
            this.pswLable.TabIndex = 4;
            this.pswLable.Text = "密码";
            // 
            // pswTB
            // 
            this.pswTB.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pswTB.Location = new System.Drawing.Point(252, 207);
            this.pswTB.Name = "pswTB";
            this.pswTB.PasswordChar = '*';
            this.pswTB.Size = new System.Drawing.Size(168, 30);
            this.pswTB.TabIndex = 3;
            // 
            // remPswCheckBox
            // 
            this.remPswCheckBox.AutoSize = true;
            this.remPswCheckBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remPswCheckBox.Location = new System.Drawing.Point(276, 258);
            this.remPswCheckBox.Name = "remPswCheckBox";
            this.remPswCheckBox.Size = new System.Drawing.Size(82, 18);
            this.remPswCheckBox.TabIndex = 5;
            this.remPswCheckBox.Text = "记住密码";
            this.remPswCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginBt
            // 
            this.LoginBt.Location = new System.Drawing.Point(243, 293);
            this.LoginBt.Name = "LoginBt";
            this.LoginBt.Size = new System.Drawing.Size(140, 43);
            this.LoginBt.TabIndex = 6;
            this.LoginBt.Text = "登录";
            this.LoginBt.UseVisualStyleBackColor = true;
            this.LoginBt.Click += new System.EventHandler(this.LoginBt_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 359);
            this.Controls.Add(this.LoginBt);
            this.Controls.Add(this.remPswCheckBox);
            this.Controls.Add(this.pswLable);
            this.Controls.Add(this.pswTB);
            this.Controls.Add(this.userCodeLable);
            this.Controls.Add(this.userCodeTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userCodeTB;
        private System.Windows.Forms.Label userCodeLable;
        private System.Windows.Forms.Label pswLable;
        private System.Windows.Forms.TextBox pswTB;
        private System.Windows.Forms.CheckBox remPswCheckBox;
        private System.Windows.Forms.Button LoginBt;


    }
}