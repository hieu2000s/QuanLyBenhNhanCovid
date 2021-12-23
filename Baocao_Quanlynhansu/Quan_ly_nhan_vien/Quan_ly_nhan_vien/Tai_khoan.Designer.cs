namespace Quan_ly_nhan_vien
{
    partial class Tai_khoan
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
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txbtennv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbtdn = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnhien = new System.Windows.Forms.Button();
            this.txbmk = new System.Windows.Forms.TextBox();
            this.txbmnv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbmcv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(12, 42);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(724, 195);
            this.lv.TabIndex = 0;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đăng nhập";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mật khẩu";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã nhân viên";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã chức vụ";
            this.columnHeader10.Width = 134;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mã nhân viên:";
            // 
            // txbtennv
            // 
            this.txbtennv.AutoSize = true;
            this.txbtennv.Location = new System.Drawing.Point(19, 57);
            this.txbtennv.Name = "txbtennv";
            this.txbtennv.Size = new System.Drawing.Size(55, 13);
            this.txbtennv.TabIndex = 53;
            this.txbtennv.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // txbtdn
            // 
            this.txbtdn.BackColor = System.Drawing.SystemColors.Window;
            this.txbtdn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbtdn.Location = new System.Drawing.Point(109, 21);
            this.txbtdn.Multiline = true;
            this.txbtdn.Name = "txbtdn";
            this.txbtdn.Size = new System.Drawing.Size(135, 18);
            this.txbtdn.TabIndex = 68;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(144, 84);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(124, 23);
            this.btnsua.TabIndex = 74;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(274, 86);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(124, 21);
            this.btnxoa.TabIndex = 72;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(14, 86);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(124, 21);
            this.btnnhap.TabIndex = 71;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(291, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 24);
            this.label15.TabIndex = 81;
            this.label15.Text = "Quản lý tài khoản";
            // 
            // btnhien
            // 
            this.btnhien.Location = new System.Drawing.Point(404, 86);
            this.btnhien.Name = "btnhien";
            this.btnhien.Size = new System.Drawing.Size(124, 21);
            this.btnhien.TabIndex = 82;
            this.btnhien.Text = "Hiện";
            this.btnhien.UseVisualStyleBackColor = true;
            this.btnhien.Click += new System.EventHandler(this.btnhien_Click);
            // 
            // txbmk
            // 
            this.txbmk.BackColor = System.Drawing.SystemColors.Window;
            this.txbmk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbmk.Location = new System.Drawing.Point(109, 52);
            this.txbmk.Multiline = true;
            this.txbmk.Name = "txbmk";
            this.txbmk.Size = new System.Drawing.Size(135, 18);
            this.txbmk.TabIndex = 83;
            // 
            // txbmnv
            // 
            this.txbmnv.BackColor = System.Drawing.SystemColors.Window;
            this.txbmnv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbmnv.Location = new System.Drawing.Point(357, 22);
            this.txbmnv.Multiline = true;
            this.txbmnv.Name = "txbmnv";
            this.txbmnv.Size = new System.Drawing.Size(135, 18);
            this.txbmnv.TabIndex = 84;
            this.txbmnv.TextChanged += new System.EventHandler(this.txbmnv_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbmcv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbmnv);
            this.groupBox1.Controls.Add(this.btnhien);
            this.groupBox1.Controls.Add(this.txbmk);
            this.groupBox1.Controls.Add(this.txbtdn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbtennv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnnhap);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 113);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // txbmcv
            // 
            this.txbmcv.BackColor = System.Drawing.SystemColors.Window;
            this.txbmcv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbmcv.Location = new System.Drawing.Point(357, 52);
            this.txbmcv.Multiline = true;
            this.txbmcv.Name = "txbmcv";
            this.txbmcv.Size = new System.Drawing.Size(135, 18);
            this.txbmcv.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Mã chức vụ:";
            // 
            // Tai_khoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lv);
            this.Name = "Tai_khoan";
            this.Text = "Tai_khoan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txbtennv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbtdn;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnhien;
        private System.Windows.Forms.TextBox txbmk;
        private System.Windows.Forms.TextBox txbmnv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbmcv;
        private System.Windows.Forms.Label label1;
    }
}