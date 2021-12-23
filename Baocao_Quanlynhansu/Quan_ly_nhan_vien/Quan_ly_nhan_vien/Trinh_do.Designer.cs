namespace Quan_ly_nhan_vien
{
    partial class Trinh_do
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbmtd = new System.Windows.Forms.TextBox();
            this.btnhien = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbhv = new System.Windows.Forms.TextBox();
            this.txbcn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(243, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "Quản lý trình độ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbcn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txbhv);
            this.groupBox3.Controls.Add(this.txbmtd);
            this.groupBox3.Controls.Add(this.btnhien);
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnnhap);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 90);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txbmtd
            // 
            this.txbmtd.BackColor = System.Drawing.SystemColors.Window;
            this.txbmtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbmtd.Location = new System.Drawing.Point(73, 28);
            this.txbmtd.Multiline = true;
            this.txbmtd.Name = "txbmtd";
            this.txbmtd.Size = new System.Drawing.Size(140, 18);
            this.txbmtd.TabIndex = 59;
            // 
            // btnhien
            // 
            this.btnhien.Location = new System.Drawing.Point(366, 59);
            this.btnhien.Name = "btnhien";
            this.btnhien.Size = new System.Drawing.Size(102, 25);
            this.btnhien.TabIndex = 58;
            this.btnhien.Text = "Hiện";
            this.btnhien.UseVisualStyleBackColor = true;
            this.btnhien.Click += new System.EventHandler(this.btnhien_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(137, 59);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(105, 25);
            this.btnsua.TabIndex = 38;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(248, 59);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(110, 25);
            this.btnxoa.TabIndex = 29;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(20, 59);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(111, 25);
            this.btnnhap.TabIndex = 27;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Học vấn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã trình độ";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 62);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(637, 222);
            this.lv.TabIndex = 72;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 34;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã trình độ";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Học vấn";
            this.columnHeader3.Width = 207;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chuyên ngành";
            this.columnHeader4.Width = 136;
            // 
            // txbhv
            // 
            this.txbhv.BackColor = System.Drawing.SystemColors.Window;
            this.txbhv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbhv.Location = new System.Drawing.Point(278, 28);
            this.txbhv.Multiline = true;
            this.txbhv.Name = "txbhv";
            this.txbhv.Size = new System.Drawing.Size(129, 18);
            this.txbhv.TabIndex = 60;
            // 
            // txbcn
            // 
            this.txbcn.BackColor = System.Drawing.SystemColors.Window;
            this.txbcn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbcn.Location = new System.Drawing.Point(495, 28);
            this.txbcn.Multiline = true;
            this.txbcn.Name = "txbcn";
            this.txbcn.Size = new System.Drawing.Size(136, 18);
            this.txbcn.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Chuyên ngành";
            // 
            // Trinh_do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 389);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lv);
            this.Name = "Trinh_do";
            this.Text = "Trinh_do";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbmtd;
        private System.Windows.Forms.Button btnhien;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txbcn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbhv;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}