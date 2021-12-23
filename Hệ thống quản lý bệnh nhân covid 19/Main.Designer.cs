namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    partial class Main
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
            this.mns2 = new System.Windows.Forms.MenuStrip();
            this.mnsdx = new System.Windows.Forms.ToolStripMenuItem();
            this.mns1 = new System.Windows.Forms.MenuStrip();
            this.mnsql = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsqlkvdt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsqlpdt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsqlndt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsqlbn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsqllsdt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsqltk = new System.Windows.Forms.ToolStripMenuItem();
            this.mns2.SuspendLayout();
            this.mns1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns2
            // 
            this.mns2.Dock = System.Windows.Forms.DockStyle.None;
            this.mns2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsdx});
            this.mns2.Location = new System.Drawing.Point(881, 0);
            this.mns2.Name = "mns2";
            this.mns2.Size = new System.Drawing.Size(111, 31);
            this.mns2.TabIndex = 16;
            this.mns2.Text = "menuStrip1";
            // 
            // mnsdx
            // 
            this.mnsdx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnsdx.Name = "mnsdx";
            this.mnsdx.Size = new System.Drawing.Size(103, 27);
            this.mnsdx.Text = "Đăng xuất";
            this.mnsdx.Click += new System.EventHandler(this.mnsdx_Click);
            // 
            // mns1
            // 
            this.mns1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mns1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsql});
            this.mns1.Location = new System.Drawing.Point(0, 0);
            this.mns1.Name = "mns1";
            this.mns1.Size = new System.Drawing.Size(1182, 31);
            this.mns1.TabIndex = 17;
            this.mns1.Text = "menuStrip2";
            // 
            // mnsql
            // 
            this.mnsql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsqlkvdt,
            this.mnsqlpdt,
            this.mnsqlndt,
            this.mnsqlbn,
            this.mnsqllsdt,
            this.mnsqltk});
            this.mnsql.Name = "mnsql";
            this.mnsql.Size = new System.Drawing.Size(83, 27);
            this.mnsql.Text = "Quản lý";
            // 
            // mnsqlkvdt
            // 
            this.mnsqlkvdt.Name = "mnsqlkvdt";
            this.mnsqlkvdt.Size = new System.Drawing.Size(276, 28);
            this.mnsqlkvdt.Text = "Quản lý khu vực điều trị";
            this.mnsqlkvdt.Click += new System.EventHandler(this.mnsqlkvdt_Click);
            // 
            // mnsqlpdt
            // 
            this.mnsqlpdt.Name = "mnsqlpdt";
            this.mnsqlpdt.Size = new System.Drawing.Size(276, 28);
            this.mnsqlpdt.Text = "Quản lý phòng điều trị";
            this.mnsqlpdt.Click += new System.EventHandler(this.mnqlpdt_Click);
            // 
            // mnsqlndt
            // 
            this.mnsqlndt.Name = "mnsqlndt";
            this.mnsqlndt.Size = new System.Drawing.Size(276, 28);
            this.mnsqlndt.Text = "Quản lý người điều trị";
            this.mnsqlndt.Click += new System.EventHandler(this.mnsqlndt_Click);
            // 
            // mnsqlbn
            // 
            this.mnsqlbn.Name = "mnsqlbn";
            this.mnsqlbn.Size = new System.Drawing.Size(276, 28);
            this.mnsqlbn.Text = "Quản lý bệnh nhân";
            this.mnsqlbn.Click += new System.EventHandler(this.mnsqlbn_Click);
            // 
            // mnsqllsdt
            // 
            this.mnsqllsdt.Name = "mnsqllsdt";
            this.mnsqllsdt.Size = new System.Drawing.Size(276, 28);
            this.mnsqllsdt.Text = "Quản lý lịch sử điều trị";
            this.mnsqllsdt.Click += new System.EventHandler(this.mnsqllsdt_Click);
            // 
            // mnsqltk
            // 
            this.mnsqltk.Name = "mnsqltk";
            this.mnsqltk.Size = new System.Drawing.Size(276, 28);
            this.mnsqltk.Text = "Quản lý tài khoản";
            this.mnsqltk.Click += new System.EventHandler(this.mnsqltk_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.mns2);
            this.Controls.Add(this.mns1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.mns2.ResumeLayout(false);
            this.mns2.PerformLayout();
            this.mns1.ResumeLayout(false);
            this.mns1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns2;
        private System.Windows.Forms.MenuStrip mns1;
        private System.Windows.Forms.ToolStripMenuItem mnsql;
        private System.Windows.Forms.ToolStripMenuItem mnsqlkvdt;
        private System.Windows.Forms.ToolStripMenuItem mnsqlpdt;
        private System.Windows.Forms.ToolStripMenuItem mnsqlndt;
        private System.Windows.Forms.ToolStripMenuItem mnsqlbn;
        private System.Windows.Forms.ToolStripMenuItem mnsqllsdt;
        private System.Windows.Forms.ToolStripMenuItem mnsqltk;
        private System.Windows.Forms.ToolStripMenuItem mnsdx;
    }
}