namespace TXL
{
    partial class SafeFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.FindPass = new System.Windows.Forms.Button();
            this.QuestionLable = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "问题：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "答案：";
            // 
            // UserNameText
            // 
            this.UserNameText.Location = new System.Drawing.Point(77, 49);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.Size = new System.Drawing.Size(123, 21);
            this.UserNameText.TabIndex = 3;
            this.UserNameText.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(77, 146);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(123, 21);
            this.AnswerText.TabIndex = 4;
            // 
            // FindPass
            // 
            this.FindPass.Location = new System.Drawing.Point(31, 205);
            this.FindPass.Name = "FindPass";
            this.FindPass.Size = new System.Drawing.Size(75, 23);
            this.FindPass.TabIndex = 5;
            this.FindPass.Text = "找回密码";
            this.FindPass.UseVisualStyleBackColor = true;
            this.FindPass.Click += new System.EventHandler(this.FindPass_Click);
            // 
            // QuestionLable
            // 
            this.QuestionLable.AutoSize = true;
            this.QuestionLable.Location = new System.Drawing.Point(77, 100);
            this.QuestionLable.Name = "QuestionLable";
            this.QuestionLable.Size = new System.Drawing.Size(89, 12);
            this.QuestionLable.TabIndex = 6;
            this.QuestionLable.Text = "请先输入账号！";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(148, 205);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SafeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 263);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.QuestionLable);
            this.Controls.Add(this.FindPass);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.UserNameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SafeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SafeFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Button FindPass;
        private System.Windows.Forms.Label QuestionLable;
        private System.Windows.Forms.Button Cancel;
    }
}