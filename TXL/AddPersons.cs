using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TXL
{
    public partial class AddPersons : Form
    {

        LoginFrm loginfrm;
        MainFrm mainfrm;

        //判断是哪个按钮按下
        private bool whichBtn;

        public AddPersons(LoginFrm login,MainFrm mainf)
        {
            loginfrm = login;
            mainfrm = mainf;
            InitializeComponent();
        }

        public int _personId;
        public int PersonId
        {
            get { return _personId; }
            set { _personId = value; }
        }

        public int _userID;
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
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

        public string _personQQ;
        public string PersonQQ
        {
            get { return _personQQ; }
            set { _personQQ = value; }
        }

        public string _cats;
        public string Cats
        {
            get { return _cats; }
            set { _cats = value; }
        }

        public int _catId;
        public int CatId
        {
            get { return _catId; }
            set { _catId = value; }
        }

        public string _personAddress;
        public string PersonAddress
        {
            get { return _personAddress; }
            set { _personAddress = value; }
        }

        public string _remark;
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
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

        private void AddPersons_Load(object sender, EventArgs e)
        {
            //加载分类
            TXL_Cats myCats = new TXL_Cats();

            _userID = loginfrm.UserID;
            myCats.UserID = UserID;

            CatsText.DisplayMember = "CatName";
            CatsText.ValueMember = "CatId";
            CatsText.DataSource=myCats.GetAllTXLCatsDS().Tables[0];

            if (whichBtn == true)
            {
                SuerBtn.Text = "添加联系人";
                this.Text = "添加联系人";
            }
            else
            {
                this.Text = "修改联系人";
                SuerBtn.Text = "修改联系人";

                //在文本框中赋值
                TXL_Persons myPerson = new TXL_Persons();

                _personId = mainfrm.PersonID;
                myPerson.PersonId = PersonId;

                OleDbDataReader myReader = myPerson.GetAllPerson();
                while (myReader.Read())
                {
                    _personName = myReader["PersonName"].ToString();
                    _catId = int.Parse(myReader["CatId"].ToString());
                    _personTel=myReader["PersonTel"].ToString();
                    _personCel=myReader["PersonCel"].ToString();
                    _personQQ=myReader["PersonQQ"].ToString();
                    _personAddress=myReader["PersonAddress"].ToString();
                    _remark = myReader["Remark"].ToString();

                    myPerson.CatId = CatId;
                    _cats = myPerson.GetCatName();

                    UserNameText.Text = PersonName;
                    CatsText.Text = Cats;
                    QQText.Text = PersonQQ;
                    PersonTelText.Text = PersonTel;
                    PersonCellText.Text = PersonCel;
                    AddressText.Text = PersonAddress;
                    RemarkText.Text = Remark;
                }


            }
        }

        private void SuerBtn_Click(object sender, EventArgs e)
        {
            if (whichBtn == true)
            {
                //获取CatID号
                int _catId = (int)CatsText.SelectedValue;

                TXL_Persons myObj = new TXL_Persons();

                _personName = UserNameText.Text;
                _personTel = PersonTelText.Text;
                _personQQ = QQText.Text;
                _personAddress = AddressText.Text;

                myObj.UserID = UserID;
                myObj.Name = PersonName;
                myObj.Tel = PersonTel;
                myObj.QQ = PersonQQ;
                myObj.Address = PersonAddress;
                myObj.CatId = _catId;

                myObj.AddPersons();

                MessageBox.Show("添加成功");
            }
            else
            {
                TXL_Cats myCats = new TXL_Cats();

                _cats = CatsText.Text;
                _userID = loginfrm.UserID;

                myCats.CatName = Cats;
                myCats.UserID = UserID;

                _catId = myCats.CatIds();

                TXL_Persons myPerson = new TXL_Persons();

                _personId = mainfrm.PersonID;
                _personName = UserNameText.Text;
                _personQQ = QQText.Text;
                _personTel = PersonTelText.Text;
                _personCel = PersonCellText.Text;
                _personAddress = AddressText.Text;
                _remark = RemarkText.Text;


                myPerson.PersonId = PersonId;
                myPerson.CatId = CatId;
                myPerson.PersonName = PersonName;
                myPerson.QQ = PersonQQ;
                myPerson.Tel = PersonTel;
                myPerson.PersonCel = PersonCel;
                myPerson.Address = PersonAddress;
                myPerson.Remark = Remark;

                myPerson.ChangPerson();

                MessageBox.Show("修改成功！");

            }

        }

        //取消
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
