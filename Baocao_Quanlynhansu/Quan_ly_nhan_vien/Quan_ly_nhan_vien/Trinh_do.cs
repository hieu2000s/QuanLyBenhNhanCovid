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
    public partial class Trinh_do : Form
    {
        MongoClient client = new MongoClient("mongodb://localhost:27017");
        int stt; string STT;
        public Trinh_do()
        {
            InitializeComponent(); show();
        }
        private void show()
        {
            lv.Items.Clear(); stt = 0;
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Trinh_do");
            var documents = collection.Find(new BsonDocument()).ToList();
            foreach (BsonDocument document in documents)
            {
                stt++; STT = stt.ToString();
                string mtd = document["Matrinhdo"].AsString;
                string hv = document["Hocvan"].AsString;
                string cn = document["Chuyennganh"].AsString;
                ListViewItem lvi = lv.Items.Add(STT);
                lvi.SubItems.Add(mtd);
                lvi.SubItems.Add(hv);
                lvi.SubItems.Add(cn);
            }
        }
        private void lv_DoubleClick(object sender, EventArgs e)
        {
            int t = lv.SelectedItems.Count;
            if (t >= 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                txbmtd.Text = lvi.SubItems[1].Text;
                txbhv.Text = lvi.SubItems[2].Text;
                txbcn.Text = lvi.SubItems[3].Text;
            }
            else
            {
                MessageBox.Show("Ban chua chon doi tuong.");
            }
        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Trinh_do");
            BsonDocument document = new BsonDocument
                 {
                     { "Matrinhdo",txbmtd.Text},
                     { "Hocvan",txbhv.Text},
                      { "Chuyennganh",txbcn.Text},
                 };
            collection.InsertOne(document);
            MessageBox.Show("Đã lưu thành công");
            show();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Trinh_do");
            var filter = Builders<BsonDocument>.Filter.Eq("Matrinhdo", txbmtd.Text);
            var update = Builders<BsonDocument>.Update
                .Set("Mahocvan", txbhv.Text)
                .Set("Machuyennganh", txbcn.Text);
            collection.UpdateOne(filter, update);
            MessageBox.Show("Sửa thành công");
            show();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Trinh_do");
            var filter = Builders<BsonDocument>.Filter.Eq("Matrinhdo", txbmtd.Text);
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
