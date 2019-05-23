namespace KiemTra24_4
{
    partial class frmdiem
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
            this.lbmasv = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.lbmamh = new System.Windows.Forms.Label();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.lbdiem = new System.Windows.Forms.Label();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.lbtensv = new System.Windows.Forms.Label();
            this.lbngaysinh = new System.Windows.Forms.Label();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dgvdiem = new System.Windows.Forms.DataGridView();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoadiem = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnsuadiem = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmasv
            // 
            this.lbmasv.AutoSize = true;
            this.lbmasv.Location = new System.Drawing.Point(25, 42);
            this.lbmasv.Name = "lbmasv";
            this.lbmasv.Size = new System.Drawing.Size(39, 13);
            this.lbmasv.TabIndex = 0;
            this.lbmasv.Text = "Mã SV";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(95, 39);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(200, 20);
            this.txtmasv.TabIndex = 1;
            // 
            // txtmamh
            // 
            this.txtmamh.Location = new System.Drawing.Point(95, 65);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(200, 20);
            this.txtmamh.TabIndex = 3;
            // 
            // lbmamh
            // 
            this.lbmamh.AutoSize = true;
            this.lbmamh.Location = new System.Drawing.Point(25, 68);
            this.lbmamh.Name = "lbmamh";
            this.lbmamh.Size = new System.Drawing.Size(42, 13);
            this.lbmamh.TabIndex = 2;
            this.lbmamh.Text = "Mã MH";
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(95, 159);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(200, 20);
            this.txtdiem.TabIndex = 7;
            // 
            // lbdiem
            // 
            this.lbdiem.AutoSize = true;
            this.lbdiem.Location = new System.Drawing.Point(25, 162);
            this.lbdiem.Name = "lbdiem";
            this.lbdiem.Size = new System.Drawing.Size(31, 13);
            this.lbdiem.TabIndex = 6;
            this.lbdiem.Text = "Điểm";
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(95, 91);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(200, 20);
            this.txttensv.TabIndex = 5;
            // 
            // lbtensv
            // 
            this.lbtensv.AutoSize = true;
            this.lbtensv.Location = new System.Drawing.Point(25, 94);
            this.lbtensv.Name = "lbtensv";
            this.lbtensv.Size = new System.Drawing.Size(43, 13);
            this.lbtensv.TabIndex = 4;
            this.lbtensv.Text = "Tên SV";
            // 
            // lbngaysinh
            // 
            this.lbngaysinh.AutoSize = true;
            this.lbngaysinh.Location = new System.Drawing.Point(25, 128);
            this.lbngaysinh.Name = "lbngaysinh";
            this.lbngaysinh.Size = new System.Drawing.Size(56, 13);
            this.lbngaysinh.TabIndex = 8;
            this.lbngaysinh.Text = "Ngày Sinh";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(95, 122);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtpngaysinh.TabIndex = 9;
            // 
            // dgvdiem
            // 
            this.dgvdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdiem.Location = new System.Drawing.Point(28, 261);
            this.dgvdiem.Name = "dgvdiem";
            this.dgvdiem.Size = new System.Drawing.Size(561, 150);
            this.dgvdiem.TabIndex = 10;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(449, 37);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(116, 23);
            this.btncapnhat.TabIndex = 11;
            this.btncapnhat.Text = "Cập Nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoadiem
            // 
            this.btnxoadiem.Location = new System.Drawing.Point(449, 68);
            this.btnxoadiem.Name = "btnxoadiem";
            this.btnxoadiem.Size = new System.Drawing.Size(116, 23);
            this.btnxoadiem.TabIndex = 12;
            this.btnxoadiem.Text = "Xóa Điểm";
            this.btnxoadiem.UseVisualStyleBackColor = true;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(449, 126);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(116, 23);
            this.btntimkiem.TabIndex = 14;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            // 
            // btnsuadiem
            // 
            this.btnsuadiem.Location = new System.Drawing.Point(449, 97);
            this.btnsuadiem.Name = "btnsuadiem";
            this.btnsuadiem.Size = new System.Drawing.Size(116, 23);
            this.btnsuadiem.TabIndex = 13;
            this.btnsuadiem.Text = "Sửa Điểm";
            this.btnsuadiem.UseVisualStyleBackColor = true;
            // 
            // btnin
            // 
            this.btnin.Location = new System.Drawing.Point(449, 155);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(116, 23);
            this.btnin.TabIndex = 15;
            this.btnin.Text = "In";
            this.btnin.UseVisualStyleBackColor = true;
            // 
            // frmdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnsuadiem);
            this.Controls.Add(this.btnxoadiem);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.dgvdiem);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.lbngaysinh);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.lbdiem);
            this.Controls.Add(this.txttensv);
            this.Controls.Add(this.lbtensv);
            this.Controls.Add(this.txtmamh);
            this.Controls.Add(this.lbmamh);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.lbmasv);
            this.Name = "frmdiem";
            this.Text = "FormDiem";
            this.Load += new System.EventHandler(this.frmdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmasv;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txtmamh;
        private System.Windows.Forms.Label lbmamh;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.Label lbdiem;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.Label lbtensv;
        private System.Windows.Forms.Label lbngaysinh;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.DataGridView dgvdiem;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoadiem;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnsuadiem;
        private System.Windows.Forms.Button btnin;
    }
}