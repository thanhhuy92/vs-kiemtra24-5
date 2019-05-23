using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra24_4
{
    public partial class frmdiem : Form
    {
        public frmdiem()
        {
            InitializeComponent();
        }

        private void loadgridview()
        {
            string sql = "select DIEM.MaSV,DIEM.MaMon,SINHVIEN.HoTen,SINHVIEN.NgaySinh,DIEM.Diem from DIEM join SINHVIEN on DIEM.MaSV = SINHVIEN.MaSV";
            dgvdiem.DataSource = ketnoi.getdata(sql);
            dgvdiem.Columns[0].HeaderText = "Mã SV";
            dgvdiem.Columns[1].HeaderText = "Mã Môn";
            dgvdiem.Columns[2].HeaderText = "Họ Tên";
            dgvdiem.Columns[3].HeaderText = "Ngày Sinh";
            dgvdiem.Columns[4].HeaderText = "Điểm";

            dgvdiem.Columns[0].Width = 80;
            dgvdiem.Columns[1].Width = 80;
            dgvdiem.Columns[2].Width = 120;
            dgvdiem.Columns[3].Width = 100;
            dgvdiem.Columns[4].Width = 80;
        }

        private void frmdiem_Load(object sender, EventArgs e)
        {
            ketnoi.connect();
            loadgridview();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string sql = "";
        }
    }
}
