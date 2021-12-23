namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    partial class Quản_lý_lịch_sử_điều_trị
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
            System.Windows.Forms.ColumnHeader lvsoluong;
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.lvstt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmpdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvtkvdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.rtblsdt = new System.Windows.Forms.TextBox();
            this.txbmbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndatetime = new System.Windows.Forms.Button();
            this.txbtg = new System.Windows.Forms.TextBox();
            this.txbmndt = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mtc = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.idLsdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            lvsoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvsoluong
            // 
            lvsoluong.Text = "Lịch sử điều trị:*";
            lvsoluong.Width = 215;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lịch sử điều trị:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thời gian:*";
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvstt,
            this.idLsdt,
            this.lvmpdt,
            this.lvtkvdt,
            this.lvmt,
            lvsoluong});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(12, 186);
            this.lv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(716, 495);
            this.lv.TabIndex = 21;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // lvstt
            // 
            this.lvstt.Text = "STT";
            this.lvstt.Width = 35;
            // 
            // lvmpdt
            // 
            this.lvmpdt.Text = "Mã bệnh nhân";
            this.lvmpdt.Width = 90;
            // 
            // lvtkvdt
            // 
            this.lvtkvdt.Text = "Mã người điều trị:*";
            this.lvtkvdt.Width = 105;
            // 
            // lvmt
            // 
            this.lvmt.Text = "Thời gian:*";
            this.lvmt.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.rtblsdt);
            this.groupBox1.Controls.Add(this.txbmbn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btndatetime);
            this.groupBox1.Controls.Add(this.txbtg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbmndt);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(744, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(427, 560);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(75, 235);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(256, 29);
            this.tbID.TabIndex = 33;
            this.tbID.Visible = false;
            // 
            // rtblsdt
            // 
            this.rtblsdt.Location = new System.Drawing.Point(153, 192);
            this.rtblsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtblsdt.Multiline = true;
            this.rtblsdt.Name = "rtblsdt";
            this.rtblsdt.Size = new System.Drawing.Size(256, 285);
            this.rtblsdt.TabIndex = 32;
            // 
            // txbmbn
            // 
            this.txbmbn.Location = new System.Drawing.Point(153, 27);
            this.txbmbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbmbn.Multiline = true;
            this.txbmbn.Name = "txbmbn";
            this.txbmbn.Size = new System.Drawing.Size(256, 29);
            this.txbmbn.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mã bệnh nhân:*";
            // 
            // btndatetime
            // 
            this.btndatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndatetime.Location = new System.Drawing.Point(360, 135);
            this.btndatetime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndatetime.Name = "btndatetime";
            this.btndatetime.Size = new System.Drawing.Size(49, 30);
            this.btndatetime.TabIndex = 29;
            this.btndatetime.Text = "...";
            this.btndatetime.UseVisualStyleBackColor = true;
            this.btndatetime.Click += new System.EventHandler(this.btndatetime_Click);
            // 
            // txbtg
            // 
            this.txbtg.Location = new System.Drawing.Point(153, 135);
            this.txbtg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtg.Multiline = true;
            this.txbtg.Name = "txbtg";
            this.txbtg.Size = new System.Drawing.Size(201, 29);
            this.txbtg.TabIndex = 28;
            // 
            // txbmndt
            // 
            this.txbmndt.Location = new System.Drawing.Point(153, 84);
            this.txbmndt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbmndt.Multiline = true;
            this.txbmndt.Name = "txbmndt";
            this.txbmndt.Size = new System.Drawing.Size(256, 29);
            this.txbmndt.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(292, 497);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 47);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(153, 497);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 47);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(15, 497);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 47);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã người điều trị:*";
            // 
            // mtc
            // 
            this.mtc.Location = new System.Drawing.Point(533, 383);
            this.mtc.Name = "mtc";
            this.mtc.TabIndex = 22;
            this.mtc.Visible = false;
            this.mtc.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mtc_DateSelected);
            this.mtc.MouseLeave += new System.EventHandler(this.mtc_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản lý lịch sử điều trị";
            // 
            // idLsdt
            // 
            this.idLsdt.Text = "Mã lịch sử điều trị";
            this.idLsdt.Width = 136;
            // 
            // Quản_lý_lịch_sử_điều_trị
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 753);
            this.Controls.Add(this.mtc);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Quản_lý_lịch_sử_điều_trị";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch sử điều trị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quản_lý_lịch_sử_điều_trị_FormClosing);
            this.Load += new System.EventHandler(this.Quản_lý_lịch_sử_điều_trị_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader lvstt;
        private System.Windows.Forms.ColumnHeader lvmpdt;
        private System.Windows.Forms.ColumnHeader lvtkvdt;
        private System.Windows.Forms.ColumnHeader lvmt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbmndt;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndatetime;
        private System.Windows.Forms.TextBox txbtg;
        private System.Windows.Forms.MonthCalendar mtc;
        private System.Windows.Forms.TextBox txbmbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rtblsdt;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ColumnHeader idLsdt;
    }
}