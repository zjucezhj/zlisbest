namespace TXL
{
    partial class RegisterFrm
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
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionText = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.SuerBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CheckUser = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(82, 44);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(134, 21);
            this.UserNameText.TabIndex = 2;
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(82, 86);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(134, 21);
            this.PassText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "安全：";
            // 
            // QuestionText
            // 
            this.QuestionText.FormattingEnabled = true;
            this.QuestionText.Location = new System.Drawing.Point(82, 148);
            this.QuestionText.Name = "QuestionText";
            this.QuestionText.Size = new System.Drawing.Size(134, 20);
            this.QuestionText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "回答：";
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(83, 181);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(133, 21);
            this.AnswerText.TabIndex = 7;
            // 
            // SuerBtn
            // 
            this.SuerBtn.Location = new System.Drawing.Point(37, 219);
            this.SuerBtn.Name = "SuerBtn";
            this.SuerBtn.Size = new System.Drawing.Size(75, 23);
            this.SuerBtn.TabIndex = 8;
            this.SuerBtn.Text = "确定";
            this.SuerBtn.UseVisualStyleBackColor = true;
            this.SuerBtn.Click += new System.EventHandler(this.SuerBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(171, 219);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CheckUser
            // 
            this.CheckUser.AutoSize = true;
            this.CheckUser.Location = new System.Drawing.Point(215, 42);
            this.CheckUser.Name = "CheckUser";
            this.CheckUser.Size = new System.Drawing.Size(53, 24);
            this.CheckUser.TabIndex = 10;
            this.CheckUser.TabStop = true;
            this.CheckUser.Text = "检测账号\r\n是否存在";
            this.CheckUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckUser_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(17, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "以下是安全问题用来找回密码(必填)：";
            // 
            // RegisterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 272);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckUser);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SuerBtn);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuestionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegisterFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox QuestionText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Button SuerBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.LinkLabel CheckUser;
        private System.Windows.Forms.Label label5;
    }
}