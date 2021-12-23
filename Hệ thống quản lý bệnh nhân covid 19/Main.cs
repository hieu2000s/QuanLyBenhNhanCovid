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
       
        public string ten;
        public Main()
        {
            InitializeComponent();
            
        }
        private void mnsten_Click(object sender, EventArgs e)
        {
            Đăng_nhập dn = new Đăng_nhập();
            dn.ShowDialog();
            
            //mnsten.Text = dn.txthoten;
            //MessageBox.Show(ten);
            if(dn.loginstatus==1)
            {
                mnsten.Text = dn.txthoten;
            }
            if (dn.accessstatus == 0)
            {
                mnsqlbn.Visible = false;
                mnsqllsdt.Visible = false;
                mnsqlkvdt.Visible = true;
                mnsqlpdt.Visible = true;
                mnsqlndt.Visible = true;
                mnsqltk.Visible = true;
            }
            else
            {
                mnsqlbn.Visible = true;
                mnsqllsdt.Visible = true;
                mnsqlkvdt.Visible = false;
                mnsqlpdt.Visible = false;
                mnsqlndt.Visible = false;
                mnsqltk.Visible = false;

            }
        }

        private void mnsdx_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn đăng xuất không", "logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                Đăng_nhập dn = new Đăng_nhập();
                dn.loginstatus = 0;
                mnsdx.Visible = false;
                //mnulogin.Text = "Đăng nhập";
                mnsql.Enabled = false;
            }
        }

        private void mnsqlkvdt_Click(object sender, EventArgs e)
        {
            Quản_lý_khu_vực_điều_trị kvdt = new Quản_lý_khu_vực_điều_trị();
            kvdt.ShowDialog();
        }

        private void mnqlpdt_Click(object sender, EventArgs e)
        {
            Quản_lý_phòng_điều_trị pdt = new Quản_lý_phòng_điều_trị();
            pdt.ShowDialog();
        }

        private void mnsqlndt_Click(object sender, EventArgs e)
        {
            Quản_lý_người_điều_trị ndt = new Quản_lý_người_điều_trị();
            ndt.ShowDialog();
        }

        private void mnsqlbn_Click(object sender, EventArgs e)
        {
            Quản_lý_bệnh_nhân bn = new Quản_lý_bệnh_nhân();
            bn.ShowDialog();
        }

        private void mnsqllsdt_Click(object sender, EventArgs e)
        {
            Quản_lý_lịch_sử_điều_trị lsdt = new Quản_lý_lịch_sử_điều_trị();
            lsdt.ShowDialog();

        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void mnsqltk_Click(object sender, EventArgs e)
        {
            Quản_lý_tài_khoản tk = new Quản_lý_tài_khoản();
            tk.ShowDialog();
        }
    }
}
