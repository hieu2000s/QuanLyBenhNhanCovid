namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    partial class Quản_lý_tài_khoản
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
            this.label1 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.lvstt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtdn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvquyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvsdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txID = new System.Windows.Forms.TextBox();
            this.btnhien = new System.Windows.Forms.Button();
            this.rdbndt = new System.Windows.Forms.RadioButton();
            this.rdbqtv = new System.Windows.Forms.RadioButton();
            this.txbsdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbcmnd = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbhoten = new System.Windows.Forms.TextBox();
            this.txbmk = new System.Windows.Forms.TextBox();
            this.txbtdn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản lý tài khoản";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvstt,
            this.lvtdn,
            this.lvmk,
            this.lvquyen,
            this.lvhoten,
            this.lvcmnd,
            this.lvsdt});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(12, 170);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(747, 365);
            this.lv.TabIndex = 17;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // lvstt
            // 
            this.lvstt.Text = "STT";
            this.lvstt.Width = 40;
            // 
            // lvtdn
            // 
            this.lvtdn.Text = "Tên đăng nhập";
            this.lvtdn.Width = 158;
            // 
            // lvmk
            // 
            this.lvmk.Text = "Mật khẩu";
            this.lvmk.Width = 128;
            // 
            // lvquyen
            // 
            this.lvquyen.Text = "Quyền";
            this.lvquyen.Width = 70;
            // 
            // lvhoten
            // 
            this.lvhoten.Text = "Họ và tên";
            this.lvhoten.Width = 124;
            // 
            // lvcmnd
            // 
            this.lvcmnd.Text = "CMND";
            this.lvcmnd.Width = 116;
            // 
            // lvsdt
            // 
            this.lvsdt.Text = "SĐT";
            this.lvsdt.Width = 98;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txID);
            this.groupBox1.Controls.Add(this.btnhien);
            this.groupBox1.Controls.Add(this.rdbndt);
            this.groupBox1.Controls.Add(this.rdbqtv);
            this.groupBox1.Controls.Add(this.txbsdt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbcmnd);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txbhoten);
            this.groupBox1.Controls.Add(this.txbmk);
            this.groupBox1.Controls.Add(this.txbtdn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(774, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 372);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txID
            // 
            this.txID.Location = new System.Drawing.Point(161, 31);
            this.txID.Multiline = true;
            this.txID.Name = "txID";
            this.txID.Size = new System.Drawing.Size(229, 29);
            this.txID.TabIndex = 39;
            this.txID.Visible = false;
            // 
            // btnhien
            // 
            this.btnhien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhien.Location = new System.Drawing.Point(297, 327);
            this.btnhien.Name = "btnhien";
            this.btnhien.Size = new System.Drawing.Size(74, 30);
            this.btnhien.TabIndex = 38;
            this.btnhien.Text = "Hiện";
            this.btnhien.UseVisualStyleBackColor = true;
            this.btnhien.Click += new System.EventHandler(this.btnhien_Click);
            // 
            // rdbndt
            // 
            this.rdbndt.AutoSize = true;
            this.rdbndt.Checked = true;
            this.rdbndt.Location = new System.Drawing.Point(277, 103);
            this.rdbndt.Name = "rdbndt";
            this.rdbndt.Size = new System.Drawing.Size(113, 21);
            this.rdbndt.TabIndex = 37;
            this.rdbndt.TabStop = true;
            this.rdbndt.Text = "Người điều trị";
            this.rdbndt.UseVisualStyleBackColor = true;
            this.rdbndt.CheckedChanged += new System.EventHandler(this.rdbndt_CheckedChanged);
            // 
            // rdbqtv
            // 
            this.rdbqtv.AutoSize = true;
            this.rdbqtv.Location = new System.Drawing.Point(161, 103);
            this.rdbqtv.Name = "rdbqtv";
            this.rdbqtv.Size = new System.Drawing.Size(110, 21);
            this.rdbqtv.TabIndex = 36;
            this.rdbqtv.Text = "Quản trị viên";
            this.rdbqtv.UseVisualStyleBackColor = true;
            this.rdbqtv.CheckedChanged += new System.EventHandler(this.rdbqtv_CheckedChanged);
            // 
            // txbsdt
            // 
            this.txbsdt.Location = new System.Drawing.Point(161, 209);
            this.txbsdt.Multiline = true;
            this.txbsdt.Name = "txbsdt";
            this.txbsdt.Size = new System.Drawing.Size(229, 29);
            this.txbsdt.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "CMND:*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbcmnd
            // 
            this.txbcmnd.Location = new System.Drawing.Point(161, 171);
            this.txbcmnd.Multiline = true;
            this.txbcmnd.Name = "txbcmnd";
            this.txbcmnd.Size = new System.Drawing.Size(229, 29);
            this.txbcmnd.TabIndex = 33;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(203, 327);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 30);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(107, 327);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 30);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tên đăng nhập:*";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(12, 327);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(78, 30);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Quyền:*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "Họ và tên:*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mật khẩu:*";
            // 
            // txbhoten
            // 
            this.txbhoten.Location = new System.Drawing.Point(161, 136);
            this.txbhoten.Multiline = true;
            this.txbhoten.Name = "txbhoten";
            this.txbhoten.Size = new System.Drawing.Size(229, 29);
            this.txbhoten.TabIndex = 27;
            // 
            // txbmk
            // 
            this.txbmk.Location = new System.Drawing.Point(161, 66);
            this.txbmk.Multiline = true;
            this.txbmk.Name = "txbmk";
            this.txbmk.Size = new System.Drawing.Size(229, 29);
            this.txbmk.TabIndex = 25;
            // 
            // txbtdn
            // 
            this.txbtdn.Location = new System.Drawing.Point(161, 31);
            this.txbtdn.Multiline = true;
            this.txbtdn.Name = "txbtdn";
            this.txbtdn.Size = new System.Drawing.Size(229, 29);
            this.txbtdn.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số điện thoại:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 0;
            // 
            // Quản_lý_tài_khoản
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.label1);
            this.Name = "Quản_lý_tài_khoản";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_lý_tài_khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quản_lý_tài_khoản_FormClosing);
            this.Load += new System.EventHandler(this.Quản_lý_tài_khoản_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader lvstt;
        private System.Windows.Forms.ColumnHeader lvtdn;
        private System.Windows.Forms.ColumnHeader lvmk;
        private System.Windows.Forms.ColumnHeader lvquyen;
        private System.Windows.Forms.ColumnHeader lvhoten;
        private System.Windows.Forms.ColumnHeader lvcmnd;
        private System.Windows.Forms.ColumnHeader lvsdt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbhoten;
        private System.Windows.Forms.TextBox txbmk;
        private System.Windows.Forms.TextBox txbtdn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbsdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbcmnd;
        private System.Windows.Forms.RadioButton rdbndt;
        private System.Windows.Forms.RadioButton rdbqtv;
        private System.Windows.Forms.Button btnhien;
        private System.Windows.Forms.TextBox txID;
    }
}