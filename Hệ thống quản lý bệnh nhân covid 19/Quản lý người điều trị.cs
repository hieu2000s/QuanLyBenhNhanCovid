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
    public partial class Quản_lý_người_điều_trị : Form
    {
        QuanLyCovidModels db = new QuanLyCovidModels();
        public Quản_lý_người_điều_trị()
        {
            InitializeComponent();
        }

        private void Quản_lý_người_điều_trị_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi(List<NguoiDieuTri> list = null)
        {
            lv.Items.Clear();
            list = list ?? db.NguoiDieuTris.ToList();
            for (var i = 0; i < list.Count(); i++)
            {
                lv.Items.Add(new ListViewItem(new string[] {
                    (i + 1).ToString(),
                    list.ElementAt(i).IDNguoiDieuTri.ToString(),
                    list.ElementAt(i).TenNguoiDieuTri,
                    (list.ElementAt(i).GioiTinh ?? false) ? "Nam":"Nu",
                    list.ElementAt(i).NgaySinh.ToString(),
                    list.ElementAt(i).CMND.ToString(),
                    list.ElementAt(i).DiaChi,
                    list.ElementAt(i).SDT.ToString(),

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
                    if (string.IsNullOrWhiteSpace(tb.Text))
                        hasError = true;
                }
            }

            if (!hasError)
            {
                try
                {
                    var nguoiDieuTri = new NguoiDieuTri();
                    nguoiDieuTri.IDNguoiDieuTri = int.Parse(txbMndt.Text);
                    nguoiDieuTri.GioiTinh = rdbGtnam.Checked ? true : false;
                    nguoiDieuTri.NgaySinh = DateTime.Parse(txbNs.Text);
                    nguoiDieuTri.TenNguoiDieuTri = txbTndt.Text;
                    nguoiDieuTri.SDT = int.Parse(txbSdt.Text);
                    nguoiDieuTri.DiaChi = txbDc.Text;
                    nguoiDieuTri.CMND = int.Parse(txbCmnd.Text);
                    db.NguoiDieuTris.Add(nguoiDieuTri);
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
            var nguoiDieuTri = db.NguoiDieuTris.Find(int.Parse(txbMndt.Text));
            bool hasError = false;
            foreach (var el in this.groupBox1.Controls)
            {
                if (el is TextBox)
                {
                    TextBox tb = el as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text))
                        hasError = true;
                }
            }
            if (!hasError)
            {
                try
                {
                    nguoiDieuTri.GioiTinh = rdbGtnam.Checked ? true : false;
                    nguoiDieuTri.NgaySinh = DateTime.Parse(txbNs.Text);
                    nguoiDieuTri.TenNguoiDieuTri = txbTndt.Text;
                    nguoiDieuTri.SDT = int.Parse(txbSdt.Text);
                    nguoiDieuTri.DiaChi = txbDc.Text;
                    nguoiDieuTri.CMND = int.Parse(txbCmnd.Text);
                    nguoiDieuTri.IDNguoiDieuTri = int.Parse(txbMndt.Text);
                    db.Entry<NguoiDieuTri>(nguoiDieuTri).State = (System.Data.Entity.EntityState)EntityState.Modified;
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
                var nguoDieuTri = db.NguoiDieuTris.Find(int.Parse(id));
                db.LichSuDieuTris.RemoveRange(nguoDieuTri.LichSuDieuTris);
                db.NguoiDieuTris.Remove(nguoDieuTri);
                db.SaveChanges();
                hienthi();
            }
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbMndt.Text = lvi.SubItems[1].Text;
                txbTndt.Text = lvi.SubItems[2].Text;
                if (lv.SelectedItems[0].SubItems[3].Text == "Nam")
                {
                    rdbGtnam.Checked = true;
                }
                else rdbGtnu.Checked = true;
                txbNs.Text = lvi.SubItems[4].Text;
                txbCmnd.Text = lvi.SubItems[5].Text;
                txbDc.Text = lvi.SubItems[6].Text;
                txbSdt.Text = lvi.SubItems[7].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }


        private void rdbGtnam_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbGtnu_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btndatetime_Click(object sender, EventArgs e)
        {
            mtc.Visible = true;
            mtc.Location = new Point(319, 1);
        }


        private void mtc_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            txbNs.Text = mtc.SelectionStart.ToShortDateString();
            mtc.Visible = false;
        }

        private void mtc_MouseLeave(object sender, EventArgs e)
        {
            mtc.Visible = false;
        }

        private void Quản_lý_người_điều_trị_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
