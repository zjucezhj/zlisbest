using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TXL
{
    public partial class AddCatsFrm : Form
    {
        //传递UserID
        LoginFrm loginfrm;
        //传递CatName
        MainFrm mainfrm;

        //判断是哪个按钮
        private bool whichBtn;

        public AddCatsFrm(LoginFrm login,MainFrm mainfr)
        {
            loginfrm = login;
            mainfrm = mainfr;
            InitializeComponent();
        }

        public string _catName;
        public string CatName
        {
            get { return _catName; }
            set { _catName = value; }
        }

        public int _userID;
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public int _catID;
        public int CatID
        {
            get { return _catID; }
            set { _catID = value; }
        }


        //自定义函数来判断是哪个按钮打开窗口
        public void Btn(bool whosBtn)
        {
            if (whosBtn == true)
            {
                whichBtn = true;
            }
            else
            {
                whichBtn = false;
            }
        }

        private void AddCatsFrm_Load(object sender, EventArgs e)
        {
            if (whichBtn == true)
            {
                AddCatsBtn.Text = "添加分组";
                this.Text = "添加分组";
            }
            else
            {
                CatNameText.Text = mainfrm.CatName;
                this.Text = "修改分组";
                AddCatsBtn.Text = "修改分组名称";
            }
        }

        ////添加和修改不能重复！
        //public bool Check()
        //{

        //}

        //添加分组
        private void AddCatsBtn_Click(object sender, EventArgs e)
        {
            TXL_Cats myObj = new TXL_Cats();
            _userID = loginfrm.UserID;
            myObj.UserID = UserID;
            myObj.CatName = CatNameText.Text;

            if (whichBtn == true)
            {
                myObj.Add();
                MessageBox.Show("添加成功！");
            }
            else
            {
                _catID = mainfrm.CatID;
                myObj.CatId = CatID;
                myObj.Update();
                MessageBox.Show("更改成功！");
            }
        }

        //取消
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
