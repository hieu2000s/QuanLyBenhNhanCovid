using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    public partial class Quản_lý_bệnh_nhân : Form
    {
        QuanLyCovidModels db = new QuanLyCovidModels();
        public Quản_lý_bệnh_nhân()
        {
            InitializeComponent();
        }

        private void Quản_lý_bệnh_nhân_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi(List<BenhNhan> list = null)
        {
            lv.Items.Clear();
            list = list ?? db.BenhNhans.ToList();
            for (var i = 0; i < list.Count(); i++)
            {
                lv.Items.Add(new ListViewItem(new string[] {
                    (i + 1).ToString(),
                    list.ElementAt(i).IDBenhNhan.ToString(),
                    list.ElementAt(i).TenBenhNhan,
                    (list.ElementAt(i).GioiTinh ?? false) ? "Nam":"Nu",
                    list.ElementAt(i).NgaySinh.ToString(),
                    list.ElementAt(i).CMND.ToString(),
                    list.ElementAt(i).DiaChi,
                    list.ElementAt(i).TinhTrangSucKhoe,
                    list.ElementAt(i).Email,
                    list.ElementAt(i).SDT.ToString(),
                    list.ElementAt(i).TenNguoiGiamHo,
                    list.ElementAt(i).IDPhongDieuTri.ToString()
                }));
            };
    }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            foreach(var el in this.groupBox1.Controls)
            {
                if(el is TextBox)
                {
                    TextBox tb = el as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text) && !tb.Name.Equals("txbTngh") && !tb.Name.Equals("txbCmnd") && !tb.Name.Equals("txbEmail"))
                        hasError = true;
                }
            }
            
            if (!hasError)
            {
                try
                {
                    var benhNhan = new BenhNhan();
                    benhNhan.IDBenhNhan = int.Parse(txbMbn.Text);
                    benhNhan.GioiTinh = rdbGtnam.Checked ? true : false;
                    benhNhan.NgaySinh = DateTime.Parse(txbNs.Text);
                    benhNhan.TenBenhNhan = txbTbn.Text;
                    benhNhan.SDT = int.Parse(txbSdt.Text);
                    benhNhan.TenNguoiGiamHo = txbTngh.Text;
                    benhNhan.Email = txbEmail.Text;
                    benhNhan.DiaChi = txbDc.Text;
                    benhNhan.CMND = int.Parse(txbCmnd.Text);
                    benhNhan.TinhTrangSucKhoe = txbTtsk.Text;
                    benhNhan.IDPhongDieuTri = int.Parse(txbMpdt.Text);
                    db.BenhNhans.Add(benhNhan);
                    db.SaveChanges();
                    hienthi();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi xảy ra", "Định dạng nhập vào không chính xác.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Yêu cầu nhập đủ thông tin","Bạn nhập thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            var benhNhan = db.BenhNhans.Find(int.Parse(txbMbn.Text));
            bool hasError = false;
            foreach (var el in this.groupBox1.Controls)
            {
                if (el is TextBox)
                {
                    TextBox tb = el as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text) && !tb.Name.Equals("txbTngh") && !tb.Name.Equals("txbCmnd") && !tb.Name.Equals("txbEmail"))
                        hasError = true;
                }
            }
            if (!hasError)
            {
                try
                {
                    benhNhan.GioiTinh = rdbGtnam.Checked ? true : false;
                    benhNhan.NgaySinh = DateTime.Parse(txbNs.Text);
                    benhNhan.TenBenhNhan = txbTbn.Text;
                    benhNhan.SDT = int.Parse(txbSdt.Text);
                    benhNhan.TenNguoiGiamHo = txbTngh.Text;
                    benhNhan.Email = txbEmail.Text;
                    benhNhan.DiaChi = txbDc.Text;
                    benhNhan.CMND = int.Parse(txbCmnd.Text);
                    benhNhan.TinhTrangSucKhoe = txbTtsk.Text;
                    benhNhan.IDPhongDieuTri = int.Parse(txbMpdt.Text);
                    db.Entry<BenhNhan>(benhNhan).State = (System.Data.Entity.EntityState)EntityState.Modified;
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
            try
            {
                if (dl == DialogResult.Yes)
                {
                    var id = lv.SelectedItems[0].SubItems[1].Text;
                    var benhNhan = db.BenhNhans.Find(int.Parse(id));
                    db.LichSuDieuTris.RemoveRange(benhNhan.LichSuDieuTris);
                    db.BenhNhans.Remove(benhNhan);
                    db.SaveChanges();
                    hienthi();
                }
            }
            catch(Exception){
                MessageBox.Show("Bạn không thể xóa bệnh nhân này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void rdbGtnam_CheckedChanged(object sender, EventArgs e)
        {
            //gender = 1;
        }

        private void rdbGtnu_CheckedChanged(object sender, EventArgs e)
        {
            //gender = 0;
        }
  
        private void btndatetime_Click(object sender, EventArgs e)
        {
            mtc.Visible = true;
            mtc.Location = new Point(343,-49);
        }

        private void mtc_DateSelected(object sender, DateRangeEventArgs e)
        {
            txbNs.Text = mtc.SelectionStart.ToShortDateString();
            mtc.Visible = false;
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbMbn.Text = lvi.SubItems[1].Text;
                txbTbn.Text = lvi.SubItems[2].Text;
                if (lv.SelectedItems[0].SubItems[2].Text == "Nam")
                {
                    rdbGtnam.Checked = true;
                }
                else rdbGtnu.Checked = true;
                txbNs.Text = lvi.SubItems[4].Text;
                txbCmnd.Text = lvi.SubItems[5].Text;
                txbDc.Text = lvi.SubItems[6].Text;
                txbTtsk.Text = lvi.SubItems[7].Text;
                txbEmail.Text = lvi.SubItems[8].Text;
                txbSdt.Text = lvi.SubItems[9].Text;
                txbTngh.Text = lvi.SubItems[10].Text;
                txbMpdt.Text = lvi.SubItems[11].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }

        private void cmbsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            lv.Items.Clear();
            List<BenhNhan> list = null;
            if (cmbsx.Text == "Sắp xếp theo tên từ A đến Z")
            {
                list = db.BenhNhans.OrderBy(x => x.TenBenhNhan).ToList();
            }
            else if (cmbsx.Text == "Sắp xếp theo tên từ Z đến A")
            {
                list = db.BenhNhans.OrderByDescending(x => x.TenBenhNhan).ToList();
            }
            else if (cmbsx.Text == "Sắp xếp theo mã phòng")
            {
                list = db.BenhNhans.OrderBy(x => x.IDPhongDieuTri).ToList();
            }
            else if (cmbsx.Text == "Sắp xếp theo địa chỉ")
            {
                list = db.BenhNhans.OrderBy(x => x.DiaChi).ToList();
            }
            hienthi(list);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mtc_MouseLeave(object sender, EventArgs e)
        {
            mtc.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Quản_lý_bệnh_nhân_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
