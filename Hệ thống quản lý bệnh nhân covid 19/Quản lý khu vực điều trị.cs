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
    public partial class Quản_lý_khu_vực_điều_trị : Form
    {
        QuanLyCovidModels db = new QuanLyCovidModels();
        public Quản_lý_khu_vực_điều_trị()
        {
            InitializeComponent();
        }

        private void Quản_lý_khu_vực_điều_trị_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        void hienthi(List<KhuVucDieuTri> list = null)
        {
            lv.Items.Clear();
            list = list ?? db.KhuVucDieuTris.ToList();
            for (var i = 0; i < list.Count(); i++)
            {
                lv.Items.Add(new ListViewItem(new string[] {
                    (i + 1).ToString(),
                    list.ElementAt(i).IDKhuVucDieuTri.ToString(),
                    list.ElementAt(i).TenKhuVucDieuTri,
                    list.ElementAt(i).Mota.ToString(),
                })); ;
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
                    if (string.IsNullOrWhiteSpace(tb.Text) && !tb.Name.Equals("txbMt"))
                        hasError = true;
                }
            }
            if (!hasError)
            {
                try
                {
                    var khuVuc = new KhuVucDieuTri();
                    khuVuc.TenKhuVucDieuTri = txbTkv.Text;
                    khuVuc.Mota = txbMt.Text;

                    db.KhuVucDieuTris.Add(khuVuc);
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
            var khu = db.KhuVucDieuTris.Find(int.Parse(txbID.Text));
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
                    khu.TenKhuVucDieuTri = txbTkv.Text;
                    khu.IDKhuVucDieuTri = int.Parse(txbID.Text);
                    khu.Mota = txbMt.Text;
                    db.Entry<KhuVucDieuTri>(khu).State = (System.Data.Entity.EntityState)EntityState.Modified;
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
                    var khuVuc = db.KhuVucDieuTris.Find(int.Parse(id));
                    try
                    {
                        db.KhuVucDieuTris.Remove(khuVuc);
                        db.SaveChanges();
                        hienthi();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bạn không thể xóa khu vực này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không thể xóa khu vực này bây giờ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbID.Text = lvi.SubItems[1].Text;
                txbTkv.Text = lvi.SubItems[2].Text;
                txbMt.Text = lvi.SubItems[3].Text; 
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }

        private void Quản_lý_khu_vực_điều_trị_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
