using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
namespace TXL
{
    class TXL_Persons
    {
        private int _personId;

        public int PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }
        private string _personName;

        public string PersonName
        {
            get { return _personName; }
            set { _personName = value; }
        }

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

        private string _personCel;
        public string PersonCel
        {
            get { return _personCel; }
            set { _personCel = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _remark;
        public string Remark
        {
            get { return _remark; }
            set { _remark=value;}
        }

        //返回所有记录的datareader
        public OleDbDataReader GetAllTXLCatsDR(int catId)
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select * from TXL_Persons where catId=" + catId.ToString() + " order by PersonName asc";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();//返回记录集
            return myReader;
        }

        //添加联系人
        public void AddPersons()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "insert into TXL_Persons (UserID,PersonName,PersonTel,PersonCel,PersonAddress,PersonQQ,CatId,Remark) values(" + _userID + ",'" + _name + "','" + _tel + "','"+_personCel+"','"+_address+"','" + _qq + "','" + _catId + "','"+_remark+"')";
            myObj.ExecuteSqlStr();//确认插入数据

        }

        //删除分组时删除分组内联系人
        public void Dele()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "delete [TXL_Person] where UserID="+_userID+" and CatId="+_catId+"";
            myObj.ExecuteSqlStr();
        }

        //由PersonId的到其他字段值
        public OleDbDataReader GetAllPerson()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select * from TXL_Persons where PersonId=" + _personId + "";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            return myReader;
        }

        //由CatId得到CatName的值
        public string GetCatName()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "select CatName from TXL_Cats where CatId="+_catId+"";
            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            if (myReader.Read())
            {
                return myReader["CatName"].ToString();
            }
            else
            {
                return null;
            }
        }

        //修改TXL_Persons
        public void ChangPerson()
        {
            AccessDB myObj = new AccessDB();
            myObj.SqlStr = "update [TXL_Persons] set PersonName='"+_personName+"',PersonTel='"+_tel+"',PersonCel='"+_personCel+"',PersonAddress='"+_address+"',PersonQQ='"+_qq+"',CatId="+_catId+",Remark='"+_remark+"' where PersonId="+_personId+"";
            myObj.ExecuteSqlStr();
        }

        //搜索联系人
        public OleDbDataReader Search()
        {
            AccessDB myObj = new AccessDB();

            //以下查询没实现···
            myObj.SqlStr = "select * from TXL_Persons where ((PersonName like '" + _personName + "*' and PersonTel like '" + _tel + "*' and PersonCel like '" + _personCel + "*') " +
                "or(PersonName like '" + _personName + "*' and PersonTel like '" + _tel + "*' and PersonCel is null)" +
                "or(PersonName like '" + _personName + "*'and PersonTel is null and PersonCel like '" + _personCel + "*')" +
                "or(PersonName is null and PersonTel like '" + _tel + "*' and PersonCel like '" + _personCel + "*')" +
                "or(PersonName like '" + _personName + "*' and PersonTel is null and PersonCel is null) " +
                "or(PersonName is null and PersonTel like '" + _tel + "*' and PersonCel is null)" +
                "or(PersonName is null and PersonTel is null and PersonCel like '" + _personCel + "*'))" +
                "and UserID=" + _userID + "";

            OleDbDataReader myReader = myObj.ExecuteSqlStrReturnDr();
            return myReader;

        }
    }
}
