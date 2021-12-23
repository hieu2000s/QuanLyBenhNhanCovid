namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    partial class Quản_lý_phòng_điều_trị
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
            this.lvmt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvmpdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvstt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv = new System.Windows.Forms.ListView();
            this.lvtkvdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvsoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.cmbtkvdt = new System.Windows.Forms.ComboBox();
            this.txbSlg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTpdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvmt
            // 
            this.lvmt.Text = "Tên khu vực điều trị";
            this.lvmt.Width = 175;
            // 
            // lvmpdt
            // 
            this.lvmpdt.Text = "Mã phòng điều trị";
            this.lvmpdt.Width = 100;
            // 
            // lvstt
            // 
            this.lvstt.Text = "STT";
            this.lvstt.Width = 42;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvstt,
            this.lvmpdt,
            this.lvtkvdt,
            this.lvmt,
            this.lvsoluong});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(12, 171);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(716, 495);
            this.lv.TabIndex = 16;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            // 
            // lvtkvdt
            // 
            this.lvtkvdt.Text = "Tên phòng điều trị";
            this.lvtkvdt.Width = 100;
            // 
            // lvsoluong
            // 
            this.lvsoluong.Text = "Số lượng giường";
            this.lvsoluong.Width = 109;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(292, 497);
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
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên phòng điều trị:*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbId);
            this.groupBox1.Controls.Add(this.cmbtkvdt);
            this.groupBox1.Controls.Add(this.txbSlg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbTpdt);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(744, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 560);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(153, 135);
            this.txbId.Multiline = true;
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(256, 29);
            this.txbId.TabIndex = 17;
            this.txbId.Visible = false;
            // 
            // cmbtkvdt
            // 
            this.cmbtkvdt.FormattingEnabled = true;
            this.cmbtkvdt.Location = new System.Drawing.Point(153, 82);
            this.cmbtkvdt.Name = "cmbtkvdt";
            this.cmbtkvdt.Size = new System.Drawing.Size(256, 24);
            this.cmbtkvdt.TabIndex = 16;
            this.cmbtkvdt.SelectedIndexChanged += new System.EventHandler(this.cmbtkvdt_SelectedIndexChanged);
            // 
            // txbSlg
            // 
            this.txbSlg.Location = new System.Drawing.Point(153, 135);
            this.txbSlg.Multiline = true;
            this.txbSlg.Name = "txbSlg";
            this.txbSlg.Size = new System.Drawing.Size(256, 29);
            this.txbSlg.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng giường:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khu vực điều trị:*";
            // 
            // txbTpdt
            // 
            this.txbTpdt.Location = new System.Drawing.Point(153, 32);
            this.txbTpdt.Multiline = true;
            this.txbTpdt.Name = "txbTpdt";
            this.txbTpdt.Size = new System.Drawing.Size(256, 29);
            this.txbTpdt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quản lý phòng điều trị";
            // 
            // Quản_lý_phòng_điều_trị
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Quản_lý_phòng_điều_trị";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_lý_phòng_điều_trị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quản_lý_phòng_điều_trị_FormClosing);
            this.Load += new System.EventHandler(this.Quản_lý_phòng_điều_trị_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader lvmt;
        private System.Windows.Forms.ColumnHeader lvmpdt;
        private System.Windows.Forms.ColumnHeader lvstt;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader lvtkvdt;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader lvsoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTpdt;
        private System.Windows.Forms.TextBox txbSlg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbtkvdt;
        private System.Windows.Forms.TextBox txbId;
    }
}