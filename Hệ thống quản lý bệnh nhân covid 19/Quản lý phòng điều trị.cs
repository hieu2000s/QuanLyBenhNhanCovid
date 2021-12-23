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
    public partial class Quản_lý_phòng_điều_trị : Form
    {
        QuanLyCovidModels db = new QuanLyCovidModels();
        public Quản_lý_phòng_điều_trị()
        {
            InitializeComponent();
            cmbtkvdt.DataSource = db.KhuVucDieuTris.ToList();
            cmbtkvdt.DisplayMember = "TenKhuVucDieuTri";
            cmbtkvdt.ValueMember = "IDKhuVucDieuTri";
        }
        private void Quản_lý_phòng_điều_trị_Load(object sender, EventArgs e)
        {
            hienthi();
        }
        public void hienthi(List<PhongDieuTri> list = null)
        {
            lv.Items.Clear();
            list = list ?? db.PhongDieuTris.ToList();
            for (var i = 0; i < list.Count(); i++)
            {
                lv.Items.Add(new ListViewItem(new string[] {
                    (i + 1).ToString(),
                    list.ElementAt(i).IDPhongDieuTri.ToString(),
                    list.ElementAt(i).TenPhongDieuTri.ToString(),
                    list.ElementAt(i).KhuVucDieuTri.TenKhuVucDieuTri,
                    list.ElementAt(i).SoLuongGiuong.ToString(),
                }));
            };

        }
        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbId.Text = lvi.SubItems[1].Text;
                txbTpdt.Text = lvi.SubItems[2].Text;
                txbSlg.Text = lvi.SubItems[4].Text;
                cmbtkvdt.Text = lvi.SubItems[3].Text;
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
                    if (string.IsNullOrWhiteSpace(tb.Text)&&!tb.Name.Equals("txbId"))
                        hasError = true;
                }
            }

            if (!hasError)
            {
                try
                {
                    var selected = cmbtkvdt.SelectedValue.ToString();
                    var phong = new PhongDieuTri();
                    phong.TenPhongDieuTri = txbTpdt.Text;

                    phong.IDKhuVucDieuTri = int.Parse(selected);
                    phong.SoLuongGiuong = int.Parse(txbSlg.Text);

                    db.PhongDieuTris.Add(phong);
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
            var phong = db.PhongDieuTris.Find(int.Parse(txbId.Text));
            bool hasError = false;
            foreach (var el in this.groupBox1.Controls)
            {
                if (el is TextBox)
                {
                    TextBox tb = el as TextBox;
                    if (string.IsNullOrWhiteSpace(tb.Text) && !tb.Name.Equals("txbId"))
                        hasError = true;
                }
            }
            if (!hasError)
            {
                try
                {
                    phong.TenPhongDieuTri = txbTpdt.Text;
                    phong.IDKhuVucDieuTri = int.Parse(cmbtkvdt.SelectedValue.ToString());
                    phong.SoLuongGiuong = int.Parse(txbSlg.Text);
                    db.Entry<PhongDieuTri>(phong).State = (System.Data.Entity.EntityState)EntityState.Modified;
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
                    var phong = db.PhongDieuTris.Find(int.Parse(id));
                    try
                    {
                        db.PhongDieuTris.Remove(phong);
                        db.SaveChanges();
                        hienthi();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bạn không thể xóa phòng này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                hienthi();
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn không thể xóa phòng lúc này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtkvdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //makv = int.Parse(cmbtkvdt.SelectedValue.ToString());
            //MessageBox.Show(makv.ToString());
        }

        private void Quản_lý_phòng_điều_trị_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
