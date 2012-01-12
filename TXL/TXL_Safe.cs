using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.OleDb;
namespace TXL
{
    class TXL_Safe
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _question;
        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }

        private string _answer;
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }


        //注册账号
        public void Add()
        {
             AccessDB myObj = new AccessDB();
            myObj.SqlStr = "insert into TXL_Safe (UserName,Question,Answer) values('" + _userName + "','" + _question + "','" + _answer + "') ";
            myObj.ExecuteSqlStr();//确认插入数据
        }


        //根据账号检测安全问题
        //public ArrayList GetQuestion()
        //{
        //    ArrayList tmpList = new ArrayList();
        //    AccessDB myObj = new AccessDB();
        //    myObj.SqlStr = "select Question from TXL_Safe where UserName='"+_userName+"'";
        //    OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
        //    while (myReader.Read())
        //    {
        //        tmpList.Add(myReader["Question"].ToString());
        //    }
        //    myReader.Close();
        //    return tmpList;
        //}

        public string GetQuestion()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select * from TXL_Safe where UserName='" + _userName + "'";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
            if (myReader.Read())
                return myReader["Question"].ToString();
            else
                return "账号不存在";
        }


        //找回密码
        public bool safe()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select count(*) from TXL_Safe where UserName='" + _userName + "' and Question='" + _question + "' and Answer='" + _answer + "'";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            if (myReader.Read())
            {
                if (myReader[0].ToString() == "1")
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        //显示密码
        public string Keys()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select Pass from TXL_Users where UserName='"+_userName+"'";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            if (myReader.Read())
            {
                return myReader["Pass"].ToString();
            }
            else
            {
                return "未知错误！";
            }
        }
    }
}
