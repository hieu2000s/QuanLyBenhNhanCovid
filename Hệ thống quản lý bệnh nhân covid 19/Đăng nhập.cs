using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    public partial class Đăng_nhập : Form
    {
        public int loginstatus;
        public string txthoten;
        public int accessstatus;
        public Đăng_nhập()
        {
            InitializeComponent();
            loginstatus = 0;
        }
        string chuoiketnoi = @"Data Source=localhost,1433;User ID=sa;Password=1234567890;Database=QuanLyCovid";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        private void btndn_Click(object sender, EventArgs e)
        {
            if (txbtdn.Text.Trim() == "" || txbmk.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ tài khoản hoặc mật khẩu", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ketnoi.Open();
                sql = @"select * from Covid.Account";
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
                i = 0; string taikhoan, matkhau; bool quyen;
                while (docdulieu.Read())
                {

                    taikhoan = docdulieu[1].ToString();
                    matkhau = docdulieu[2].ToString();
                    quyen = bool.Parse(docdulieu[3].ToString());
                    if (txbtdn.Text.Trim() == taikhoan && txbmk.Text.Trim() != matkhau)
                    {
                        loginstatus = 0;
                    }
                    else if (txbtdn.Text.Trim() != taikhoan)
                    {
                        loginstatus = 0;
                    }
                    else if (txbtdn.Text.Trim() == taikhoan && txbmk.Text.Trim() == matkhau)
                    {
                        loginstatus = 1;
                        //txttaikhoan = document["Tendangnhap"].AsString;
                        txthoten = docdulieu[4].ToString();
                       
                        if (quyen == true) { accessstatus = 0; }
                        else { accessstatus = 1; }
                        break;
                    }
                    i++;
                }
                ketnoi.Close();
                if (loginstatus == 0)
                {
                    MessageBox.Show("Tài khoản đăng nhập hoặc mật khẩu không đúng", "Đăng nhập lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (loginstatus == 1)
                {
                    MessageBox.Show("Đăng nhập thành công", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
           
        }

        private void Đăng_nhập_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }
    }
}
