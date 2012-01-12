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
    public partial class SafeFrm : Form
    {
        public SafeFrm()
        {
            InitializeComponent();
        }

        public string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
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

        //失去焦点时查询安全问题
        private void textBox1_Leave(object sender, EventArgs e)
        {
            TXL_Safe mySafe = new TXL_Safe();
            _userName = UserNameText.Text;
            mySafe.UserName = UserName;
            QuestionLable.Text = mySafe.GetQuestion();
        }

        //点击找回密码
        private void FindPass_Click(object sender, EventArgs e)
        {
            TXL_Safe mySafe = new TXL_Safe();

            _userName = UserNameText.Text;
            _question = QuestionLable.Text;
            _answer = AnswerText.Text;

            mySafe.UserName = UserName;
            mySafe.Question = Question;
            mySafe.Answer = Answer;

            if (mySafe.safe() == true)
            {
                MessageBox.Show("您的密码是 "+mySafe.Keys()+" 请牢记！");
                this.Close();
            }
            else
            {
                MessageBox.Show("回答错误！");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
