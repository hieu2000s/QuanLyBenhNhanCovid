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
    public partial class shownv : Form
    {
       
        public string mmm;
        public shownv()
        {
            InitializeComponent();
           
            
        }
        public shownv(string a)
        {
            InitializeComponent();
            show(a);
        }

        int stt; string STT; string x = ""; int sonv;
        

        private void show(string a)
        {   

            MongoClient client = new MongoClient("mongodb://localhost:27017");
            
            int mtcstatus;
            lv.Items.Clear();       
            var database = client.GetDatabase("Le_Nguyen_Hung");
            var collection = database.GetCollection<BsonDocument>("Nhan_Vien");
            var filter = Builders<BsonDocument>.Filter.Eq("Manhanvien",a);
            var results = collection.Find(filter).ToList();
            stt = 0;
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
    
    }
}
