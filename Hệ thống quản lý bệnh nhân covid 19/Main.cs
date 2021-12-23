using Hệ_thống_quản_lý_bệnh_nhân_covid_19.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    public partial class Main : Form
    {
        UserLoginHandler handler = new UserLoginHandler();
       
        public string ten;
        public Main()
        {
            InitializeComponent();
        }
        private void mnsten_Click(object sender, EventArgs e)
        {
            Đăng_nhập dn = new Đăng_nhập();
            dn.ShowDialog();
        }

        private void mnsdx_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn đăng xuất không", "logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                if (handler.UserData != null) 
                { 
                    handler.Logout();
                    this.Hide();
                    Đăng_nhập login = new Đăng_nhập();
                    login.ShowDialog();
                }
            }
        }

        private void mnsqlkvdt_Click(object sender, EventArgs e)
        {
            Quản_lý_khu_vực_điều_trị kvdt = new Quản_lý_khu_vực_điều_trị();
            this.Hide();
            kvdt.ShowDialog();
        }

        private void mnqlpdt_Click(object sender, EventArgs e)
        {
            Quản_lý_phòng_điều_trị pdt = new Quản_lý_phòng_điều_trị();
            this.Hide();
            pdt.ShowDialog();
        }

        private void mnsqlndt_Click(object sender, EventArgs e)
        {
            Quản_lý_người_điều_trị ndt = new Quản_lý_người_điều_trị();
            this.Hide();
            ndt.ShowDialog();
        }

        private void mnsqlbn_Click(object sender, EventArgs e)
        {
            Quản_lý_bệnh_nhân bn = new Quản_lý_bệnh_nhân();
            this.Hide();
            bn.ShowDialog();
        }

        private void mnsqllsdt_Click(object sender, EventArgs e)
        {
            Quản_lý_lịch_sử_điều_trị lsdt = new Quản_lý_lịch_sử_điều_trị();
            this.Hide();
            lsdt.ShowDialog();

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void mnsqltk_Click(object sender, EventArgs e)
        {
            if (handler.UserData.Quyen ?? false)
            {
                Quản_lý_tài_khoản tk = new Quản_lý_tài_khoản();
                this.Hide();
                tk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
