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
    public partial class Quản_lý_lịch_sử_điều_trị : Form
    {
        QuanLyCovidModels db = new QuanLyCovidModels();
        public Quản_lý_lịch_sử_điều_trị()
        {
            InitializeComponent();
        }

        private void Quản_lý_lịch_sử_điều_trị_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi(List<LichSuDieuTri> list = null)
        {
            lv.Items.Clear();
            list = list ?? db.LichSuDieuTris.ToList();
            for (var i = 0; i < list.Count(); i++)
            {
                lv.Items.Add(new ListViewItem(new string[] {
                    (i + 1).ToString(),
                    list.ElementAt(i).IDLichSuDieuTri.ToString(),
                    list.ElementAt(i).IDBenhNhan.ToString(),
                    list.ElementAt(i).IDNguoiDieuTri.ToString(),
                    list.ElementAt(i).ThoiGian.ToString(),
                    list.ElementAt(i).LichSuDieuTri1,
                }));
            };
            
        }

        private void btndatetime_Click(object sender, EventArgs e)
        {
            mtc.Visible = true;
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbmbn.Text = lvi.SubItems[2].Text;
                txbmndt.Text = lvi.SubItems[3].Text;
                txbtg.Text = lvi.SubItems[4].Text;
                rtblsdt.Text = lvi.SubItems[5].Text;
                tbID.Text = lvi.SubItems[1].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
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
                    var lichSu = new LichSuDieuTri();
                    lichSu.IDBenhNhan = int.Parse(txbmbn.Text);
                    lichSu.ThoiGian = DateTime.Parse(txbtg.Text);
                    lichSu.IDNguoiDieuTri = int.Parse(txbmndt.Text);
                    lichSu.LichSuDieuTri1 = rtblsdt.Text;
                    db.LichSuDieuTris.Add(lichSu);
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
            var lichSu = db.LichSuDieuTris.Find(int.Parse(tbID.Text));
            bool hasError = false;
            foreach (var el in this.groupBox1.Controls)
            {
                if (el is TextBox)
                {
                    TextBox tb = el as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text) && !tb.Name.Equals("txbmbn"))
                        hasError = true;
                }
            }
            if (!hasError)
            {
                try
                {
                    lichSu.IDLichSuDieuTri = int.Parse(tbID.Text);
                    lichSu.IDBenhNhan = int.Parse(txbmbn.Text);
                    lichSu.ThoiGian = DateTime.Parse(txbtg.Text);
                    lichSu.IDNguoiDieuTri = int.Parse(txbmndt.Text);
                    lichSu.LichSuDieuTri1 = rtblsdt.Text;
                    
                    db.Entry<LichSuDieuTri>(lichSu).State = (System.Data.Entity.EntityState)EntityState.Modified;
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

        private void mtc_DateSelected(object sender, DateRangeEventArgs e)
        {
            txbtg.Text = mtc.SelectionStart.ToShortDateString();
            mtc.Visible = false;
        }

        private void mtc_MouseLeave(object sender, EventArgs e)
        {
            mtc.Visible = false;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xóa???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dl == DialogResult.Yes)
            {
                var id = lv.SelectedItems[0].SubItems[1].Text;
                var lichSu = db.LichSuDieuTris.Find(int.Parse(id));
                db.LichSuDieuTris.Remove(lichSu);
                db.SaveChanges();
                hienthi();
            }
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Quản_lý_lịch_sử_điều_trị_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
