namespace TXL
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPersons = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCats = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.Exits = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SearchName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.SearchTel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.SearchCel = new System.Windows.Forms.ToolStripTextBox();
            this.tvCats = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvPerson = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChangPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.移动到分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.尚未实现ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddCatBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangName = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPersonBTN = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCats = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPersons,
            this.AddCats,
            this.ChangUsers,
            this.Exits});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // AddPersons
            // 
            this.AddPersons.Name = "AddPersons";
            this.AddPersons.Size = new System.Drawing.Size(136, 22);
            this.AddPersons.Text = "新建联系人";
            this.AddPersons.Click += new System.EventHandler(this.AddPersons_Click);
            // 
            // AddCats
            // 
            this.AddCats.Name = "AddCats";
            this.AddCats.Size = new System.Drawing.Size(136, 22);
            this.AddCats.Text = "新建分组";
            this.AddCats.Click += new System.EventHandler(this.AddCats_Click);
            // 
            // ChangUsers
            // 
            this.ChangUsers.Name = "ChangUsers";
            this.ChangUsers.Size = new System.Drawing.Size(136, 22);
            this.ChangUsers.Text = "更换账号";
            this.ChangUsers.Click += new System.EventHandler(this.ChangUsers_Click);
            // 
            // Exits
            // 
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(136, 22);
            this.Exits.Text = "退出";
            this.Exits.Click += new System.EventHandler(this.Exits_Click);
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VersionBtn,
            this.AboutAuthor});
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // VersionBtn
            // 
            this.VersionBtn.Name = "VersionBtn";
            this.VersionBtn.Size = new System.Drawing.Size(124, 22);
            this.VersionBtn.Text = "版本";
            this.VersionBtn.Click += new System.EventHandler(this.VersionBtn_Click);
            // 
            // AboutAuthor
            // 
            this.AboutAuthor.Name = "AboutAuthor";
            this.AboutAuthor.Size = new System.Drawing.Size(124, 22);
            this.AboutAuthor.Text = "关于作者";
            this.AboutAuthor.Click += new System.EventHandler(this.AboutAuthor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.SearchName,
            this.toolStripLabel3,
            this.SearchTel,
            this.toolStripLabel4,
            this.SearchCel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(467, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "姓名：";
            // 
            // SearchName
            // 
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(100, 25);
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel3.Text = "手机：";
            // 
            // SearchTel
            // 
            this.SearchTel.Name = "SearchTel";
            this.SearchTel.Size = new System.Drawing.Size(100, 25);
            this.SearchTel.TextChanged += new System.EventHandler(this.SearchTel_TextChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel4.Text = "电话：";
            // 
            // SearchCel
            // 
            this.SearchCel.Name = "SearchCel";
            this.SearchCel.Size = new System.Drawing.Size(100, 25);
            this.SearchCel.TextChanged += new System.EventHandler(this.SearchCel_TextChanged);
            // 
            // tvCats
            // 
            this.tvCats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvCats.ImageIndex = 0;
            this.tvCats.ImageList = this.imageList1;
            this.tvCats.Location = new System.Drawing.Point(0, 53);
            this.tvCats.Name = "tvCats";
            this.tvCats.SelectedImageIndex = 0;
            this.tvCats.Size = new System.Drawing.Size(128, 267);
            this.tvCats.TabIndex = 2;
            this.tvCats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvCats_MouseDown);
            this.tvCats.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvCats_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "people.gif");
            this.imageList1.Images.SetKeyName(1, "XDPFile_8.ico");
            this.imageList1.Images.SetKeyName(2, "FDFFile_8.ico");
            this.imageList1.Images.SetKeyName(3, "APIFile_8.ico");
            // 
            // lvPerson
            // 
            this.lvPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPerson.Location = new System.Drawing.Point(134, 53);
            this.lvPerson.Name = "lvPerson";
            this.lvPerson.Size = new System.Drawing.Size(331, 267);
            this.lvPerson.SmallImageList = this.imageList1;
            this.lvPerson.TabIndex = 3;
            this.lvPerson.UseCompatibleStateImageBehavior = false;
            this.lvPerson.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPerson_MouseDoubleClick);
            this.lvPerson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvPerson_MouseDown);
            this.lvPerson.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPerson_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangPerson,
            this.DeletePerson,
            this.移动到分组ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 70);
            // 
            // ChangPerson
            // 
            this.ChangPerson.Name = "ChangPerson";
            this.ChangPerson.Size = new System.Drawing.Size(139, 22);
            this.ChangPerson.Text = "修改联系人";
            this.ChangPerson.Click += new System.EventHandler(this.ChangPerson_Click);
            // 
            // DeletePerson
            // 
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(139, 22);
            this.DeletePerson.Text = "删除";
            this.DeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // 移动到分组ToolStripMenuItem
            // 
            this.移动到分组ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.尚未实现ToolStripMenuItem});
            this.移动到分组ToolStripMenuItem.Name = "移动到分组ToolStripMenuItem";
            this.移动到分组ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.移动到分组ToolStripMenuItem.Text = "移动到分组·";
            // 
            // 尚未实现ToolStripMenuItem
            // 
            this.尚未实现ToolStripMenuItem.Name = "尚未实现ToolStripMenuItem";
            this.尚未实现ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.尚未实现ToolStripMenuItem.Text = "尚未实现";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCatBTN,
            this.ChangName,
            this.AddPersonBTN,
            this.DeleteCats});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(137, 92);
            // 
            // AddCatBTN
            // 
            this.AddCatBTN.Name = "AddCatBTN";
            this.AddCatBTN.Size = new System.Drawing.Size(136, 22);
            this.AddCatBTN.Text = "添加分组";
            this.AddCatBTN.Click += new System.EventHandler(this.AddCatBTN_Click);
            // 
            // ChangName
            // 
            this.ChangName.Name = "ChangName";
            this.ChangName.Size = new System.Drawing.Size(136, 22);
            this.ChangName.Text = "修改分组";
            this.ChangName.Click += new System.EventHandler(this.ChangName_Click);
            // 
            // AddPersonBTN
            // 
            this.AddPersonBTN.Name = "AddPersonBTN";
            this.AddPersonBTN.Size = new System.Drawing.Size(136, 22);
            this.AddPersonBTN.Text = "添加联系人";
            this.AddPersonBTN.Click += new System.EventHandler(this.AddPersonBTN_Click);
            // 
            // DeleteCats
            // 
            this.DeleteCats.Name = "DeleteCats";
            this.DeleteCats.Size = new System.Drawing.Size(136, 22);
            this.DeleteCats.Text = "删除";
            this.DeleteCats.Click += new System.EventHandler(this.DeleteCats_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 322);
            this.Controls.Add(this.lvPerson);
            this.Controls.Add(this.tvCats);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPersons;
        private System.Windows.Forms.ToolStripMenuItem AddCats;
        private System.Windows.Forms.ToolStripMenuItem ChangUsers;
        private System.Windows.Forms.ToolStripMenuItem Exits;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem VersionBtn;
        private System.Windows.Forms.ToolStripMenuItem AboutAuthor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TreeView tvCats;
        private System.Windows.Forms.ListView lvPerson;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeletePerson;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 移动到分组ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ChangName;
        private System.Windows.Forms.ToolStripMenuItem DeleteCats;
        private System.Windows.Forms.ToolStripMenuItem AddPersonBTN;
        private System.Windows.Forms.ToolStripMenuItem ChangPerson;
        private System.Windows.Forms.ToolStripMenuItem AddCatBTN;
        private System.Windows.Forms.ToolStripMenuItem 尚未实现ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox SearchName;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox SearchTel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox SearchCel;
    }
}