namespace ClassManagementSystem.UserManage
{
    partial class ModifyForm
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
            this.TipLab = new System.Windows.Forms.Label();
            this.UserTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OldPwdTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassTBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTBox1 = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipLab
            // 
            this.TipLab.AutoSize = true;
            this.TipLab.Location = new System.Drawing.Point(31, 22);
            this.TipLab.Name = "TipLab";
            this.TipLab.Size = new System.Drawing.Size(47, 12);
            this.TipLab.TabIndex = 0;
            this.TipLab.Text = "用户名:";
            // 
            // UserTBox
            // 
            this.UserTBox.Location = new System.Drawing.Point(95, 19);
            this.UserTBox.Name = "UserTBox";
            this.UserTBox.ReadOnly = true;
            this.UserTBox.Size = new System.Drawing.Size(125, 21);
            this.UserTBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码:";
            // 
            // OldPwdTBox
            // 
            this.OldPwdTBox.Location = new System.Drawing.Point(95, 52);
            this.OldPwdTBox.Name = "OldPwdTBox";
            this.OldPwdTBox.PasswordChar = '*';
            this.OldPwdTBox.Size = new System.Drawing.Size(125, 21);
            this.OldPwdTBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "确认密码:";
            // 
            // PassTBox2
            // 
            this.PassTBox2.Location = new System.Drawing.Point(95, 118);
            this.PassTBox2.Name = "PassTBox2";
            this.PassTBox2.PasswordChar = '*';
            this.PassTBox2.Size = new System.Drawing.Size(125, 21);
            this.PassTBox2.TabIndex = 2;
            this.PassTBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PassTBox2_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "新密码:";
            // 
            // PassTBox1
            // 
            this.PassTBox1.Location = new System.Drawing.Point(95, 85);
            this.PassTBox1.Name = "PassTBox1";
            this.PassTBox1.PasswordChar = '*';
            this.PassTBox1.Size = new System.Drawing.Size(125, 21);
            this.PassTBox1.TabIndex = 1;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(33, 155);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 3;
            this.OKBtn.Text = "确定";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(145, 155);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 208);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.PassTBox1);
            this.Controls.Add(this.PassTBox2);
            this.Controls.Add(this.OldPwdTBox);
            this.Controls.Add(this.UserTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TipLab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户信息修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipLab;
        private System.Windows.Forms.TextBox UserTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OldPwdTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassTBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTBox1;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}