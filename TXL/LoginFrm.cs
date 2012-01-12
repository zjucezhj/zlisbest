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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        //传递UserID
        public int UserID;

        private void LoginFrm_Activated(object sender, EventArgs e)
        {
            //界面加载时账号框获取焦点
            this.UserNameText.Focus();
        }

        //用来判断加载主窗体
        public bool eachfrm = false;

        public string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string _pass;
        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }


        //退出按钮
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //登录按钮
        private void Login_Click(object sender, EventArgs e)
        {
            
            _userName = UserNameText.Text;
            _pass = PassText.Text;
            TXL_Users myObject = new TXL_Users();
            myObject.UserName = UserName;
            myObject.Pass = Pass;
            if (myObject.login() == true)
            {
                eachfrm = true;
                UserID = myObject.UserId();
                this.Close();
            }
            else
            {
                MessageBox.Show("账号或密码错误！");
            }
        }

        //注册账号
        private void Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterFrm().ShowDialog();
        }

        //忘记密码
        private void Forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SafeFrm().ShowDialog();
        }
    }
}
