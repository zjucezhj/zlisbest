using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//1引入操作Access数据库名称空间
using System.Data.OleDb;
using System.Configuration;
using System.Collections;

namespace TXL
{
    public class AccessDB
    {
        private string _connectionString;//3连接串

        private string _sqlStr;//4要执行的SQL语句

        public string SqlStr
        {
            get { return _sqlStr; }
            set { _sqlStr = value; }
        }

        public AccessDB()//5
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        //6执行没有返回值的SQL语句
        public void ExecuteSqlStr()
        {
            OleDbConnection _conn = new OleDbConnection(_connectionString);
            _conn.Open();

            OleDbCommand _com = new OleDbCommand(_sqlStr, _conn);

            _com.ExecuteNonQuery();

            _conn.Close();//关闭连接

        }

        //执行返回记录集的SQL语句
        public OleDbDataReader ExecuteSqlStrReturnDr()
        {
            OleDbConnection _conn = new OleDbConnection(_connectionString);
            _conn.Open();

            OleDbCommand _com = new OleDbCommand(_sqlStr, _conn);
            return _com.ExecuteReader(CommandBehavior.CloseConnection);//执行完语句以后,连接自动关闭
        }


        //执行返回Datset的SQL语句
        public DataSet ExecuteSqlStrReturnDs()
        {
            OleDbConnection _conn = new OleDbConnection(_connectionString);

            OleDbDataAdapter _Da = new OleDbDataAdapter(_sqlStr, _conn);

            DataSet _Ds = new DataSet();

            _Da.Fill(_Ds);

            return _Ds;

        }
    }
}
