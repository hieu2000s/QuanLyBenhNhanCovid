namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    partial class Quản_lý_bệnh_nhân
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txbTbn = new System.Windows.Forms.TextBox();
            this.txbMbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtc = new System.Windows.Forms.MonthCalendar();
            this.btndatetime = new System.Windows.Forms.Button();
            this.rdbGtnu = new System.Windows.Forms.RadioButton();
            this.rdbGtnam = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbTngh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbMpdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbTtsk = new System.Windows.Forms.TextBox();
            this.txbDc = new System.Windows.Forms.TextBox();
            this.txbCmnd = new System.Windows.Forms.TextBox();
            this.txbNs = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.lvstt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvgt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcmnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvdc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvttsk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvemail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvsdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtngh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbsx = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(319, 207);
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
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txbTbn
            // 
            this.txbTbn.Location = new System.Drawing.Point(135, 64);
            this.txbTbn.Multiline = true;
            this.txbTbn.Name = "txbTbn";
            this.txbTbn.Size = new System.Drawing.Size(210, 29);
            this.txbTbn.TabIndex = 4;
            // 
            // txbMbn
            // 
            this.txbMbn.Location = new System.Drawing.Point(135, 29);
            this.txbMbn.Multiline = true;
            this.txbMbn.Name = "txbMbn";
            this.txbMbn.Size = new System.Drawing.Size(210, 29);
            this.txbMbn.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên người giám hộ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên bệnh nhân:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã bệnh nhân:*";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.mtc);
            this.groupBox1.Controls.Add(this.btndatetime);
            this.groupBox1.Controls.Add(this.rdbGtnu);
            this.groupBox1.Controls.Add(this.rdbGtnam);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txbMbn);
            this.groupBox1.Controls.Add(this.txbTngh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txbMpdt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbSdt);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.txbTtsk);
            this.groupBox1.Controls.Add(this.txbDc);
            this.groupBox1.Controls.Add(this.txbCmnd);
            this.groupBox1.Controls.Add(this.txbNs);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txbTbn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 509);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 243);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // mtc
            // 
            this.mtc.Location = new System.Drawing.Point(357, 36);
            this.mtc.Name = "mtc";
            this.mtc.TabIndex = 28;
            this.mtc.Visible = false;
            this.mtc.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mtc_DateSelected);
            this.mtc.MouseLeave += new System.EventHandler(this.mtc_MouseLeave);
            // 
            // btndatetime
            // 
            this.btndatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatetime.Location = new System.Drawing.Point(296, 127);
            this.btndatetime.Name = "btndatetime";
            this.btndatetime.Size = new System.Drawing.Size(49, 29);
            this.btndatetime.TabIndex = 27;
            this.btndatetime.Text = "...";
            this.btndatetime.UseVisualStyleBackColor = true;
            this.btndatetime.Click += new System.EventHandler(this.btndatetime_Click);
            // 
            // rdbGtnu
            // 
            this.rdbGtnu.AutoSize = true;
            this.rdbGtnu.Location = new System.Drawing.Point(212, 99);
            this.rdbGtnu.Name = "rdbGtnu";
            this.rdbGtnu.Size = new System.Drawing.Size(47, 21);
            this.rdbGtnu.TabIndex = 26;
            this.rdbGtnu.Text = "Nữ";
            this.rdbGtnu.UseVisualStyleBackColor = true;
            this.rdbGtnu.CheckedChanged += new System.EventHandler(this.rdbGtnu_CheckedChanged);
            // 
            // rdbGtnam
            // 
            this.rdbGtnam.AutoSize = true;
            this.rdbGtnam.Checked = true;
            this.rdbGtnam.Location = new System.Drawing.Point(135, 99);
            this.rdbGtnam.Name = "rdbGtnam";
            this.rdbGtnam.Size = new System.Drawing.Size(58, 21);
            this.rdbGtnam.TabIndex = 25;
            this.rdbGtnam.TabStop = true;
            this.rdbGtnam.Text = "Nam";
            this.rdbGtnam.UseVisualStyleBackColor = true;
            this.rdbGtnam.CheckedChanged += new System.EventHandler(this.rdbGtnam_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(737, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Mã phòng điều trị:*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Địa chỉ:*";
            // 
            // txbTngh
            // 
            this.txbTngh.Location = new System.Drawing.Point(510, 170);
            this.txbTngh.Multiline = true;
            this.txbTngh.Name = "txbTngh";
            this.txbTngh.Size = new System.Drawing.Size(210, 29);
            this.txbTngh.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Email: ";
            // 
            // txbMpdt
            // 
            this.txbMpdt.Location = new System.Drawing.Point(870, 29);
            this.txbMpdt.Multiline = true;
            this.txbMpdt.Name = "txbMpdt";
            this.txbMpdt.Size = new System.Drawing.Size(210, 29);
            this.txbMpdt.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "SĐT / SĐT NGH:*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tình trạng sức khỏe:* ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "CMND: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giới tính:*";
            // 
            // txbSdt
            // 
            this.txbSdt.Location = new System.Drawing.Point(510, 135);
            this.txbSdt.Multiline = true;
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(210, 29);
            this.txbSdt.TabIndex = 14;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(510, 99);
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(210, 29);
            this.txbEmail.TabIndex = 13;
            // 
            // txbTtsk
            // 
            this.txbTtsk.Location = new System.Drawing.Point(510, 64);
            this.txbTtsk.Multiline = true;
            this.txbTtsk.Name = "txbTtsk";
            this.txbTtsk.Size = new System.Drawing.Size(210, 29);
            this.txbTtsk.TabIndex = 12;
            // 
            // txbDc
            // 
            this.txbDc.Location = new System.Drawing.Point(510, 29);
            this.txbDc.Multiline = true;
            this.txbDc.Name = "txbDc";
            this.txbDc.Size = new System.Drawing.Size(210, 29);
            this.txbDc.TabIndex = 11;
            // 
            // txbCmnd
            // 
            this.txbCmnd.Location = new System.Drawing.Point(135, 162);
            this.txbCmnd.Multiline = true;
            this.txbCmnd.Name = "txbCmnd";
            this.txbCmnd.Size = new System.Drawing.Size(210, 29);
            this.txbCmnd.TabIndex = 10;
            // 
            // txbNs
            // 
            this.txbNs.Location = new System.Drawing.Point(135, 127);
            this.txbNs.Multiline = true;
            this.txbNs.Name = "txbNs";
            this.txbNs.ReadOnly = true;
            this.txbNs.Size = new System.Drawing.Size(164, 29);
            this.txbNs.TabIndex = 9;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(166, 207);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 30);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý bệnh nhân";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.lvttsk,
            this.lvemail,
            this.lvsdt,
            this.lvtngh,
            this.lvmp});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(12, 138);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(1158, 365);
            this.lv.TabIndex = 10;
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
            this.lvmbn.Text = "Mã bệnh nhân";
            this.lvmbn.Width = 44;
            // 
            // lvtbn
            // 
            this.lvtbn.Text = "Tên bệnh nhân";
            this.lvtbn.Width = 140;
            // 
            // lvgt
            // 
            this.lvgt.Text = "Giới tính";
            this.lvgt.Width = 70;
            // 
            // lvns
            // 
            this.lvns.Text = "Ngày sinh";
            this.lvns.Width = 91;
            // 
            // lvcmnd
            // 
            this.lvcmnd.Text = "CMND";
            this.lvcmnd.Width = 74;
            // 
            // lvdc
            // 
            this.lvdc.Text = "Địa chỉ";
            this.lvdc.Width = 96;
            // 
            // lvttsk
            // 
            this.lvttsk.Text = "Tình trạng sức khỏe";
            this.lvttsk.Width = 107;
            // 
            // lvemail
            // 
            this.lvemail.Text = "Email";
            this.lvemail.Width = 76;
            // 
            // lvsdt
            // 
            this.lvsdt.Text = "SĐT/ SĐT NGH";
            this.lvsdt.Width = 98;
            // 
            // lvtngh
            // 
            this.lvtngh.Text = "Tên người giám hộ";
            this.lvtngh.Width = 139;
            // 
            // lvmp
            // 
            this.lvmp.Text = "Mã phòng";
            this.lvmp.Width = 112;
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
            this.cmbsx.Name = "cmbsx";
            this.cmbsx.Size = new System.Drawing.Size(287, 24);
            this.cmbsx.TabIndex = 11;
            this.cmbsx.Text = "Sắp xếp theo...";
            this.cmbsx.SelectedIndexChanged += new System.EventHandler(this.cmbsx_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1182, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Quản_lý_bệnh_nhân
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbsx);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Quản_lý_bệnh_nhân";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_lý_bệnh_nhân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quản_lý_bệnh_nhân_FormClosing);
            this.Load += new System.EventHandler(this.Quản_lý_bệnh_nhân_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txbTbn;
        private System.Windows.Forms.TextBox txbMbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbGtnu;
        private System.Windows.Forms.RadioButton rdbGtnam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbMpdt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbTngh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSdt;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbTtsk;
        private System.Windows.Forms.TextBox txbDc;
        private System.Windows.Forms.TextBox txbCmnd;
        private System.Windows.Forms.TextBox txbNs;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader lvstt;
        private System.Windows.Forms.ColumnHeader lvmbn;
        private System.Windows.Forms.ColumnHeader lvtbn;
        private System.Windows.Forms.ColumnHeader lvgt;
        private System.Windows.Forms.ColumnHeader lvns;
        private System.Windows.Forms.ColumnHeader lvcmnd;
        private System.Windows.Forms.ColumnHeader lvdc;
        private System.Windows.Forms.ColumnHeader lvttsk;
        private System.Windows.Forms.ColumnHeader lvemail;
        private System.Windows.Forms.ColumnHeader lvsdt;
        private System.Windows.Forms.ColumnHeader lvtngh;
        private System.Windows.Forms.ColumnHeader lvmp;
        private System.Windows.Forms.Button btndatetime;
        private System.Windows.Forms.MonthCalendar mtc;
        private System.Windows.Forms.ComboBox cmbsx;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}