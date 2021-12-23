using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_nhan_vien
{
    public partial class Main : Form
    {
        public string MNV;
        public Main()
        {
            InitializeComponent();
            
        }
       
        private void mnulogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();

            if (lg.loginstatus == 1)
            {
                mnulogin.Text = lg.manv;
               // MNV = mnulogin.Text;
                MNV = mnulogin.Text;

                mnulogout.Visible = true;
                mnuql.Enabled = true;
            }
            if (lg.accessstatus == 1)
            {
                mnuqll.Visible = false;
                mnuqltk.Visible = false;
                mnuqltd.Visible = false;
                mnuqltd.Visible = false;
                mnuqltd.Visible = false;
                mnuqltd.Visible = false;
                mnuqlnv.Visible = true;

            }
            else if (lg.accessstatus == 2)
            {
                mnuqlnv.Visible = false;
                mnuqll.Visible = false;
                mnuqltd.Visible = false;
                mnuqlp.Visible = false;
                mnuqlcv.Visible = false;
                mnuqlhd.Visible = false;
                mnuqltk.Visible = false;
            }
            else if (lg.accessstatus == 3)
            {
                mnuqltd.Visible = false;
                mnuqlp.Visible = false;
                mnuqlcv.Visible = false;
                mnuqlhd.Visible = false;
                mnuqltk.Visible = false;
                mnuqll.Visible = false;
                mnuqlnv.Visible = false;
            }
            MNV = mnulogin.Text;
        }

        private void mnulogout_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn đăng xuất không", "logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.loginstatus = 0;
                mnulogout.Visible = false;
                mnulogin.Text = "Đăng nhập";
                mnuql.Enabled = false;
            }
        }

        private void mnuqlcv_Click(object sender, EventArgs e)
        {
            Chuc_vu cv = new Chuc_vu();
            cv.ShowDialog();
        }
        private void mnuqlhd_Click(object sender, EventArgs e)
        {
            Hop_dong hd = new Hop_dong();
            hd.ShowDialog();
        }
        private void mnuqll_Click(object sender, EventArgs e)
        {
           Luong cv = new Luong();
            cv.ShowDialog();
        }
        private void mnuqlnv_Click(object sender, EventArgs e)
        {
            Nhan_vien l = new Nhan_vien();
            //l.MdiParent = this;
            l.ShowDialog();
        }
        private void mnuqlp_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.ShowDialog();
        }
        private void mnuqltk_Click(object sender, EventArgs e)
        {
            Tai_khoan tk = new Tai_khoan();
            tk.ShowDialog();
        }

        private void mnuqltd_Click(object sender, EventArgs e)
        {
            Trinh_do td = new Trinh_do();
            td.ShowDialog();
        }

        private void mnuShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MNV);
            shownv nv = new shownv(MNV);   
            nv.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
