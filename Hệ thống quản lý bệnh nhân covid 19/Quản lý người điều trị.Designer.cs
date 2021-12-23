namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    partial class Quản_lý_người_điều_trị
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
            this.cmbsx = new System.Windows.Forms.ComboBox();
            this.txbMndt = new System.Windows.Forms.TextBox();
            this.lvttsk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btndatetime = new System.Windows.Forms.Button();
            this.rdbGtnu = new System.Windows.Forms.RadioButton();
            this.rdbGtnam = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.lvcmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDc = new System.Windows.Forms.TextBox();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.lvdc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.txbCmnd = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbTndt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSua = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.lvstt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvgt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtc = new System.Windows.Forms.MonthCalendar();
            this.txbNs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbsx
            // 
            this.cmbsx.FormattingEnabled = true;
            this.cmbsx.Items.AddRange(new object[] {
            "Sắp xếp theo tên từ A đến Z",
            "Sắp xếp theo tên từ Z đến A",
            "Sắp xếp theo mã phòng",
            "Sắp xếp theo địa chỉ"});
            this.cmbsx.Location = new System.Drawing.Point(12, 106);
            this.cmbsx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbsx.Name = "cmbsx";
            this.cmbsx.Size = new System.Drawing.Size(201, 24);
            this.cmbsx.TabIndex = 17;
            this.cmbsx.Text = "Sắp xếp theo...";
            // 
            // txbMndt
            // 
            this.txbMndt.Location = new System.Drawing.Point(135, 30);
            this.txbMndt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMndt.Multiline = true;
            this.txbMndt.Name = "txbMndt";
            this.txbMndt.Size = new System.Drawing.Size(209, 29);
            this.txbMndt.TabIndex = 3;
            // 
            // lvttsk
            // 
            this.lvttsk.Text = "Địa chỉ";
            this.lvttsk.Width = 239;
            // 
            // btndatetime
            // 
            this.btndatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatetime.Location = new System.Drawing.Point(305, 127);
            this.btndatetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndatetime.Name = "btndatetime";
            this.btndatetime.Size = new System.Drawing.Size(49, 30);
            this.btndatetime.TabIndex = 27;
            this.btndatetime.Text = "...";
            this.btndatetime.UseVisualStyleBackColor = true;
            this.btndatetime.Click += new System.EventHandler(this.btndatetime_Click);
            // 
            // rdbGtnu
            // 
            this.rdbGtnu.AutoSize = true;
            this.rdbGtnu.Location = new System.Drawing.Point(212, 98);
            this.rdbGtnu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbGtnu.Name = "rdbGtnu";
            this.rdbGtnu.Size = new System.Drawing.Size(47, 21);
            this.rdbGtnu.TabIndex = 26;
            this.rdbGtnu.Text = "Nữ";
            this.rdbGtnu.UseVisualStyleBackColor = true;
            // 
            // rdbGtnam
            // 
            this.rdbGtnam.AutoSize = true;
            this.rdbGtnam.Checked = true;
            this.rdbGtnam.Location = new System.Drawing.Point(135, 98);
            this.rdbGtnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbGtnam.Name = "rdbGtnam";
            this.rdbGtnam.Size = new System.Drawing.Size(58, 21);
            this.rdbGtnam.TabIndex = 25;
            this.rdbGtnam.TabStop = true;
            this.rdbGtnam.Text = "Nam";
            this.rdbGtnam.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "SĐT:*";
            // 
            // lvcmnd
            // 
            this.lvcmnd.Text = "CMND";
            this.lvcmnd.Width = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = " Địa chỉ:* ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày sinh:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giới tính:*";
            // 
            // txbDc
            // 
            this.txbDc.Location = new System.Drawing.Point(509, 64);
            this.txbDc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDc.Multiline = true;
            this.txbDc.Name = "txbDc";
            this.txbDc.Size = new System.Drawing.Size(209, 29);
            this.txbDc.TabIndex = 12;
            // 
            // txbSdt
            // 
            this.txbSdt.Location = new System.Drawing.Point(509, 30);
            this.txbSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSdt.Multiline = true;
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(209, 29);
            this.txbSdt.TabIndex = 11;
            // 
            // lvdc
            // 
            this.lvdc.Text = "Số điện thoại";
            this.lvdc.Width = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "CMND: ";
            // 
            // txbCmnd
            // 
            this.txbCmnd.Location = new System.Drawing.Point(135, 162);
            this.txbCmnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCmnd.Multiline = true;
            this.txbCmnd.Name = "txbCmnd";
            this.txbCmnd.Size = new System.Drawing.Size(209, 29);
            this.txbCmnd.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(319, 207);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 30);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(9, 207);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbTndt
            // 
            this.txbTndt.Location = new System.Drawing.Point(135, 64);
            this.txbTndt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTndt.Multiline = true;
            this.txbTndt.Name = "txbTndt";
            this.txbTndt.Size = new System.Drawing.Size(209, 29);
            this.txbTndt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên người điều trị:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã người điều trị:*";
            // 
            // lvns
            // 
            this.lvns.Text = "Ngày sinh";
            this.lvns.Width = 126;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(165, 207);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 30);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvstt,
            this.lvmbn,
            this.lvtbn,
            this.lvgt,
            this.lvns,
            this.lvcmnd,
            this.lvdc,
            this.lvttsk});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(12, 138);
            this.lv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(1159, 365);
            this.lv.TabIndex = 16;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // lvstt
            // 
            this.lvstt.Text = "STT";
            this.lvstt.Width = 40;
            // 
            // lvmbn
            // 
            this.lvmbn.Text = "Mã người điều trị";
            this.lvmbn.Width = 149;
            // 
            // lvtbn
            // 
            this.lvtbn.Text = "Tên người điều trị";
            this.lvtbn.Width = 174;
            // 
            // lvgt
            // 
            this.lvgt.Text = "Giới tính";
            this.lvgt.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.mtc);
            this.groupBox1.Controls.Add(this.btndatetime);
            this.groupBox1.Controls.Add(this.rdbGtnu);
            this.groupBox1.Controls.Add(this.rdbGtnam);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txbMndt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbDc);
            this.groupBox1.Controls.Add(this.txbSdt);
            this.groupBox1.Controls.Add(this.txbCmnd);
            this.groupBox1.Controls.Add(this.txbNs);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txbTndt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 510);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1181, 242);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // mtc
            // 
            this.mtc.Location = new System.Drawing.Point(319, 0);
            this.mtc.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.mtc.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.mtc.Name = "mtc";
            this.mtc.TabIndex = 28;
            this.mtc.TodayDate = new System.DateTime(2021, 12, 11, 0, 0, 0, 0);
            this.mtc.Visible = false;
            this.mtc.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mtc_DateSelected_1);
            this.mtc.MouseLeave += new System.EventHandler(this.mtc_MouseLeave);
            // 
            // txbNs
            // 
            this.txbNs.Location = new System.Drawing.Point(135, 127);
            this.txbNs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNs.Multiline = true;
            this.txbNs.Name = "txbNs";
            this.txbNs.Size = new System.Drawing.Size(164, 29);
            this.txbNs.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản lý người điều trị";
            // 
            // Quản_lý_người_điều_trị
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbsx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Quản_lý_người_điều_trị";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_lý_người_điều_trị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quản_lý_người_điều_trị_FormClosing);
            this.Load += new System.EventHandler(this.Quản_lý_người_điều_trị_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbsx;
        private System.Windows.Forms.TextBox txbMndt;
        private System.Windows.Forms.ColumnHeader lvttsk;
        private System.Windows.Forms.Button btndatetime;
        private System.Windows.Forms.RadioButton rdbGtnu;
        private System.Windows.Forms.RadioButton rdbGtnam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader lvcmnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDc;
        private System.Windows.Forms.TextBox txbSdt;
        private System.Windows.Forms.ColumnHeader lvdc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCmnd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTndt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader lvns;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader lvstt;
        private System.Windows.Forms.ColumnHeader lvmbn;
        private System.Windows.Forms.ColumnHeader lvtbn;
        private System.Windows.Forms.ColumnHeader lvgt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbNs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mtc;
    }
}