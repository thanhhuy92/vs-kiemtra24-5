using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KiemTra24_4
{
    public partial class frmmonhoc : Form
    {
        public frmmonhoc()
        {
            InitializeComponent();
        }
        private void loadcb()
        {
            string sql = "Select * From KHOA";
            cmbmakhoa.DataSource = ketnoi.getdata(sql);
            cmbmakhoa.DisplayMember = "TenKhoa";
            cmbmakhoa.ValueMember = "MaKhoa";
        }

        private void loadgridview()
        {
            string sql = "Select * From MONHOC";
            dgvhienthi.DataSource = ketnoi.getdata(sql);
            dgvhienthi.Columns[0].HeaderText = "Mã Môn";
            dgvhienthi.Columns[1].HeaderText = "Tên Môn";
            //dgvhienthi.Columns[2].HeaderText = "Mã Khoa";
            dgvhienthi.Columns[3].HeaderText = "Số HP";
            dgvhienthi.Columns[4].HeaderText = "Giáo Viên";
            dgvhienthi.Columns[0].Width = 70;
            dgvhienthi.Columns[1].Width = 130;
            dgvhienthi.Columns[2].Width = 130;
            dgvhienthi.Columns[3].Width = 70;
            dgvhienthi.Columns[4].Width = 150;

        }
        private void frmmonhoc_Load(object sender, EventArgs e)
        {
            ketnoi.connect();
            loadgridview();
            loadcb();
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtmamon.Enabled = false;
            txttenmon.Enabled = false;
            cmbmakhoa.Enabled = false;
            txtsohocphan.Enabled = false;
            txtgiaovien.Enabled = false;
            btnthem.Visible = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            txtmamon.Enabled = true;
            txttenmon.Enabled = true;
            cmbmakhoa.Enabled = true;
            txtsohocphan.Enabled = true;
            txtgiaovien.Enabled = true;
            btnthem.Visible = true;
            btncapnhat.Visible = false;
        }

        private void dgvhienthi_Click(object sender, EventArgs e)
        {
            int id;
            id = dgvhienthi.CurrentCell.RowIndex;
            txtmamon.Text = dgvhienthi.Rows[id].Cells[0].Value.ToString();
            txttenmon.Text = dgvhienthi.Rows[id].Cells[1].Value.ToString();
            cmbmakhoa.SelectedValue = dgvhienthi.Rows[id].Cells[2].Value.ToString();
            txtsohocphan.Text = dgvhienthi.Rows[id].Cells[3].Value.ToString();
            txtgiaovien.Text = dgvhienthi.Rows[id].Cells[4].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            if (btnsua.Enabled == true && btnxoa.Enabled == true)
            {
                txtmamon.Enabled = true;
                txttenmon.Enabled = true;
                cmbmakhoa.Enabled = true;
                txtsohocphan.Enabled = true;
                txtgiaovien.Enabled = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM MONHOC WHERE MaMon='" + txtmamon.Text + "'";
            DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn xóa [ Tên Môn Học : " + txttenmon.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thanhcong == DialogResult.OK)
            {
                ketnoi.runsql(sql);
                MessageBox.Show("Xóa [ Tên Môn Học : " + txttenmon.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadgridview();
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtmamon.Enabled = false;
            txttenmon.Enabled = false;
            cmbmakhoa.Enabled = false;
            txtsohocphan.Enabled = false;
            txtgiaovien.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE MONHOC SET TenMon = '" + txttenmon.Text + "',MaKhoa = '" + cmbmakhoa.SelectedValue.ToString() + "',SoHocPhan ='" + txtsohocphan.Text + "',GiaoVien ='" + txtgiaovien.Text + "' WHERE MaMon = '" + txtmamon.Text + "'";
            DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn sửa [ Tên Môn Học : " + txttenmon.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thanhcong == DialogResult.OK)
            {
                ketnoi.runsql(sql);
                MessageBox.Show("Sửa [ Tên Môn Học : " + txttenmon.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadgridview();
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtmamon.Enabled = false;
            txttenmon.Enabled = false;
            cmbmakhoa.Enabled = false;
            txtsohocphan.Enabled = false;
            txtgiaovien.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string mamh = txtmamon.Text;

            string sql = "INSERT INTO MONHOC (MaMon,TenMon,MaKhoa,SoHocPhan,GiaoVien) VALUES('" + txtmamon.Text + "','" + txttenmon.Text + "','" + cmbmakhoa.SelectedValue.ToString() + "','" + txtsohocphan.Text + "','" + txtgiaovien.Text + "')";
            string sql1 = "SELECT *FROM MONHOC WHERE MONHOC.MaMon='" + mamh + "'";

            if (txtmamon.Text == "" && txttenmon.Text == "" && txtsohocphan.Text == "" && txtgiaovien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamon.Focus();
            }
            else if (txtmamon.Text == "" && txttenmon.Text == "" && txtsohocphan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin:\n" + "Mã Môn\n" + "Tên Môn\n" + "Số Học Phần", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiaovien.Focus();
            }
            else if (txttenmon.Text == "" && txtsohocphan.Text == "" && txtgiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin:\n" + "Tên Môn\n" + "Số Học Phần\n" + "Giáo Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmon.Focus();
            }
            else if (txtmamon.Text == "" && txtsohocphan.Text == "" && txtgiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin:\n" + "Mã Môn\n" + "Số Học Phần\n" + "Giáo Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamon.Focus();
            }
            else if (txtmamon.Text == "" && txttenmon.Text == "" && txtgiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin:\n" + "Mã Môn\n" + "Tên Môn\n" + "Giáo Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamon.Focus();
            }
            else if (txtmamon.Text == "" && txttenmon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin:\n" + "Mã Môn\n" + "Tên Môn\n", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamon.Focus();
            }
            else if (txtsohocphan.Text == "" && txtgiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin:\n" + "Số Học Phần\n" + "Giáo Viên\n", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsohocphan.Focus();
            }
            else if (txtmamon.Text == "" && txtgiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin:\n" + "Mã Môn\n" + "Giáo Viên\n", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamon.Focus();
            }
            else if (txttenmon.Text == "" && txtsohocphan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin:\n" + "Tên Môn\n" + "Số Học Phần\n", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmon.Focus();
            }
            else if (txtmamon.Text.Trim().Length == 0 || txtmamon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã môn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamon.Focus();
                return;
            }
            else if (txttenmon.Text.Trim().Length == 0 || txttenmon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên môn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmon.Focus();
                return;
            }
            else if (txtsohocphan.Text.Trim().Length == 0 || txtsohocphan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số học phần.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsohocphan.Focus();
                return;
            }
            else if (txtgiaovien.Text.Trim().Length == 0 || txtgiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giáo viên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiaovien.Focus();
                return;
            }
            else if (ketnoi.ktratrung(sql1))
            {
                MessageBox.Show("Mã [ " + txtmamon.Text + " ] đã có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamon.Clear();
                txtmamon.Focus();
            }
            else
            {
                DialogResult thanhcong = MessageBox.Show("Thêm [ Tên Môn : " + txttenmon.Text + " ] thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (thanhcong == DialogResult.OK)
                {
                    ketnoi.runsql(sql);
                }
            }
            //cmbmakhoa.ResetText();
            loadgridview();
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txtmamon.Enabled = false;
            txttenmon.Enabled = false;
            cmbmakhoa.Enabled = false;
            txtsohocphan.Enabled = false;
            txtgiaovien.Enabled = false;
            btnthem.Visible = false;
            btncapnhat.Visible = true;

        }
    }
}
