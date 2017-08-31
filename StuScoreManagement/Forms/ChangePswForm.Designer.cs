namespace StuScoreManagement.Forms
{
    partial class ChangePswForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.newPswTB1 = new System.Windows.Forms.TextBox();
            this.newPswTB2 = new System.Windows.Forms.TextBox();
            this.savePswChangeBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "新密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "确认密码";
            // 
            // newPswTB1
            // 
            this.newPswTB1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPswTB1.Location = new System.Drawing.Point(106, 78);
            this.newPswTB1.Name = "newPswTB1";
            this.newPswTB1.PasswordChar = '*';
            this.newPswTB1.Size = new System.Drawing.Size(135, 26);
            this.newPswTB1.TabIndex = 2;
            // 
            // newPswTB2
            // 
            this.newPswTB2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPswTB2.Location = new System.Drawing.Point(106, 131);
            this.newPswTB2.Name = "newPswTB2";
            this.newPswTB2.PasswordChar = '*';
            this.newPswTB2.Size = new System.Drawing.Size(135, 26);
            this.newPswTB2.TabIndex = 3;
            // 
            // savePswChangeBt
            // 
            this.savePswChangeBt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.savePswChangeBt.Location = new System.Drawing.Point(93, 194);
            this.savePswChangeBt.Name = "savePswChangeBt";
            this.savePswChangeBt.Size = new System.Drawing.Size(83, 31);
            this.savePswChangeBt.TabIndex = 4;
            this.savePswChangeBt.Text = "保存";
            this.savePswChangeBt.UseVisualStyleBackColor = true;
            this.savePswChangeBt.Click += new System.EventHandler(this.savePswChangeBt_Click);
            // 
            // ChangePsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.savePswChangeBt);
            this.Controls.Add(this.newPswTB2);
            this.Controls.Add(this.newPswTB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePsw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePsw";
            this.Load += new System.EventHandler(this.ChangePsw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPswTB1;
        private System.Windows.Forms.TextBox newPswTB2;
        private System.Windows.Forms.Button savePswChangeBt;
    }
}