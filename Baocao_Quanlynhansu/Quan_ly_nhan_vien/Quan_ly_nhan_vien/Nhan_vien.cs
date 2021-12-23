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
    public partial class Nhan_vien : Form
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        int stt;string STT;string x = ""; int sonv;
        int mtcstatus;
        public Nhan_vien()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            lv.Items.Clear();
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            var documents = collection.Find(new BsonDocument()).ToList();
            stt = 0;
            var collections = database.GetCollection<BsonDocument>("Luong");
            var result = collections.Find(new BsonDocument()).ToList();
            foreach (BsonDocument results in result)
            {        
                int k = results["ThueTNCN"].ToInt32();
                string thue = k.ToString();
                foreach (BsonDocument document in documents)
                {
                    stt++; STT = stt.ToString();
                    string phong = document["Phongban"].AsString;
                    string mnv = document["Manhanvien"].AsString;
                    string tnv = document["Tennhanvien"].AsString;
                    string gt = document["Gioitinh"].AsString;
                    DateTime t = document["Ngaysinh"].ToLocalTime();
                    string ngays = String.Format("{0:dd/MM/yyyy}", t);
                    string nois = document["Noisinh"].AsString;
                    string noio = document["Noiothuongtru"].AsString;
                    string cmnd = document["Cmnd"].AsString;
                    string sdt = document["Sdt"].AsString;
                    string macv = document["Macv"].AsString;
                    string matd = document["Matrinhdo"].AsString;
                    string mahd = document["Mahopdong"].AsString;
                    int l = document["Luong"].ToInt32();
                    string luong = l.ToString();
                    ListViewItem lvi = lv.Items.Add(STT);
                    lvi.SubItems.Add(phong);
                    lvi.SubItems.Add(mnv);
                    lvi.SubItems.Add(tnv);
                    lvi.SubItems.Add(gt);
                    lvi.SubItems.Add(ngays);
                    lvi.SubItems.Add(nois);
                    lvi.SubItems.Add(noio);
                    lvi.SubItems.Add(cmnd);
                    lvi.SubItems.Add(sdt);
                    lvi.SubItems.Add(macv);
                    lvi.SubItems.Add(matd);
                    lvi.SubItems.Add(mahd);
                    lvi.SubItems.Add(luong);
                    lvi.SubItems.Add(thue);
                }
            }
        }
        private void show(string cl,string x)
        {
            lv.Items.Clear();
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");  
            var filter = Builders<BsonDocument>.Filter.Eq(cl, x);
            var results = collection.Find(filter).ToList();
            stt=0;
            foreach (BsonDocument document in results)
            {
                stt++; STT = stt.ToString();
                string phong = document["Phongban"].AsString;
                string mnv = document["Manhanvien"].AsString;
                string tnv = document["Tennhanvien"].AsString;
                string gt = document["Gioitinh"].AsString;
                DateTime t = document["Ngaysinh"].ToLocalTime();
                string ngays = String.Format("{0:dd/MM/yyyy}", t);
                string nois = document["Noisinh"].AsString;
                string noio = document["Noiothuongtru"].AsString;
                string cmnd = document["Cmnd"].AsString;
                string sdt = document["Sdt"].AsString;
                string macv = document["Macv"].AsString;
                string matd = document["Matrinhdo"].AsString;
                string mahd = document["Mahopdong"].AsString;
                int l = document["Luong"].ToInt32();
                string luong = l.ToString();
                ListViewItem lvi = lv.Items.Add(STT);   
                lvi.SubItems.Add(phong);
                lvi.SubItems.Add(mnv);
                lvi.SubItems.Add(tnv);
                lvi.SubItems.Add(gt);
                lvi.SubItems.Add(ngays);
                lvi.SubItems.Add(nois);
                lvi.SubItems.Add(noio);
                lvi.SubItems.Add(cmnd);
                lvi.SubItems.Add(sdt);
                lvi.SubItems.Add(macv);
                lvi.SubItems.Add(matd);
                lvi.SubItems.Add(mahd);
                lvi.SubItems.Add(luong);
            }
        }
        private void show(List<BsonDocument> documents)
        {
          
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            lv.Items.Clear();
            foreach (BsonDocument document in documents)
            {
                stt++; STT = stt.ToString();
                string phong = document["Phongban"].AsString;
                string mnv = document["Manhanvien"].AsString;
                string tnv = document["Tennhanvien"].AsString;
                string gt = document["Gioitinh"].AsString;
                DateTime t = document["Ngaysinh"].ToLocalTime();
                string ngays = String.Format("{0:dd/MM/yyyy}", t);
                string nois = document["Noisinh"].AsString;
                string noio = document["Noiothuongtru"].AsString;
                string cmnd = document["Cmnd"].AsString;
                string sdt = document["Sdt"].AsString;
                string macv = document["Macv"].AsString;
                string matd = document["Matrinhdo"].AsString;
                string mahd = document["Mahopdong"].AsString;
                int l = document["Luong"].ToInt32();
                string luong = l.ToString();
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(phong);
                lvi.SubItems.Add(mnv);
                lvi.SubItems.Add(tnv);
                lvi.SubItems.Add(gt);
                lvi.SubItems.Add(ngays);
                lvi.SubItems.Add(nois);
                lvi.SubItems.Add(noio);
                lvi.SubItems.Add(cmnd);
                lvi.SubItems.Add(sdt);
                lvi.SubItems.Add(macv);
                lvi.SubItems.Add(matd);
                lvi.SubItems.Add(mahd);
                lvi.SubItems.Add(luong);
            }
        }
        private void btnnhap_Click_1(object sender, EventArgs e)
        {
            int acess = 0;
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
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
                else if (txbp.Text == "") { acess = 0;    break; }
                else if (txbmnv.Text == "") { acess = 0;  break; }
                else if (txbtnv.Text == "") { acess = 0;  break; }
                else if (txbgt.Text == "") { acess = 0;   break; }
                else if (txbngs.Text == "") { acess = 0;  break; }
                else if (txbns.Text == "") { acess = 0;   break; }
                else if (txbno.Text == "") { acess = 0;   break; }
                else if (txbcmnd.Text == "") { acess = 0; break; }
                else if (txbmcv.Text == "") { acess = 0;  break; }
                else if (txbmhd.Text == "") { acess = 0;  break; }
                else if (txbmtd.Text == "") { acess = 0;  break; }
                else if (txbsdt.Text == "") { acess = 0;  break; }
                else if (txbmnv.Text.Trim() != mnv) { acess = 1; }
            }
            if (acess == 1)
            {
                BsonDocument document = new BsonDocument
                {
                    { "Phongban",txbp.Text},
                    { "Manhanvien",txbmnv.Text},
                    { "Tennhanvien",txbtnv.Text},
                    { "Gioitinh",txbgt.Text},
                    { "Ngaysinh", DateTime.Parse(txbngs.Text)},
                    { "Noiothuongtru",txbno.Text},
                    { "Cmnd",txbcmnd.Text},
                    { "Sdt",txbsdt.Text},
                    { "Noisinh",txbns.Text},
                    { "Macv",txbmcv.Text},
                    { "Matrinhdo",txbmtd.Text},
                    { "Mahopdong",txbmhd.Text},
                    { "Luong",0},
                };
                collection.InsertOne(document);
                MessageBox.Show("Đã lưu thành công");
                show();
                var collections = database.GetCollection<BsonDocument>("Phong");
                var filter = Builders<BsonDocument>.Filter.Eq("Tenphong", txbp.Text);
                var pipeline = new BsonDocument[]
                {
                        new BsonDocument
                        {
                            {
                            "$match", new BsonDocument
                            {
                                { "Tenphong", txbp.Text },
                            }
                            }
                        }
                };
                var a = collections.Aggregate<BsonDocument>(pipeline).ToList();
                foreach (BsonDocument documents in a)
                {
                    sonv = documents["Sonhanvien"].ToInt32();
                    sonv++;
                }
                var update = Builders<BsonDocument>.Update
                    .Set("Sonhanvien", sonv);
                collections.UpdateOne(filter, update);
            }
            else if(acess==0)MessageBox.Show("Yeu cau nhap day du thong tin");

            
        }
        
        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbp.Text = lvi.SubItems[1].Text;
                txbmnv.Text = lvi.SubItems[2].Text;
                txbtnv.Text = lvi.SubItems[3].Text;
                txbgt.Text = lvi.SubItems[4].Text;
                txbngs.Text = lvi.SubItems[5].Text;
                txbns.Text = lvi.SubItems[6].Text;
                txbno.Text = lvi.SubItems[7].Text;
                txbcmnd.Text = lvi.SubItems[8].Text;
                txbsdt.Text = lvi.SubItems[9].Text;
                txbmcv.Text = lvi.SubItems[10].Text;
                txbmtd.Text = lvi.SubItems[11].Text;
                txbmhd.Text = lvi.SubItems[12].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            var filter = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var update = Builders<BsonDocument>.Update
                 .Set("Phongban", txbp.Text)
                 .Set("Manhanvien", txbmnv.Text)
                 .Set("Tennhanvien", txbtnv.Text)
                 .Set("Gioitinh", txbgt.Text)
                 .Set("Ngaysinh", DateTime.Parse(txbngs.Text))
                 .Set("Noiothuongtru", txbno.Text)
                 .Set("Cmnd", txbcmnd.Text)
                 .Set("Sdt", txbsdt.Text)
                 .Set("Noisinh", txbns.Text)
                 .Set("Macv", txbmcv.Text)
                 .Set("Matrinhdo", txbmtd.Text)
                 .Set("Mahopdong", txbmhd.Text);           
            collection.UpdateOne(filter, update);
            MessageBox.Show("Update thành công");
            show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            var filter = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var result = collection.DeleteOne(filter);
            var collectionl = database.GetCollection<BsonDocument>("Luong");
            var filterl = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var resultl = collectionl.DeleteOne(filter);
            if (result.DeletedCount > 0)
            {
                var collections = database.GetCollection<BsonDocument>("Phong");
                var filters = Builders<BsonDocument>.Filter.Eq("Tenphong", txbp.Text);
                var pipeline = new BsonDocument[]
                {
                        new BsonDocument
                        {
                            {
                            "$match", new BsonDocument
                                {
                                    { "Tenphong", txbp.Text },
                                }
                            }
                        }
                };
                var a = collections.Aggregate<BsonDocument>(pipeline).ToList();
                foreach (BsonDocument documents in a)
                {
                    sonv = documents["Sonhanvien"].ToInt32();
                    sonv--;
                }
                var update = Builders<BsonDocument>.Update
                    .Set("Sonhanvien", sonv);
                collections.UpdateOne(filters, update);
                MessageBox.Show("xóa thành công");
            }
            else
                MessageBox.Show("xóa thất bại");
            show();  
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("huhu");
      
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            var filter = Builders<BsonDocument>.Filter.Eq("Tennhanvien", "/txbtkten.Text/i");
            var results= collection.Find(filter).ToList();      
            foreach (BsonDocument document in results)
            {
                stt++; STT = stt.ToString();
                string phong = document["Phongban"].AsString;
                string mnv = document["Manhanvien"].AsString;
                string tnv = document["Tennhanvien"].AsString;
                string gt = document["Gioitinh"].AsString;
                DateTime t = document["Ngaysinh"].ToLocalTime();
                string ngays = String.Format("{0:dd/MM/yyyy}", t);
                string nois = document["Noisinh"].AsString;
                string noio = document["Noiothuongtru"].AsString;
                string cmnd = document["Cmnd"].AsString;
                string sdt = document["Sdt"].AsString;
                string macv = document["Macv"].AsString;
                string matd = document["Matrinhdo"].AsString;
                string mahd = document["Mahopdong"].AsString;
                int l = document["Luong"].ToInt32();
                string luong = l.ToString();
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(phong);
                lvi.SubItems.Add(mnv);
                lvi.SubItems.Add(tnv);
                lvi.SubItems.Add(gt);
                lvi.SubItems.Add(ngays);
                lvi.SubItems.Add(nois);
                lvi.SubItems.Add(noio);
                lvi.SubItems.Add(cmnd);
                lvi.SubItems.Add(sdt);
                lvi.SubItems.Add(macv);
                lvi.SubItems.Add(matd);
                lvi.SubItems.Add(mahd);
                lvi.SubItems.Add(luong);
            }
            show("Tennhanvien", txbtkten.Text);
        }

        private void cmbphong_SelectedIndexChanged(object sender, EventArgs e)
        {  
                show("Phongban", cmbphong.Text);
        }
        private void txbtkten_Click(object sender, EventArgs e)
        {
            txbtkten.Text = "";
        }

        private void mtc_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (mtcstatus == 1)
            {
                txbtn.Text = mtc.SelectionStart.ToShortDateString();
                mtc.Visible = false;
            }
            else if (mtcstatus == 2)
            {
                txbdn.Text = mtc.SelectionStart.ToShortDateString();
                mtc.Visible = false;
            }
            else if (mtcstatus == 3)
            {
                txbngs.Text = mtc.SelectionStart.ToShortDateString();
                mtc.Visible = false;
            }
        }
      
        private void btnshowmtctn_Click(object sender, EventArgs e)
        {
            mtcstatus = 1;
            mtc.Visible = true;
            mtc.Location = new Point(12, 93);
            txbtn.Text = "";
        }

        private void btnshowmtcdn_Click(object sender, EventArgs e)
        {
            mtcstatus = 2;
            mtc.Visible = true;
            mtc.Location = new Point(93, 84);
            txbdn.Text = "";
        }
        private void btnshowngs_Click(object sender, EventArgs e)
        {
            mtcstatus = 3;
            mtc.Location = new Point(330, 225);
            mtc.Visible = true;     
        }

        private void btntimngay_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            var filter = Builders<BsonDocument>.Filter.Gte("Ngaysinh", DateTime.Parse(txbtn.Text)) &
                         Builders<BsonDocument>.Filter.Lte("Ngaysinh", DateTime.Parse(txbdn.Text));
            var results = collection.Find(filter).ToList();
            stt = 0;
            show(results);
            
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            show();
        }

        private void txbtongluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhien_Click(object sender, EventArgs e)
        {
            show();
        }

       

        private void cmbsapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            lv.Items.Clear();
            if (cmbsapxep.Text == "Lương từ cao xuống thấp")
            { 
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Descending("Luong")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsapxep.Text == "Lương từ thấp lên cao")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Luong")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsapxep.Text == "Ngày sinh từ trẻ đến lớn")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Descending("Ngaysinh")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsapxep.Text == "Ngày sinh từ lớn đến trẻ")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Ngaysinh")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsapxep.Text == "Tên nhân viên từ a đến z")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Tennhanvien")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsapxep.Text == "Tên nhân viên từ z đến a")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Descending("Tennhanvien")).ToList();
                stt = 0;
                show(documents);
            }
            
        }
        void tinhluong(string phong)
        {
            int tl = 0;
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
                    var pipeline = new BsonDocument[]
                    {
                        new BsonDocument
                        {
                            {
                            "$match", new BsonDocument
                            {
                                { "Phongban", phong },    
                            }
                            }
                        }
                    };          
                    var a = collection.Aggregate<BsonDocument>(pipeline).ToList();  
                    foreach (BsonDocument document in a)
                    {          
                        int l = document["Luong"].ToInt32();
                        tl = tl + l;
                        string luong = tl.ToString();
                        txbtongluong.Text = luong;
                     }
           
            

        }
        private void cmbptinhluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            if (cmbptinhluong.Text == "Các phòng")
            {
                show();
                var pipeline = new BsonDocument[]
                {
                        new BsonDocument
                        {
                            {
                            "$group", new BsonDocument
                            {
                                { "_id", 1 },
                                {
                                    "luong", new BsonDocument
                                    {
                                        {"$sum","$Luong"}
                                    }
                                },
                            }
                            }
                        }
                };
                var a = collection.Aggregate<BsonDocument>(pipeline).ToList();
                foreach (BsonDocument document in a)
                {
                    int l = document["luong"].ToInt32();
                    string luong = l.ToString();
                    txbtongluong.Text = luong;
                }
            }
            else
            {
                show("Phongban", cmbptinhluong.Text);
                tinhluong(cmbptinhluong.Text);
            }
        }
    }
}
