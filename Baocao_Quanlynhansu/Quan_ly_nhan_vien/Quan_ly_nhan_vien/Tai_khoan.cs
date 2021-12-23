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
    public partial class Tai_khoan : Form
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        int stt; string STT;
        public Tai_khoan()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            lv.Items.Clear(); stt = 0;
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Tai_khoan");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument document in documents)
            {
                stt++; STT = stt.ToString();
                string tdn = document["Tendangnhap"].AsString;
                string mk = document["Matkhau"].AsString;
                string mnv = document["Manhanvien"].AsString;
                string mcv = document["Machucvu"].AsString;
                
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(tdn);
                lvi.SubItems.Add(mk);
                lvi.SubItems.Add(mnv);
                lvi.SubItems.Add(mcv);
            }
        }
        private void btnnhap_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Tai_khoan");
            BsonDocument document = new BsonDocument
                 {
                     { "Tendangnhap",txbtdn.Text},
                     { "Matkhau",txbmk.Text},
                     { "Manhanvien",txbmnv.Text},
                     { "Machucvu",txbmcv.Text},
                 };
            collection.InsertOne(document);
            show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Tai_khoan");
            var filter = Builders<BsonDocument>.Filter.Eq("Manhanvien", txbmnv.Text);
            var update = Builders<BsonDocument>.Update
                .Set("Tendangnhap", txbtdn.Text)
                .Set("Matkhau", txbmk.Text);
            collection.UpdateOne(filter, update);
            MessageBox.Show("Sửa thành công");
            show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Tai_khoan");
            var filter = Builders<BsonDocument>.Filter.Eq("Tendangnhap", txbtdn.Text);
            var result = collection.DeleteOne(filter);
            if (result.DeletedCount > 0)
                MessageBox.Show("xóa thành công");
            else
                MessageBox.Show("xóa thất bại");
            txbmnv.Text = ""; txbmcv.Text = "";
            txbmk.Text = ""; txbtdn.Text = "";

            show();
        }

        private void btnhien_Click(object sender, EventArgs e)
        {
            show();
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbtdn.Text = lvi.SubItems[1].Text;
                txbmk.Text = lvi.SubItems[2].Text;
                txbmnv.Text = lvi.SubItems[1].Text;
                txbmcv.Text = lvi.SubItems[2].Text;
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
                txbmcv.Text = document["Macv"].AsString;
            }
        }
    }
}
