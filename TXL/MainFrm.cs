using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;//注意引用命名空间

namespace TXL
{
    public partial class MainFrm : Form
    {
        //传递参数
        LoginFrm loginfrm;

        public MainFrm(LoginFrm login)
        {
            loginfrm= login;
            InitializeComponent();
        }

        public int _userID;
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public int _personID;
        public int PersonID
        {
            get { return _personID; }
            set { _personID = value; }
        }

        public int _catID;
        public int CatID
        {
            get { return _catID; }
            set { _catID = value; }
        }

        public string _catName;
        public string CatName
        {
            get { return _catName; }
            set { _catName=value;}
        }

        public int _row;
        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }

        public string _personName;
        public string PersonName
        {
            get { return _personName; }
            set { _personName = value; }
        }

        public string _personTel;
        public string PersonTel
        {
            get { return _personTel; }
            set { _personTel = value; }
        }

        public string _personCel;
        public string PersonCel
        {
            get { return _personCel; }
            set { _personCel = value; }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //设置listview(lvPerson)的显示方式
            lvPerson.View = View.Details;
            //全选一行
            lvPerson.FullRowSelect = true;
            lvPerson.Columns.Add("姓名", 80);
            lvPerson.Columns.Add("手机号", 100);
            lvPerson.Columns.Add("QQ", 80);

            //用timer来触发事件
            this.timer1.Enabled = true;
        }

        //················利用timer触发事件·········
        private void timer1_Tick(object sender, EventArgs e)
        {
            TXL_Cats myObj = new TXL_Cats();

            tvCats.Nodes.Clear();

            _userID = loginfrm.UserID;
            myObj.UserID = UserID;

            OleDbDataReader myReader = myObj.GetAllTXLCatsDR();
            while (myReader.Read())
            {
                //先清除原先加载的，防止重复加载
                TreeNode myNode = new TreeNode(myReader["CatName"].ToString(), 1, 2);
                TXL_Cats myCat = new TXL_Cats();
                myCat.CatId = (int)myReader["CatId"];
                myCat.CatName = myReader["CatName"].ToString();
                myNode.Tag = myCat;
                tvCats.Nodes.Add(myNode);
            }
            myReader.Close();

            //注意修改状态！！
            this.timer1.Enabled = false;
        }

        //添加分组方法
        public void addCats()
        {
            AddCatsFrm addfrm = new AddCatsFrm(loginfrm, this);

            //判断是哪个按钮打开窗口
            addfrm.Btn(true);

            DialogResult myRe = addfrm.ShowDialog();
            if (myRe == DialogResult.OK)
            {
                this.timer1.Enabled = true;
            }
        }

        //新建分组
        private void AddCats_Click(object sender, EventArgs e)
        {
            addCats();
        }

        //右键添加分组
        private void AddCatBTN_Click(object sender, EventArgs e)
        {
            addCats();
        }

