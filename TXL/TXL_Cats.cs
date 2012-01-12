using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace TXL
{
    class TXL_Cats
    {
        //获取用户ID
        private int _userID;

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        //获取分组ID
        private int _catId;

        public int CatId
        {
            get { return _catId; }
            set { _catId = value; }
        }

        //获取分组名
        private string _catName;

        public string CatName
        {
            get { return _catName; }
            set { _catName = value; }
        }

        //01
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //02
        private string _tel;

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        //03
        private string _qq;

        public string QQ
        {
            get { return _qq; }
            set { _qq = value; }
        }

        //04
        private int _personID;

        public int PersonID
        {
            get { return _personID; }
            set { _personID = value; }
        }

        //得到最大的ID号

        public int GetMAXId()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select top 1 catid from TXL_Cats  where UserID=" + _userID + " order by catid desc";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
            if (myReader.Read())
                return int.Parse(myReader["catid"].ToString());
            else
                return -1;
        }
        //返回所有分类//增加了集合的操作/集合copyto array
        public ArrayList GetAllTXLCats()
        {

            ArrayList tmpList = new ArrayList();
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select * from TXL_Cats order by catname asc where UserID=" + _userID + "";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
            while (myReader.Read())
            {
                tmpList.Add(myReader["catname"].ToString());
            }
            myReader.Close();
            return tmpList;
        }

        //返回所有Cats记录的datareader
        public OleDbDataReader GetAllTXLCatsDR()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select * from TXL_Cats  where UserID=" + _userID + " order by catname asc";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
            return myReader;
        }


        //返回所有记录的dataset
        public DataSet GetAllTXLCatsDS()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select * from TXL_Cats  where UserID=" + _userID + " order by catname asc";

            return myObj.ExecuteSqlStrReturnDs();
        }

        //查询分组ID
        public int CatIds()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select CatId from TXL_Cats where CatName='" + _catName + "' and UserID="+_userID+"";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            if (myReader.Read())
            {
                return int.Parse(myReader["CatId"].ToString());
            }
            else
            {
                return -1;
            }

        }

        //添加分组
        public void Add()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "insert into TXL_Cats (UserID,catname) values(" + _userID + ",'" + _catName + "') ";
            myObj.ExecuteSqlStr();//确认插入数据

        }

        //编辑分组名称

        public void Update()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "update TXL_Cats set catname='" + _catName + "' where UserID=" + _userID + " and CatId="+_catId+"";
            myObj.ExecuteSqlStr();//删除记录
        }

        //删除分组

        public void Delete()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "delete from TXL_Cats where CatName='" + _catName.ToString() + "' and UserID=" + _userID + "";
            myObj.ExecuteSqlStr();//删除记录
        }

        //单条记录
        public void GetModel()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select * from TXL_Cats where catid='" + _catId.ToString() + "' and UserID=" + _userID + "";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
            if (myReader.Read())
            {
                _catName = myReader["catname"].ToString();
            }
            myReader.Close();
        }

        //获得catname的catid
        public int GetCatID()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select CatId from TXL_Cats where CatName='"+_catName+"' and UserID="+_userID+"";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            if (myReader.Read())
            {
                return int.Parse(myReader["CatId"].ToString());
            }
            else
            {
                return -1;
            }
            myReader.Close();
        }


        //删除联系人

        public void DeletePerson()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "delete TXL_Persons from TXL_Persons where PersonID=" + _personID + "";
            myObj.ExecuteSqlStr();//删除数据
        }

        //得到person的id

        public OleDbDataReader GetPersonID()
        {
            AccessDB myObj = new AccessDB();
            //myObj.SqlStr = "select PersonID from TXL_Persons where PersonName='" + _name + "'and PersonTel='" + _tel + "'and PersonQQ='" + _qq + "'and CatId=" + _catId + " and UserID=" + _userID + "";
            myObj.SqlStr = "select PersonID from TXL_Persons where PersonName='" + _name + "' and CatId=" + _catId + " and UserID=" + _userID + "";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
            return myReader;
        }

    }
}
