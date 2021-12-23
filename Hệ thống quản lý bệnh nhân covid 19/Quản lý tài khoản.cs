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
        public Quản_lý_tài_khoản()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=localhost,1433;User ID=sa;Password=1234567890;Database=QuanLyCovid";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0; int quyen; string q; int mtk; string mataikhoan;
        private void Quản_lý_tài_khoản_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }
        private void hienthi()
        {
            lv.Items.Clear();
            ketnoi.Open();
            sql = @"select * from Covid.Account";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0; int stt = 0; string STT;
            while (docdulieu.Read())
            {
                if (docdulieu[3].Equals(false)) { q = "Người điều trị"; }
                else { q = "Quản trị viên"; }
                stt++; STT = stt.ToString();
                lv.Items.Add((i + 1).ToString());
                lv.Items[i].SubItems.Add(docdulieu[1].ToString());
                lv.Items[i].SubItems.Add(docdulieu[2].ToString());
                lv.Items[i].SubItems.Add(q);
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
            string sql1 = @"select * from Covid.Account";
            SqlCommand thuchien1 = new SqlCommand(sql1, ketnoi);
            SqlDataReader docdulieu1 = thuchien1.ExecuteReader();
            while (docdulieu1.Read())
            {
                string cmnd = docdulieu1[5].ToString();

                if (txbcmnd.Text.Trim() == cmnd)
                {
                    acess = 0;
                    MessageBox.Show("Yêu cầu nhập CMND  khác", "CMND này đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbtdn.Text.Trim() == "") { acess = 2; break; }
                else if (txbmk.Text.Trim() == "") { acess = 2; break; }
                else if (txbhoten.Text.Trim() == "") { acess = 2; break; }
                else if (txbcmnd.Text.Trim() == "") { acess = 2; break; }
                else if (txbsdt.Text.Trim() == "") { acess = 2; break; }
                else { acess = 1; }
                /// 
            }
            ketnoi.Close();
            ketnoi.Open();
            string sqlphong = @"select TenDangNhap from Covid.PhongDieuTri";
            SqlCommand thuchienphong = new SqlCommand(sql1, ketnoi);
            SqlDataReader docdulieuphong = thuchienphong.ExecuteReader();
            while (docdulieuphong.Read())
            {
                if (txbtdn.Text.Trim() == docdulieuphong[1])
                {
                    acess = 3;
                }
            }
            if (acess == 3)
            {
                MessageBox.Show("Yêu cầu nhập tên đăng nhập khác", "Tên đăng nhập đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ketnoi.Close();
            ketnoi.Open();
            if (acess == 1)
            {
                sql = @"INSERT Covid.Account( TenDangNhap,MatKhau, Quyen,TenNguoiNhap,CMND,Sdt) 
                   VALUES(N'" + txbtdn.Text + @"',N'" + txbmk.Text + @"',N'" + quyen + @"',
                   N'" + txbhoten.Text + @"',N'" + txbcmnd.Text + @"',N'" + txbsdt.Text + @"')";
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
            string sql1 = @"select * from Covid.Account where MaTaiKhoan != N'" + mtk + @"'";
            SqlCommand thuchien1 = new SqlCommand(sql1, ketnoi);
            SqlDataReader docdulieu1 = thuchien1.ExecuteReader();
            while (docdulieu1.Read())
            {
                string cmnd = docdulieu1[5].ToString();

                if (txbcmnd.Text.Trim() == cmnd)
                {
                    acess = 0;
                   
                    MessageBox.Show("Yêu cầu nhập CMND  khác", "CMND này đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbtdn.Text.Trim() == "") { acess = 2;   break; }
                else if (txbmk.Text.Trim() == "") { acess = 2;    break; }
                else if (txbhoten.Text.Trim() == "") { acess = 2; break; }
                else if (txbcmnd.Text.Trim() == "") { acess = 2;  break; }
                else if (txbsdt.Text.Trim() == "") { acess = 2;   break; }
                else { acess = 1; }
                /// 
            }
            ketnoi.Close();
            ketnoi.Open();
            string sqlphong = @"select TenDangNhap from Covid.PhongDieuTri";
            SqlCommand thuchienphong = new SqlCommand(sql1, ketnoi);
            SqlDataReader docdulieuphong = thuchienphong.ExecuteReader();
            while (docdulieuphong.Read())
            {
                if (txbtdn.Text.Trim() == docdulieuphong[1])
                {
                    acess = 3;
                }
            }
            if (acess == 3)
            {
                MessageBox.Show("Yêu cầu nhập tên đăng nhập khác", "Tên đăng nhập đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ketnoi.Close();
            ketnoi.Open();
            
            
            if (acess == 1)
            {
                sql = @"UPDATE Covid.Account SET 
                   TenDangNhap = N'" + txbtdn.Text + @"', MatKhau = N'" + txbmk.Text + @"', Quyen = N'" + quyen + @"',
                   TenNguoiNhap = N'" + txbhoten.Text + @"', CMND = N'" + txbcmnd.Text + @"', SDT = N'" + txbsdt.Text + @"' 
                   where MaTaiKhoan = N'" + mtk + "'";
                thuchien = new SqlCommand(sql, ketnoi);
                
                int n = thuchien.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
            else if (acess == 2)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin");
            }
            ketnoi.Close();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
            ketnoi.Open();
            sql = @"Delete FROM Covid.Account where TenDangNhap = N'" + txbtdn.Text + "'";
            thuchien = new SqlCommand(sql, ketnoi);

            int n = thuchien.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xóa thành công!");
                    txbtdn.Text = "";
                    txbmk.Text = "";
                    txbhoten.Text = "";
                    txbcmnd.Text = "";
                    txbsdt.Text = "";

            }
            ketnoi.Close();
            hienthi();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbqtv_CheckedChanged(object sender, EventArgs e)
        {
            quyen = 1;
        }

        private void rdbndt_CheckedChanged(object sender, EventArgs e)
        {
            quyen = 0;
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
                if (lvi.SubItems[3].Text == "Người điều trị")
                {
                    rdbndt.Checked = true;
                }
                else rdbqtv.Checked = true;
                txbhoten.Text = lvi.SubItems[4].Text;
                txbcmnd.Text = lvi.SubItems[5].Text;
                txbsdt.Text = lvi.SubItems[6].Text;
                //
                ketnoi.Open();
                string sql1 = @"select MaTaiKhoan from Covid.Account where TenDangNhap = N'" + lvi.SubItems[1].Text + @"'";
                SqlCommand thuchien1 = new SqlCommand(sql1, ketnoi);
                SqlDataReader docdulieu1 = thuchien1.ExecuteReader();
                while (docdulieu1.Read())
                {
                    mataikhoan = docdulieu1[0].ToString();
                    
                }
                
                //MessageBox.Show(mataikhoan, mataikhoan, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.Close();
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
            mtk = int.Parse(mataikhoan);
        }

        private void mns1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
