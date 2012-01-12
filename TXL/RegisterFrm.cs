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
    public partial class RegisterFrm : Form
    {
        public RegisterFrm()
        {
            InitializeComponent();
        }

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

        public string _question;
        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }

        public string _answer;
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        //注册
        private void SuerBtn_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text.Length != 0 && PassText.Text.Length != 0 && QuestionText.Text.Length != 0 && PassText.Text.Length != 0)
            {
                _userName = UserNameText.Text;
                _pass = PassText.Text;
                _question = QuestionText.Text;
                _answer = AnswerText.Text;

                TXL_Users myUsers = new TXL_Users();
                myUsers.UserName = UserName;
                myUsers.Pass = Pass;

                TXL_Safe mySafe = new TXL_Safe();
                mySafe.UserName = UserName;
                mySafe.Question = Question;
                mySafe.Answer = Answer;

                if (myUsers.exit() == false)
                {
                    myUsers.Add();
                    mySafe.Add();
                    MessageBox.Show("注册成功，您可你是用本软件了！");
                    //注册完成关闭此窗口
                    this.Close();
                }
                else
                {
                    MessageBox.Show("账号已存在!!");
                }
            }
            else
            {
                MessageBox.Show("任何一项都不能为空请注意填写(ˇˍˇ）！");
            }
            

        }

        //检测账号是否被注册
        private void CheckUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (UserNameText.Text.Length!=0)
            {
                _userName = UserNameText.Text;

                TXL_Users myUsers = new TXL_Users();
                myUsers.UserName = UserName;

                if (myUsers.exit() == true)
                {
                    MessageBox.Show("对不起此账号已存在,请您改用其他账号！");
                }
                else
                {
                    MessageBox.Show("恭喜你，此账号可用");
                }
            }
            else
            {
                MessageBox.Show("账号不能为空！");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
