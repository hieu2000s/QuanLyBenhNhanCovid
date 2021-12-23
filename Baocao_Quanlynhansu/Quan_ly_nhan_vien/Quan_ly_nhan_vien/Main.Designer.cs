namespace Quan_ly_nhan_vien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnulogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuql = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlcv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlhd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlnv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqltk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqltd = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnulogout,
            this.mnulogin,
            this.mnuShow});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(660, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(159, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnulogout
            // 
            this.mnulogout.Name = "mnulogout";
            this.mnulogout.Size = new System.Drawing.Size(89, 24);
            this.mnulogout.Text = "Đăng xuất";
            this.mnulogout.Visible = false;
            this.mnulogout.Click += new System.EventHandler(this.mnulogout_Click);
            // 
            // mnulogin
            // 
            this.mnulogin.Name = "mnulogin";
            this.mnulogin.Size = new System.Drawing.Size(94, 24);
            this.mnulogin.Text = "Đăng nhập";
            this.mnulogin.Click += new System.EventHandler(this.mnulogin_Click);
            // 
            // mnuShow
            // 
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(55, 24);
            this.mnuShow.Text = "show";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuql});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // mnuql
            // 
            this.mnuql.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuqlcv,
            this.mnuqlhd,
            this.mnuqll,
            this.mnuqlnv,
            this.mnuqlp,
            this.mnuqltk,
            this.mnuqltd});
            this.mnuql.Enabled = false;
            this.mnuql.Name = "mnuql";
            this.mnuql.Size = new System.Drawing.Size(71, 24);
            this.mnuql.Text = "Quản lý";
            // 
            // mnuqlcv
            // 
            this.mnuqlcv.Name = "mnuqlcv";
            this.mnuqlcv.Size = new System.Drawing.Size(152, 26);
            this.mnuqlcv.Text = "Chức vụ";
            this.mnuqlcv.Click += new System.EventHandler(this.mnuqlcv_Click);
            // 
            // mnuqlhd
            // 
            this.mnuqlhd.Name = "mnuqlhd";
            this.mnuqlhd.Size = new System.Drawing.Size(152, 26);
            this.mnuqlhd.Text = "Hợp đồng";
            this.mnuqlhd.Click += new System.EventHandler(this.mnuqlhd_Click);
            // 
            // mnuqll
            // 
            this.mnuqll.Name = "mnuqll";
            this.mnuqll.Size = new System.Drawing.Size(152, 26);
            this.mnuqll.Text = "Lương";
            this.mnuqll.Click += new System.EventHandler(this.mnuqll_Click);
            // 
            // mnuqlnv
            // 
            this.mnuqlnv.Name = "mnuqlnv";
            this.mnuqlnv.Size = new System.Drawing.Size(152, 26);
            this.mnuqlnv.Text = "Nhân viên";
            this.mnuqlnv.Click += new System.EventHandler(this.mnuqlnv_Click);
            // 
            // mnuqlp
            // 
            this.mnuqlp.Name = "mnuqlp";
            this.mnuqlp.Size = new System.Drawing.Size(152, 26);
            this.mnuqlp.Text = "Phòng";
            this.mnuqlp.Click += new System.EventHandler(this.mnuqlp_Click);
            // 
            // mnuqltk
            // 
            this.mnuqltk.Name = "mnuqltk";
            this.mnuqltk.Size = new System.Drawing.Size(152, 26);
            this.mnuqltk.Text = "Tài khoản";
            this.mnuqltk.Visible = false;
            this.mnuqltk.Click += new System.EventHandler(this.mnuqltk_Click);
            // 
            // mnuqltd
            // 
            this.mnuqltd.Name = "mnuqltd";
            this.mnuqltd.Size = new System.Drawing.Size(152, 26);
            this.mnuqltd.Text = "Trình độ";
            this.mnuqltd.Click += new System.EventHandler(this.mnuqltd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(187, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(651, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hệ thống quản lý";
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(240, 76);
            this.cc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(395, 65);
            this.cc.TabIndex = 5;
            this.cc.Text = "button1";
            this.cc.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnulogout;
        private System.Windows.Forms.ToolStripMenuItem mnulogin;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuql;
        private System.Windows.Forms.ToolStripMenuItem mnuqlcv;
        private System.Windows.Forms.ToolStripMenuItem mnuqlhd;
        private System.Windows.Forms.ToolStripMenuItem mnuqll;
        private System.Windows.Forms.ToolStripMenuItem mnuqlnv;
        private System.Windows.Forms.ToolStripMenuItem mnuqlp;
        private System.Windows.Forms.ToolStripMenuItem mnuqltk;
        private System.Windows.Forms.ToolStripMenuItem mnuqltd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.Button cc;
    }
}