        //treeview判断右键 打开窗口修改分组名
        private void tvCats_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (tvCats.SelectedNode == null)
                {
                    tvCats.ContextMenuStrip = null;
                    //return;
                }
                else
                {
                    //treeview添加右键菜单
                    tvCats.ContextMenuStrip = contextMenuStrip2;

                    _catName = this.tvCats.SelectedNode.Text;
                    _userID = loginfrm.UserID;

                    TXL_Cats myObj = new TXL_Cats();
                    myObj.UserID = UserID;
                    myObj.CatName = CatName;
                    _catID = myObj.CatIds();
                }
            }
        }

        //修改分组名称
        private void ChangName_Click(object sender, EventArgs e)
        {
            AddCatsFrm addfrm = new AddCatsFrm(loginfrm, this);

            //判断是哪个按钮打开窗口
            addfrm.Btn(false);

            DialogResult myRe = addfrm.ShowDialog();
            if (myRe == DialogResult.OK)
            {
                this.timer1.Enabled = true;
            }
        }

        //删除分组
        private void DeleteCats_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dr;
            dr = MessageBox.Show(this, "删除分组会将分组内的联系人删除！确定要删除吗？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (dr)
            {
                case System.Windows.Forms.DialogResult.Yes:

                    TXL_Cats myObj = new TXL_Cats();
                    _catName = this.tvCats.SelectedNode.Text;
                    _userID = loginfrm.UserID;

                    myObj.UserID = UserID;
                    myObj.CatName = CatName;
                    myObj.Delete();

                    _catID = myObj.GetCatID();

                    TXL_Persons myPerson = new TXL_Persons();

                    myPerson.CatId = CatID;
                    myPerson.UserID = UserID;

                    MessageBox.Show("删除成功");

                    this.tvCats.SelectedNode.Remove();
                    break;
            }
        }


        //鼠标单击树节点发生
        private void tvCats_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TXL_Cats myObj = (TXL_Cats)e.Node.Tag;

            lvPerson.Items.Clear();

            TXL_Persons myPerson = new TXL_Persons();
            OleDbDataReader myReader = myPerson.GetAllTXLCatsDR(myObj.CatId);

            //得到catID
            _catID = (int)myObj.CatId;

            while (myReader.Read())
            {
                ListViewItem myItem = new ListViewItem();
                myItem.Text = myReader["PersonName"].ToString();
                myItem.ImageIndex = 0;
                myItem.SubItems.Add(myReader["PersonTel"].ToString());
                myItem.SubItems.Add(myReader["PersonQQ"].ToString());
                lvPerson.Items.Add(myItem);
            }
            myReader.Close();

        }

        //右击事件判断
        private void lvPerson_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TXL_Cats myObj = new TXL_Cats();
                myObj.UserID = loginfrm.UserID;
                if (lvPerson.SelectedIndices != null && lvPerson.SelectedIndices.Count > 0)
                {
                    //listview添加右键菜单
                    lvPerson.ContextMenuStrip = contextMenuStrip1;

                    ListView.SelectedIndexCollection c = lvPerson.SelectedIndices;
                    myObj.Name = lvPerson.Items[c[0]].Text;

                    //myObj.Name = lvPerson.Items[(int)lvPerson.SelectedIndices[1]].Text;
                    //myObj.Tel = lvPerson.Items[(int)lvPerson.SelectedIndices[0]].SubItems[1].Text;
                    //myObj.QQ = lvPerson.Items[(int)lvPerson.SelectedIndices[0]].SubItems[2].Text;
                    myObj.CatId = CatID;
                }

                OleDbDataReader myReader = myObj.GetPersonID();
                while (myReader.Read())
                {
                    //此段目的是获得PersonID！！
                    _personID = (int)myReader["PersonID"];
                }
                myReader.Close();
            }
        }

        //判断选中哪行
        private void lvPerson_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                _row = e.ItemIndex;
            }
        }

        //删除联系人
        private void DeletePerson_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult dr;
            dr = MessageBox.Show(this, "确定要删除吗？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (dr)
            {
                case System.Windows.Forms.DialogResult.Yes:

                    TXL_Cats myObj = new TXL_Cats();
                    myObj.PersonID = PersonID;
                    myObj.DeletePerson();
                    MessageBox.Show("删除成功");


                    //加上判断防止出现InvalidArgument=“0”的值对于“index”无效错误
                    if (lvPerson.SelectedIndices != null && lvPerson.SelectedIndices.Count > 0)
                    {
                        lvPerson.Items.Remove(lvPerson.Items[Row]);
                    }
                    break;
            }

        }

        //添加联系人方法
        public void addPerson()
        {
            AddPersons addperson = new AddPersons(loginfrm,this);

            //判断是哪个按钮打开窗口
            addperson.Btn(true);

            DialogResult myResponse = addperson.ShowDialog();

            if (myResponse == DialogResult.OK)
            {
                MessageBox.Show("请点击分组刷新联系人！ ");
            }
            else
            {
                addperson.Close();
            }
        }

        //添加联系人
        private void AddPersons_Click(object sender, EventArgs e)
        {
            addPerson();
        }

        //右键添加联系人
        private void AddPersonBTN_Click(object sender, EventArgs e)
        {
            addPerson();
        }


        //修改联系人方法
        public void ChangPer()
        {

            AddPersons addperson = new AddPersons(loginfrm, this);
            addperson.Btn(false);
            DialogResult myDi = addperson.ShowDialog();
            if (myDi == DialogResult.OK)
            {
                MessageBox.Show("请点击分组刷新联系人！ ");
            }
            else
            {
                addperson.Close();
            }
        }

        //右键修改联系人
        private void ChangPerson_Click(object sender, EventArgs e)
        {
            ChangPer();
        }

        //双击listview(lvperson)中的元素,修改联系人，传值不全···后来取消
        private void lvPerson_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("你选中了" + lvPerson.Items[(int)lvPerson.SelectedIndices[0]].Text + ",查看信息!");
            //ChangPer();
        }


        //搜索
        public void Searchs()
        {
            lvPerson.ContextMenuStrip = null;
            lvPerson.Items.Clear();

            _personName = SearchName.Text;
            _personTel = SearchTel.Text;
            _personCel = SearchCel.Text;
            _userID = loginfrm.UserID;

            TXL_Persons myPerson = new TXL_Persons();
            myPerson.UserID = UserID;
            myPerson.PersonName = PersonName;
            myPerson.Tel = PersonTel;
            myPerson.PersonCel = PersonCel;

            OleDbDataReader myReader = myPerson.Search();
            while (myReader.Read())
            {
                ListViewItem myItem = new ListViewItem();
                myItem.Text = myReader["PersonName"].ToString();
                myItem.ImageIndex = 0;
                myItem.SubItems.Add(myReader["PersonTel"].ToString());
                myItem.SubItems.Add(myReader["PersonQQ"].ToString());
                lvPerson.Items.Add(myItem);
            }
            myReader.Close();

        }

        //按姓名搜索
        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            Searchs();
        }

        //按手机搜索
        private void SearchTel_TextChanged(object sender, EventArgs e)
        {
            Searchs();
        }

        //按电话搜索
        private void SearchCel_TextChanged(object sender, EventArgs e)
        {
            Searchs();
        }
     
        //更换账号
        private void ChangUsers_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult drt;
            drt = MessageBox.Show(this, "你确定要更换用户！？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            switch (drt)
            {
                case DialogResult.OK:
                    string path = "\\TXL.exe";
                    Process process = new Process();
                    process.StartInfo.FileName = "TXL.exe";
                    process.StartInfo.WorkingDirectory = path;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    this.Close();
                    break;
                case DialogResult.Cancel:
                    return;
            }
        }

        //退出
        private void Exits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //版本
        private void VersionBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version1.0.0.0.0.0");
        }

        //关于作者
        private void AboutAuthor_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
