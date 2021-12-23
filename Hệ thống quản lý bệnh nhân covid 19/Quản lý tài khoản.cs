using Hệ_thống_quản_lý_bệnh_nhân_covid_19.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    public partial class Quản_lý_tài_khoản : Form
    {
        QuanLyCovidModels db = new QuanLyCovidModels();
        public Quản_lý_tài_khoản()
        {
            InitializeComponent();
        }
        
        private void Quản_lý_tài_khoản_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void hienthi(List<Account> list = null)
        {
            lv.Items.Clear();
            list = list ?? db.Accounts.ToList();
            for (var i = 0; i < list.Count(); i++)
            {
                lv.Items.Add(new ListViewItem(new string[] {
                    (i + 1).ToString(),
                    list.ElementAt(i).TenDangNhap.ToString(),
                    list.ElementAt(i).MatKhau,
                    (list.ElementAt(i).Quyen ?? false) ? "Quản trị viên":"Người điều trị",
                    list.ElementAt(i).TenNguoiNhap.ToString(),
                    list.ElementAt(i).CMND.ToString(),
                    list.ElementAt(i).Sdt.ToString(),
                }));
            };
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            foreach (var el in this.groupBox1.Controls)
            {
                if (el is TextBox)
                {
                    TextBox tb = el as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text) && !tb.Name.Equals("txID"))
                        hasError = true;
                }
            }
            
            if (!hasError)
            {
                try
                {
                    var Account = new Account();
                    Account.TenDangNhap = txbtdn.Text;
                    Account.Quyen = rdbndt.Checked ? true : false;
                    Account.MatKhau = txbmk.Text;
                    Account.TenNguoiNhap = txbhoten.Text;
                    Account.Sdt = int.Parse(txbsdt.Text);
                    Account.CMND = int.Parse(txbcmnd.Text);
                    db.Accounts.Add(Account);
                    db.SaveChanges();
                    hienthi();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi xảy ra", "Định dạng nhập vào không chính xác.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin", "Bạn nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var id = lv.SelectedItems[0].SubItems[1].Text;
            var Accout = db.Accounts.FirstOrDefault(x => x.TenDangNhap.Equals(id.ToString()));
            bool hasError = false;
            foreach (var el in this.groupBox1.Controls)
            {
                if (el is TextBox)
                {
                    TextBox tb = el as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text) && !tb.Name.Equals("txID"))
                        hasError = true;
                }
            }
            if (!hasError)
            {
                try
                {
                    Accout.Quyen = rdbndt.Checked ? false : true;
                    Accout.TenDangNhap =txbtdn.Text;
                    Accout.TenNguoiNhap = txbhoten.Text;
                    Accout.CMND = int.Parse(txbcmnd.Text);
                    Accout.MatKhau = txbmk.Text;
                    Accout.Sdt = int.Parse(txbsdt.Text);
                    db.Entry<Account>(Accout).State = (System.Data.Entity.EntityState)EntityState.Modified;
                    db.SaveChanges();
                    hienthi();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi xảy ra", "Định dạng nhập vào không chính xác.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin", "Bạn nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
            {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xóa???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                var id = lv.SelectedItems[0].SubItems[1].Text;
                var accout = db.Accounts.FirstOrDefault(x=>x.TenDangNhap.Equals(id.ToString()));
                db.Accounts.Remove(accout);
                db.SaveChanges();
                hienthi();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void rdbqtv_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rdbndt_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void btnhien_Click(object sender, EventArgs e)
        {
            hienthi();
        }
        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbtdn.Text = lvi.SubItems[1].Text;
                txbmk.Text = lvi.SubItems[2].Text;
                if (lv.SelectedItems[0].SubItems[3].Text == "Người điều trị")
                {
                    rdbndt.Checked = true;
                }
                else rdbqtv.Checked = true;
                txbhoten.Text = lvi.SubItems[4].Text;
                txbcmnd.Text = lvi.SubItems[5].Text;
                txbsdt.Text = lvi.SubItems[6].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }
        private void mns1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Quản_lý_tài_khoản_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
