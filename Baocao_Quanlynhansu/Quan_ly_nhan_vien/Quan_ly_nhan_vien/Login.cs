using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB;

namespace Quan_ly_nhan_vien
{
    public partial class Login : Form
    {
        public int loginstatus;
        public string txttaikhoan;
        public int accessstatus;
        public string manv;
        public Login()
        {
            InitializeComponent();
            loginstatus = 0;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            

            if (txbuser.Text.Trim() == "" || txbpass.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ các phần", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MongoClient client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Le_Nguyen_Hung");
                var collection = database.GetCollection<BsonDocument>("Tai_khoan");
                var results = collection.Find(new BsonDocument()).ToList();
                foreach (BsonDocument document in results)
                {
                    string user = document["Tendangnhap"].AsString;
                    string pass = document["Matkhau"].AsString;
                    string p = document["Machucvu"].AsString;
                               
                    if (txbuser.Text.Trim() == user && txbpass.Text.Trim() != pass)
                    {
                        loginstatus = 0;
                    }
                    else if (txbuser.Text.Trim() != user)
                    {
                        loginstatus = 0;
                    }
                    else if (txbuser.Text.Trim() == user && txbpass.Text.Trim() == pass)
                    {
                       loginstatus = 1;
                       txttaikhoan = document["Tendangnhap"].AsString;
                        manv= document["Manhanvien"].AsString;
                        if (p == "NSTP1") { accessstatus = 1; }
                        else if (p == "TCTP1") { accessstatus = 2; }
                        else if (p == "QL") { accessstatus = 3; }
                        break;
                    }  
                }
                if (loginstatus == 0)
                {
                    MessageBox.Show("Tài khoản đăng nhập hoặc mật khẩu không đúng", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (loginstatus == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var name = collection.Find(new BsonDocument()).ToList();
                    this.Close();
                }
            }
        }
        
    }
}

        