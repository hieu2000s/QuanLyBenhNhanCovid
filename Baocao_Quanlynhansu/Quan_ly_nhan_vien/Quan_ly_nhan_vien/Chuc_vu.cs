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
    public partial class Chuc_vu : Form
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        int stt; string STT;
        public Chuc_vu()
        {
            InitializeComponent(); show();
        }
        private void show()
        {
            lv.Items.Clear(); stt = 0;
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Chuc_vu");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument document in documents)
            {
                stt++; STT = stt.ToString();
                string mhd = document["Machucvu"].AsString;
                string tenhd = document["Tenchucvu"].AsString;
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(mhd);
                lvi.SubItems.Add(tenhd);
            }
        }
        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbmcv.Text = lvi.SubItems[1].Text;
                txbtcv.Text = lvi.SubItems[2].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Chuc_vu");
            BsonDocument document = new BsonDocument
                 {
                     { "Machucvu",txbmcv.Text},
                     { "Tenchucvu",txbtcv.Text},
                 };
            collection.InsertOne(document);
            MessageBox.Show("Đã lưu thành công");
            show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Chuc_vu");
            var filter = Builders<BsonDocument>.Filter.Eq("Machucvu", txbmcv.Text);
            var update = Builders<BsonDocument>.Update
                .Set("Tenchucvu", txbtcv.Text);
            collection.UpdateOne(filter, update);
            MessageBox.Show("Sửa thành công");
            show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Chuc_vu");
            var filter = Builders<BsonDocument>.Filter.Eq("Machucvu", txbmcv.Text);
            var result = collection.DeleteOne(filter);
            if (result.DeletedCount > 0)
                MessageBox.Show("xóa thành công");
            else
                MessageBox.Show("xóa thất bại");
            show();
        }

        private void btnhien_Click(object sender, EventArgs e)
        {
            show();
        }
    }
}
