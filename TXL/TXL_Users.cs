using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace TXL
{
    class TXL_Users
    {
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _pass;
        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        private int _userID;
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        //获取账号ID
        public int UserId()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select UserID from TXL_Users where UserName='"+_userName+"'";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            if (myReader.Read())
                return int.Parse(myReader["UserID"].ToString());
            else
                return -1;
        }

        //检测账号是否存在
        public bool exit()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select UserName from TXL_Users where UserName='"+_userName+"'";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            if (myReader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //添加账号
        public void Add()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "insert into TXL_Users(UserName,Pass) values('" + _userName + "','" + _pass + "')";
            myObj.ExecuteSqlStr();
        }

        public bool login()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select * from TXL_Users where UserName='"+_userName+"' and Pass='"+_pass+"'";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
            if (myReader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
