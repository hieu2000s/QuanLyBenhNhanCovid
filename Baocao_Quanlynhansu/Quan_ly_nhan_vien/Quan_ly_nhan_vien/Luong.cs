using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB;
using MongoDB.Bson.Serialization;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Quan_ly_nhan_vien
{
    public partial class Luong : Form
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        int stt; string STT;
        public Luong()
        {
            InitializeComponent();
            show();
        
        }
        int lcb=0;int thue=0;int thuong=0;int phat=0;
        private void txblcb_TextChanged(object sender, EventArgs e)
        {
            if (txblcb.Text != "")
            {
                int ltl = 0;
                lcb= int.Parse(txblcb.Text);
                ltl = ltl = lcb - lcb * thue / 100 + thuong - phat;
                txbltl.Text = ltl.ToString();
            }
        }

        private void txbthue_TextChanged(object sender, EventArgs e)
        {
            if (txbthue.Text != "")
            {
                int ltl = 0;
                thue = int.Parse(txbthue.Text);
                ltl = ltl = lcb - lcb * thue / 100 + thuong - phat;
                txbltl.Text = ltl.ToString();
            }
        }

        private void txbthuong_TextChanged(object sender, EventArgs e)
        {
            if (txbthuong.Text != "")
            {
                int ltl = 0;thuong = int.Parse(txbthuong.Text);
                ltl = ltl = lcb - lcb * thue / 100 + thuong - phat;
                txbltl.Text = ltl.ToString();
            }
        }

        private void txbphat_TextChanged(object sender, EventArgs e)
        {
            if (txbphat.Text != "")
            {
                int ltl = 0;phat = int.Parse(txbphat.Text);
                ltl = ltl = lcb - lcb * thue / 100 + thuong-phat;
                txbltl.Text = ltl.ToString();
            }
        }
       
        private void show()
        {
            lv.Items.Clear();
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Luong");
            var documents = collection.Find(new BsonDocument()).ToList();
            stt = 0; int tongl=0;
            foreach (BsonDocument document in documents)
            {
                stt++; STT = stt.ToString();
                string mnv = document["Manhanvien"].AsString;
                string mp = document["Maphong"].AsString;
                string mcv = document["Machucvu"].AsString;
                string mtd = document["Matrinhdo"].AsString;
                string mhd = document["Mahopdong"].AsString;
                int ngl = document["Tongngaylam"].ToInt32();
                string tngl = ngl.ToString();
                int sngl = document["Songaylamtrongthang"].ToInt32();
                string sngltt = sngl.ToString();
                int cb = document["Luongcoban"].ToInt32();
                string lcb = cb.ToString();
                int tncn = document["ThueTNCN"].ToInt32();
                string thue = tncn.ToString();
                int t = document["Thuong"].ToInt32();
                string thuong = t.ToString();
                int p = document["Phat"].ToInt32();
                string phat = p.ToString();
                int tl = document["Luongthuclinh"].ToInt32();
                tongl = tongl + tl;
                string ltl = tl.ToString();
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(mnv);
                lvi.SubItems.Add(mp);
                lvi.SubItems.Add(mcv);
                lvi.SubItems.Add(mtd);
                lvi.SubItems.Add(mhd);
                lvi.SubItems.Add(tngl);
                lvi.SubItems.Add(sngltt);
                lvi.SubItems.Add(lcb);
                lvi.SubItems.Add(thue);
                lvi.SubItems.Add(thuong);
                lvi.SubItems.Add(phat);
                lvi.SubItems.Add(ltl);           
            }
            txbtl.Text = tongl.ToString();
        }
        private void show(string cl, string x)
        {
            lv.Items.Clear();
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Luong");
            var filter = Builders<BsonDocument>.Filter.Eq(cl, x);
            var results = collection.Find(filter).ToList();
            stt = 0; int tongl = 0;
            foreach (BsonDocument document in results)
            {
                stt++; STT = stt.ToString();
                string mnv = document["Manhanvien"].AsString;
                string mp = document["Maphong"].AsString;
                string mcv = document["Machucvu"].AsString;
                string mtd = document["Matrinhdo"].AsString;
                string mhd = document["Mahopdong"].AsString;
                int ngl = document["Tongngaylam"].ToInt32();
                string tngl = ngl.ToString();
                int sngl = document["Songaylamtrongthang"].ToInt32();
                string sngltt = sngl.ToString();
                int cb = document["Luongcoban"].ToInt32();
                string lcb = cb.ToString();
                int tncn = document["ThueTNCN"].ToInt32();
                string thue = tncn.ToString();
                int t = document["Thuong"].ToInt32();
                string thuong = t.ToString();
                int p = document["Phat"].ToInt32();
                string phat = p.ToString();
                int tl = document["Luongthuclinh"].ToInt32(); tongl = tongl + tl;
                string ltl = tl.ToString();
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(mnv);
                lvi.SubItems.Add(mp);
                lvi.SubItems.Add(mcv);
                lvi.SubItems.Add(mtd);
                lvi.SubItems.Add(mhd);
                lvi.SubItems.Add(tngl);
                lvi.SubItems.Add(sngltt);
                lvi.SubItems.Add(lcb);
                lvi.SubItems.Add(thue);
                lvi.SubItems.Add(thuong);
                lvi.SubItems.Add(phat);
                lvi.SubItems.Add(ltl);
            }
            txbtl.Text = tongl.ToString();
        }
        private void show(List<BsonDocument> documents)
        { 
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Luong");
            lv.Items.Clear();
            stt = 0; int tongl = 0;
            foreach (BsonDocument document in documents)
            {
                stt++; STT = stt.ToString();
                string mnv = document["Manhanvien"].AsString;
                string mp = document["Maphong"].AsString;
                string mcv = document["Machucvu"].AsString;
                string mtd = document["Matrinhdo"].AsString;
                string mhd = document["Mahopdong"].AsString;
                int ngl = document["Tongngaylam"].ToInt32();
                string tngl = ngl.ToString();
                int sngl = document["Songaylamtrongthang"].ToInt32();
                string sngltt = sngl.ToString();
                int cb = document["Luongcoban"].ToInt32();
                string lcb = cb.ToString();
                int tncn = document["ThueTNCN"].ToInt32();
                string thue = tncn.ToString();
                int t = document["Thuong"].ToInt32();
                string thuong = t.ToString();
                int p = document["Phat"].ToInt32();
                string phat = p.ToString();
                int tl = document["Luongthuclinh"].ToInt32();
                tongl = tongl + tl;
                string ltl = tl.ToString();
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(mnv);
                lvi.SubItems.Add(mp);
                lvi.SubItems.Add(mcv);
                lvi.SubItems.Add(mtd);
                lvi.SubItems.Add(mhd);
                lvi.SubItems.Add(tngl);
                lvi.SubItems.Add(sngltt);
                lvi.SubItems.Add(lcb);
                lvi.SubItems.Add(thue);
                lvi.SubItems.Add(thuong);
                lvi.SubItems.Add(phat);
                lvi.SubItems.Add(ltl);
            }
            txbtl.Text = tongl.ToString();
        }
        private void btnnhap_Click(object sender, EventArgs e)
        {
            int l = int.Parse(txbltl.Text);int acess=0;
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Luong");
            var results = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument documents in results)
            {   
                string mnv = documents["Manhanvien"].AsString;
                if (txbmnv.Text.Trim() == mnv)
                {
                    acess = 2;
                    MessageBox.Show("Yêu cầu nhập mã nhân viên khác", "Mã nhân viên đã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbmp.Text == "") { acess = 0; break; }
                else if (txbmcv.Text == "") { acess = 0; break; }
                else if (txbmtd.Text == "") { acess = 0; break; }
                else if (txbmhd.Text == "") { acess = 0; break; }
                else if (txbtnl.Text == ""||int.Parse(txbtnl.Text)<0) { acess = 0; break; }
                else if (txbsnl.Text == "" || int.Parse(txbsnl.Text) < 0) { acess = 0; break; }
                else if (txblcb.Text == "") { acess = 0; break; }
                else if (txbthue.Text == "") { acess = 0; break; }
                else if (txbthuong.Text == "") { acess = 0; break; }
                else if (txbphat.Text == "") { acess = 0; break; }
                if (l<0)
                {
                    acess = 2;
                    MessageBox.Show("Yeu cau nhap lai", "Luong thuc linh tinh sai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                else if (txbmnv.Text.Trim() != mnv) { acess = 1; }
            }
            if (acess == 1)
            {
                BsonDocument document = new BsonDocument
            {
                { "Manhanvien",txbmnv.Text},
                { "Maphong",txbmp.Text},
                { "Machucvu",txbmcv.Text},
                { "Matrinhdo",txbmtd.Text},
                { "Mahopdong", txbmhd.Text},
                { "Tongngaylam",int.Parse(txbtnl.Text)},
                { "Songaylamtrongthang",int.Parse(txbsnl.Text)},
                { "Luongcoban",int.Parse(txblcb.Text)},
                { "ThueTNCN",int.Parse(txbthue.Text)},
                { "Thuong",int.Parse(txbthuong.Text)},
                { "Phat",int.Parse(txbphat.Text)}, 
                { "Luongthuclinh",int.Parse(txbltl.Text)},
               
            };
            collection.InsertOne(document);
            MessageBox.Show("Đã lưu thành công"); 
            show();
            var collectionnv = database.GetCollection<BsonDocument>("Nhan_Vien");
            var filters = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var updates = Builders<BsonDocument>.Update
                .Set("Luong", int.Parse(txbltl.Text));
            collectionnv.UpdateOne(filters, updates);
            }
            else if (acess == 0)
            MessageBox.Show("Yeu cau nhap lai", "Thong tin nhap sai", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Luong");
            var filter = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var update = Builders<BsonDocument>.Update
                .Set("Manhanvien", txbmnv.Text)
                .Set("Maphong", txbmp.Text)
                .Set("Machucvu", txbmcv.Text)
                .Set("Matrinhdo", txbmtd.Text)
                .Set("Mahopdong", txbmhd.Text)
                .Set("Tongngaylam", int.Parse(txbtnl.Text))
                .Set("Songaylamtrongthang", int.Parse(txbsnl.Text))
                .Set("Luongcoban", int.Parse(txblcb.Text))
                .Set("ThueTNCN", int.Parse(txbthue.Text))
                .Set("Thuong", int.Parse(txbthuong.Text))
                .Set("Phat", int.Parse(txbphat.Text))
                .Set("Luongthuclinh", int.Parse(txbltl.Text));
            collection.UpdateOne(filter, update);
            MessageBox.Show("Sửa thành công");
            var collectionnv = database.GetCollection<BsonDocument>("Nhan_Vien");
            var filters = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var updates = Builders<BsonDocument>.Update
                .Set("Luong", int.Parse(txbltl.Text));
            collectionnv.UpdateOne(filters, updates);
            show();
            


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Luong");
            var filter = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var result = collection.DeleteOne(filter);
            if (result.DeletedCount > 0)
            {
                var collectionnv = database.GetCollection<BsonDocument>("Nhan_Vien");
                var filters = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
                var updates = Builders<BsonDocument>.Update
                    .Set("Luong", 0);
                collectionnv.UpdateOne(filters, updates);
                MessageBox.Show("xóa thành công");
            }     
            else
                MessageBox.Show("xóa thất bại");
            txbmnv.Text = "";
            txbmp.Text = "";
            txbmcv.Text = "";
            txbmtd.Text ="";
            txbmhd.Text = "";
            txbtnl.Text = "";
            txbsnl.Text = "";
            txblcb.Text ="";
            txbthue.Text = "";
            txbthuong.Text = "";
            txbphat.Text = "";
            txbltl.Text = "";
            show();
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbmnv.Text = lvi.SubItems[1].Text;
                txbmp.Text = lvi.SubItems[2].Text;
                txbmcv.Text = lvi.SubItems[3].Text;
                txbmtd.Text = lvi.SubItems[4].Text;
                txbmhd.Text = lvi.SubItems[5].Text;
                txbtnl.Text = lvi.SubItems[6].Text;
                txbsnl.Text = lvi.SubItems[7].Text;
                txblcb.Text = lvi.SubItems[8].Text;
                txbthue.Text = lvi.SubItems[9].Text;
                txbthuong.Text = lvi.SubItems[10].Text;
                txbphat.Text = lvi.SubItems[11].Text;
                txbltl.Text = lvi.SubItems[12].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }

        private void txbmnv_TextChanged(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            //var collection = database.GetCollection<BsonDocument>("Luong");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            var filter = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var documents = collection.Find(filter).ToList();
            foreach (BsonDocument document in documents)
            {
                txbmp.Text = document["Phongban"].AsString;
                txbmcv.Text = document["Macv"].AsString;
                txbmtd.Text = document["Matrinhdo"].AsString;
                txbmhd.Text = document["Mahopdong"].AsString;
            }
        }

        private void btnhien_Click(object sender, EventArgs e)
        {
            show();
        }

        private void cmbphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            show("Maphong", cmbphong.Text);
        }

        private void btntimmnv_Click(object sender, EventArgs e)
        {
            show("Manhanvien", txbtknv.Text);
        }

        private void cmbsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Luong");
            lv.Items.Clear();
            if (cmbsx.Text == "Lương thực lĩnh từ thấp đến cao")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Luongthuclinh")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsx.Text == "Lương thực lĩnh từ cao đến thấp")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Descending("Luongthuclinh")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsx.Text == "Hợp đồng")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Mahopdong")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsx.Text == "Trình độ")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Matrinhdo")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsx.Text == "Chức vụ")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Machucvu")).ToList();
                stt = 0;
                show(documents);
            }
        }

        private void btnt(object sender, EventArgs e)
        {

        }

        private void txbnho_TextChanged(object sender, EventArgs e)
        {
            if (txbnho.Text != "")
            {
                if (txbnho.Text != "")
                {
                    lv.Items.Clear();
                    var database = client.GetDatabase("Le_Nguyen_Hung");
                    var collection = database.GetCollection<BsonDocument>("Luong");
                    var filter = Builders<BsonDocument>.Filter.Lte("Luongthuclinh", int.Parse(txbnho.Text));
                    var results = collection.Find(filter).ToList();
                    show(results);
                }
                else if (txbnho.Text == "")
                {
                    lv.Items.Clear();
                    var database = client.GetDatabase("Le_Nguyen_Hung");
                    var collection = database.GetCollection<BsonDocument>("Luong");
                    var filter = Builders<BsonDocument>.Filter.Lte("Luongthuclinh",9999999999);
                    var results = collection.Find(filter).ToList();
                    show(results);
                }
            }
        }

        private void txblon_TextChanged(object sender, EventArgs e)
        {
            if (txblon.Text != "")
            {
                lv.Items.Clear();
                var database = client.GetDatabase("Le_Nguyen_Hung");
                var collection = database.GetCollection<BsonDocument>("Luong");
                var filter = Builders<BsonDocument>.Filter.Gte("Luongthuclinh", int.Parse(txblon.Text));
                var results = collection.Find(filter).ToList();
                show(results);
            }
            else if (txblon.Text == "")
            {
                lv.Items.Clear();
                var database = client.GetDatabase("Le_Nguyen_Hung");
                var collection = database.GetCollection<BsonDocument>("Luong");
                var filter = Builders<BsonDocument>.Filter.Gte("Luongthuclinh",0);
                var results = collection.Find(filter).ToList();
                show(results);
            }
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
