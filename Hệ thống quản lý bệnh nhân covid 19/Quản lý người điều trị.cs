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
        public Quản_lý_người_điều_trị()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=localhost,1433;User ID=sa;Password=1234567890;Database=QuanLyCovid";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0; int gender; string gt;
        private void Quản_lý_người_điều_trị_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        public void hienthi()
        {
            lv.Items.Clear();
            ketnoi.Open();
            sql = @"select * from Covid.NguoiDieuTri";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                //MessageBox.Show(a);
                if (docdulieu[2].Equals(true)) { gt = "Nam"; }
                else { gt = "Nữ"; }
                //DateTime t = docdulieu[3].
                //string ngays = String.Format("{0:dd/MM/yyyy}", t);
                string ns = Convert.ToDateTime(docdulieu[3]).ToString("dd/MM/yyyy");
                lv.Items.Add((i + 1).ToString());
                lv.Items[i].SubItems.Add(docdulieu[0].ToString());
                lv.Items[i].SubItems.Add(docdulieu[1].ToString());
                lv.Items[i].SubItems.Add(gt);//gioitinh
                lv.Items[i].SubItems.Add(ns);
                lv.Items[i].SubItems.Add(docdulieu[4].ToString());
                lv.Items[i].SubItems.Add(docdulieu[5].ToString());
                lv.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int acess = 0;
            lv.Items.Clear();
            ketnoi.Open();
            string sql1 = @"select * from Covid.NguoiDieuTri";
            SqlCommand thuchien1 = new SqlCommand(sql1, ketnoi);
            SqlDataReader docdulieu1 = thuchien1.ExecuteReader();
            while (docdulieu1.Read())
            {
                string mndt = docdulieu1[0].ToString();
                string cmnd = docdulieu1[4].ToString();
                string sdt = docdulieu1[5].ToString();
                if (txbMndt.Text.Trim() == mndt)
                {
                    acess = 0;
                    MessageBox.Show("Yêu cầu nhập mã người điều trị khác", "Mã người điều trị đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbCmnd.Text.Trim() == cmnd)
                {
                    acess = 0;
                    MessageBox.Show("Yêu cầu nhập CMND khác", "CMND trùng với người điều trị khác", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbSdt.Text.Trim() == sdt)
                {
                    acess = 0;
                    MessageBox.Show("Yêu cầu nhập SĐT khác", "SĐT trùng với người điều trị khác", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbMndt.Text.Trim() == "") { acess = 2; break; }
                else if (txbTndt.Text.Trim() == "") { acess = 2; break; }
                else if (txbNs.Text.Trim() == "") { acess = 2; break; }
                else if (txbCmnd.Text.Trim() == "") { acess = 2; break; }
                else if (txbSdt.Text.Trim() == "") { acess = 2; break; }
                else if (txbDc.Text.Trim() == "") { acess = 2; break; }
                else { acess = 1; }
            }
            ketnoi.Close();      
            ketnoi.Open();
            if (acess == 1)
            {
                sql = @"INSERT Covid.NguoiDieuTri(IDNguoiDieuTri, TenNguoiDieuTRi, GioiTinh, NgaySinh, CMND,SDT, DiaChi) 
                   VALUES(N'" + txbMndt.Text + @"',N'" + txbTndt.Text + @"',N'" + gender + @"',
                   N'" + Convert.ToDateTime(txbNs.Text).ToString("yyyy-MM-dd") + @"',N'" + txbCmnd.Text + @"',
                   N'" + txbSdt.Text + @"',N'" + txbDc.Text + @"')";
                thuchien = new SqlCommand(sql, ketnoi);
                int n = thuchien.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            else if (acess == 2)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
            }
            ketnoi.Close();
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int acess = 0;
            lv.Items.Clear();
            ketnoi.Open();
            string sql1 = @"select * from Covid.NguoiDieuTri where IDNguoiDieuTri != N'" + txbMndt.Text + @"'";
            SqlCommand thuchien1 = new SqlCommand(sql1, ketnoi);
            SqlDataReader docdulieu1 = thuchien1.ExecuteReader();
            while (docdulieu1.Read())
            {
                string mndt = docdulieu1[0].ToString();
                string cmnd = docdulieu1[4].ToString();
                string sdt = docdulieu1[5].ToString();
                if (txbMndt.Text.Trim() == mndt)
                {
                    acess = 0;
                    MessageBox.Show("Yêu cầu nhập mã người điều trị khác", "Mã người điều trị đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbCmnd.Text.Trim() == cmnd)
                {
                    acess = 0;
                    MessageBox.Show("Yêu cầu nhập CMND khác", "CMND trùng với người điều trị khác", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbSdt.Text.Trim() == cmnd)
                {
                    acess = 0;
                    MessageBox.Show("Yêu cầu nhập SĐT khác", "SĐT trùng với người điều trị khác", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbMndt.Text.Trim() == "") { acess = 2; break; }
                else if (txbTndt.Text.Trim() == "") { acess = 2; break; }
                else if (txbNs.Text.Trim() == "")   { acess = 2; break; }
                else if (txbCmnd.Text.Trim() == "") { acess = 2; break; }
                else if (txbSdt.Text.Trim() == "")  { acess = 2; break; }
                else if (txbDc.Text.Trim() == "")   { acess = 2; break; }
                else { acess = 1; }
            }
            ketnoi.Close();
            ketnoi.Open();
            if (acess == 1)
            {
                sql = @"UPDATE Covid.NguoiDieuTri SET  
                   IDNguoiDieuTri = N'" + txbMndt.Text + @"', TenNguoiDieuTri = N'" + txbTndt.Text + @"', GioiTinh = N'" + gender + @"',
                   NgaySinh = N'" + Convert.ToDateTime(txbNs.Text).ToString("yyyy-MM-dd") + @"', CMND = N'" + txbCmnd.Text + @"',
                   SDT = N'" + txbSdt.Text + @"',DiaChi = N'" + txbDc.Text + @"'           
                   where IDBenhNhan = N'" + txbMndt.Text + "'";
                thuchien = new SqlCommand(sql, ketnoi);
                int n = thuchien.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                }
            }
            else if (acess == 2) { MessageBox.Show("Yêu cầu nhập đầy đủ thông tin!"); }
            ketnoi.Close();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
            ketnoi.Open();
            sql = @"Delete FROM Covid.NguoiDieuTri where (IDNguoiDieuTri = N'" + txbMndt.Text + "')";
            thuchien = new SqlCommand(sql, ketnoi);

            int n = thuchien.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            ketnoi.Close();
            hienthi();
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
                txbSdt.Text = lvi.SubItems[6].Text;
                txbDc.Text = lvi.SubItems[7].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }
       

        private void rdbGtnam_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }

        private void rdbGtnu_CheckedChanged(object sender, EventArgs e)
        {
            gender = 0;
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

    }
}
