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
    public partial class Hop_dong : Form
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        int stt; string STT;
        public Hop_dong()
        {
            InitializeComponent();
            show();
        }
        private void show()
        {
            lv.Items.Clear(); stt = 0;
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Hop_dong");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument document in documents)
            {
                stt++; STT = stt.ToString();
                string mhd = document["Mahopdong"].AsString;
                string tenhd = document["Tenhopdong"].AsString;
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(mhd);
                lvi.SubItems.Add(tenhd);
            }
        }
        
        private void btnnhap_Click(object sender, EventArgs e)
        {
            
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Hop_dong");
            BsonDocument document = new BsonDocument
                 {
                     { "Mahopdong",txbmhd.Text},
                     { "Tenhopdong",txbtenhd.Text},
                 };
            collection.InsertOne(document);
            MessageBox.Show("Đã lưu thành công");
            show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Hop_dong");
            var filter = Builders<BsonDocument>.Filter.Eq("Mahopdong", txbmhd.Text);
            var update = Builders<BsonDocument>.Update
                .Set("Mahopdong", txbmhd.Text)
                .Set("Tenhopdong", txbtenhd.Text);
            collection.UpdateOne(filter, update);
            MessageBox.Show("Sửa thành công");
            show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Hop_dong");
            var filter = Builders<BsonDocument>.Filter.Eq("Mahopdong", txbmhd.Text);
            var result = collection.DeleteOne(filter);
            if (result.DeletedCount > 0)
                MessageBox.Show("xóa thành công");
            else
                MessageBox.Show("xóa thất bại");
            txbtenhd.Text = "";
            txbmhd.Text = "";

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
                txbmhd.Text = lvi.SubItems[1].Text;
                txbtenhd.Text = lvi.SubItems[2].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }
    }
}
