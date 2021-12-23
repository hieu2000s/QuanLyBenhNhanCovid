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
    public partial class Phong : Form
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        int stt; string STT;
        public Phong()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            lv.Items.Clear(); stt = 0;
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Phong");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument document in documents)
            {
                stt++; STT = stt.ToString();
                string mp = document["Maphong"].AsString;
                string tenp = document["Tenphong"].AsString;
                int l = document["Sonhanvien"].ToInt32();
                string snv = l.ToString();

                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(mp);
                lvi.SubItems.Add(tenp);
                lvi.SubItems.Add(snv);      
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
                string mp = document["Maphong"].AsString;
                string tenp = document["Tenphong"].AsString;
                int l = document["Sonhanvien"].ToInt32();
                string snv = l.ToString();

                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(mp);
                lvi.SubItems.Add(tenp);
                lvi.SubItems.Add(snv);
            }
        }
        private void btnnhap_Click(object sender, EventArgs e)
        {        
                var database = client.GetDatabase("Le_Nguyen_Hung");
                var collection = database.GetCollection<BsonDocument>("Phong");
                BsonDocument document = new BsonDocument
                 {
                     { "Maphong",txbmp.Text},
                     { "Tenphong",txbtenp.Text},
                 };
                collection.InsertOne(document);
                show();
            }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Phong");
            var filter = Builders<BsonDocument>.Filter.Eq("Maphong", txbmp.Text);
            var result = collection.DeleteOne(filter);
            if (result.DeletedCount > 0)
                MessageBox.Show("xóa thành công");
            else
                MessageBox.Show("xóa thất bại");
            txbtenp.Text = "";
            txbtenp.Text = "";
            
            show();
        }

        private void btnhien_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Phong");
            var filter = Builders<BsonDocument>.Filter.Eq("Maphong", txbmp.Text);
            var update = Builders<BsonDocument>.Update
                .Set("Maphong", txbmp.Text)
                .Set("Tenphong", txbtenp.Text);
            collection.UpdateOne(filter, update);
            MessageBox.Show("Sửa thành công");
            show();
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbmp.Text = lvi.SubItems[1].Text;
                txbtenp.Text = lvi.SubItems[2].Text; 
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }

        private void txblon_TextChanged(object sender, EventArgs e)
        {
            if (txblon.Text != "")
            {
                lv.Items.Clear();
                var database = client.GetDatabase("Le_Nguyen_Hung");
                var collection = database.GetCollection<BsonDocument>("Phong");
                var filter = Builders<BsonDocument>.Filter.Gte("Sonhanvien", int.Parse(txblon.Text));
                var results = collection.Find(filter).ToList();
                stt = 0;
                foreach (BsonDocument document in results)
                {
                    stt++; STT = stt.ToString();
                    string mp = document["Maphong"].AsString;
                    string tenp = document["Tenphong"].AsString;
                    int l = document["Sonhanvien"].ToInt32();
                    string snv = l.ToString();

                    ListViewItem lvi = lv.Items.Add(STT);
                    lvi.SubItems.Add(mp);
                    lvi.SubItems.Add(tenp);
                    lvi.SubItems.Add(snv); 
                }
            }
        }

        private void txbnho_TextChanged(object sender, EventArgs e)
        {

            if (txbnho.Text != "")
            {
                lv.Items.Clear();
                var database = client.GetDatabase("Le_Nguyen_Hung");
                var collection = database.GetCollection<BsonDocument>("Phong");
                var filter = Builders<BsonDocument>.Filter.Lte("Sonhanvien", int.Parse(txbnho.Text));
                var results = collection.Find(filter).ToList();
                stt = 0;
                foreach (BsonDocument document in results)
                {
                    stt++; STT = stt.ToString();
                    string mp = document["Maphong"].AsString;
                    string tenp = document["Tenphong"].AsString;
                    int l = document["Sonhanvien"].ToInt32();
                    string snv = l.ToString();

                    ListViewItem lvi = lv.Items.Add(STT);
                    lvi.SubItems.Add(mp);
                    lvi.SubItems.Add(tenp);
                    lvi.SubItems.Add(snv);

                }
            }
        }

        private void cmbsapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Phong");
            lv.Items.Clear();
            if (cmbsapxep.Text == "Số nhân viên từ bé đến lớn")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Sonhanvien")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsapxep.Text == "Số nhân viên từ lớn đến bé") 
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Descending("Sonhanvien")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsapxep.Text == "Tên phòng từ a đến z")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Descending("Tenphong")).ToList();
                stt = 0;
                show(documents);
            }
            else if (cmbsapxep.Text == "Tên phòng từ z đến a")
            {
                var documents = collection.Find(new BsonDocument()).Sort(Builders<BsonDocument>.Sort.Ascending("Tenphong")).ToList();
                stt = 0;
                show(documents);
            }
            
        }
    }
}
