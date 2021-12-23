using Hệ_thống_quản_lý_bệnh_nhân_covid_19.Handlers;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    public partial class Đăng_nhập : Form
    {
        QuanLyCovidModels db = new QuanLyCovidModels();
        UserLoginHandler handler = new UserLoginHandler();
        public Đăng_nhập()
        {
            InitializeComponent();
        }
        
        private void btndn_Click(object sender, EventArgs e)
        {
            bool error = false;
            var username = txbtdn.Text;
            var pass = txbmk.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(pass))
                error = true;
            Account account = db.Accounts.FirstOrDefault(x => x.TenDangNhap.Equals(username) && x.MatKhau.Equals(pass));
            if (!error && account == null) error = true;
            if (error)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                handler.Login(account);
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
            }
           
        }

        private void Đăng_nhập_Load(object sender, EventArgs e)
        {
        }

        private void Đăng_nhập_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát??", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
