namespace Hệ_thống_quản_lý_bệnh_nhân_covid_19
{
    partial class Đăng_nhập
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbtdn = new System.Windows.Forms.TextBox();
            this.txbmk = new System.Windows.Forms.TextBox();
            this.btndn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng bạn đến với hệ thống quản lý bệnh nhân COVID 19";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài khoản: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu: ";
            // 
            // txbtdn
            // 
            this.txbtdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtdn.Location = new System.Drawing.Point(194, 122);
            this.txbtdn.Name = "txbtdn";
            this.txbtdn.Size = new System.Drawing.Size(271, 28);
            this.txbtdn.TabIndex = 40;
            this.txbtdn.Text = "hungdeptrai";
            // 
            // txbmk
            // 
            this.txbmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbmk.Location = new System.Drawing.Point(194, 190);
            this.txbmk.Name = "txbmk";
            this.txbmk.PasswordChar = '*';
            this.txbmk.Size = new System.Drawing.Size(271, 28);
            this.txbmk.TabIndex = 41;
            this.txbmk.Text = "123456";
            // 
            // btndn
            // 
            this.btndn.Location = new System.Drawing.Point(121, 265);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(385, 37);
            this.btndn.TabIndex = 42;
            this.btndn.Text = "Đăng nhập";
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // Đăng_nhập
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 351);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.txbmk);
            this.Controls.Add(this.txbtdn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Đăng_nhập";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng_nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Đăng_nhập_FormClosing);
            this.Load += new System.EventHandler(this.Đăng_nhập_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbtdn;
        private System.Windows.Forms.TextBox txbmk;
        private System.Windows.Forms.Button btndn;
    }
}