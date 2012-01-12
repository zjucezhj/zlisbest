namespace TXL
{
    partial class AddCatsFrm
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
            this.AddCatsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CatNameText = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCatsBtn
            // 
            this.AddCatsBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddCatsBtn.Location = new System.Drawing.Point(34, 93);
            this.AddCatsBtn.Name = "AddCatsBtn";
            this.AddCatsBtn.Size = new System.Drawing.Size(75, 23);
            this.AddCatsBtn.TabIndex = 0;
            this.AddCatsBtn.Text = "text";
            this.AddCatsBtn.UseVisualStyleBackColor = true;
            this.AddCatsBtn.Click += new System.EventHandler(this.AddCatsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "分组名称：";
            // 
            // CatNameText
            // 
            this.CatNameText.Location = new System.Drawing.Point(102, 49);
            this.CatNameText.Name = "CatNameText";
            this.CatNameText.Size = new System.Drawing.Size(131, 21);
            this.CatNameText.TabIndex = 2;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(158, 93);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddCatsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 142);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.CatNameText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCatsBtn);
            this.Name = "AddCatsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCatsFrm";
            this.Load += new System.EventHandler(this.AddCatsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCatsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CatNameText;
        private System.Windows.Forms.Button CancelBtn;
    }
}