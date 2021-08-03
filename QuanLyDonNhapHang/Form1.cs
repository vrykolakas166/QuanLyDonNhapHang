using QuanLyDonNhapHang.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDonNhapHang
{
    public partial class FormQuanLyDonNhapHang : Form
    {
        List<PhieuNhap> li = new List<PhieuNhap>();
        List<Sach> li1 = new List<Sach>();
        public FormQuanLyDonNhapHang()
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            dtpBD.CustomFormat = "dd/MM/yyyy";
            dtpKT.CustomFormat = "dd/MM/yyyy";
            dgvDS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ExampleData();
        }
        private void ExampleData()
        {
            PhieuNhap a1 = new PhieuNhap("1", "Công ty ABC", "06/12/2020", "1");
            PhieuNhap a2 = new PhieuNhap("2", "Công ty DEF", "02/11/2020", "2");
            PhieuNhap a3 = new PhieuNhap("3", "Công ty XYZ", "03/07/2020", "3");
            li.Add(a1);
            li.Add(a2);
            li.Add(a3);
            Sach b1 = new Sach("Sách A", 5, 200000);
            Sach b2 = new Sach("Sách B", 2, 200000);
            li1.Add(b1);
            li1.Add(b2);
        }
        private void ShowData()
        {
            dgvDS.DataSource = li;
            dgvDS.Columns[0].HeaderText = "Mã phiếu";
            dgvDS.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvDS.Columns[2].HeaderText = "Ngày nhập";
            dgvDS.Columns[3].HeaderText = "Mã đơn hàng đặt";
        }
        private void ShowData1()
        {
            dgvCT.DataSource = li1;
            dgvCT.Columns[0].HeaderText = "Tên sách";
            dgvCT.Columns[1].HeaderText = "Số lượng nhập";
            dgvCT.Columns[2].HeaderText = "Đơn giá nhập";
            dgvCT.Columns[3].HeaderText = "Thành tiền";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
            dgvDS.Rows[0].Cells[0].Selected = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Environment.Exit(0);
            else
                return;
        }

        #region HoverButton
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_48;
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            btnMax.Image = Properties.Resources.icons8_maximize_button_48__1_;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.Image = Properties.Resources.icons8_minimize_window_48;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.Image = Properties.Resources.icons8_google_web_search_48;
        }

        private void btnFilter_MouseLeave(object sender, EventArgs e)
        {
            btnFilter.Image = Properties.Resources.icons8_filter_48;
            btnFilter.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void btnOpen_MouseLeave(object sender, EventArgs e)
        {
            btnOpen.Image = Properties.Resources.icons8_eye_100;
            btnOpen.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Image = Properties.Resources.icons8_plus___100;
            btnAdd.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Image = Properties.Resources.icons8_whiteboard_100;
            btnUpdate.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Image = Properties.Resources.icons8_delete_bin_100;
            btnDelete.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.Image = Properties.Resources.icons8_delete_bin_100__1_;
            btnDelete.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.Image = Properties.Resources.icons8_close_window_48__1_;
        }

        private void btnMax_MouseMove(object sender, MouseEventArgs e)
        {
            btnMax.Image = Properties.Resources.icons8_maximize_button_48;
        }

        private void btnMin_MouseMove(object sender, MouseEventArgs e)
        {
            btnMin.Image = Properties.Resources.icons8_minimize_window_48__1_;
        }

        private void btnSearch_MouseMove(object sender, MouseEventArgs e)
        {
            btnSearch.Image = Properties.Resources.icons8_google_web_search_48__1_;
        }

        private void btnFilter_MouseMove(object sender, MouseEventArgs e)
        {
            btnFilter.Image = Properties.Resources.icons8_filter_48__1_;
            btnFilter.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnOpen_MouseMove(object sender, MouseEventArgs e)
        {
            btnOpen.Image = Properties.Resources.icons8_eye_100__1_;
            btnOpen.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.Image = Properties.Resources.icons8_plus___100__1_;
            btnAdd.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdate.Image = Properties.Resources.icons8_whiteboard_100__1_;
            btnUpdate.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        #endregion

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region MoveFormBorderless

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dgvDS.Rows[index];
                txtMaPhieu.Text = selectedRow.Cells[0].Value.ToString();
                txtTenNCC.Text = selectedRow.Cells[1].Value.ToString();
                txtNgayNhap.Text = selectedRow.Cells[2].Value.ToString();
                txtMaDH.Text = selectedRow.Cells[3].Value.ToString();
                ShowData1();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = txtTimPhieu.Text;
            bool k = false;
            PhieuNhap pn = null;
            foreach (PhieuNhap item in li)
                if (item.MaPhieu == s)
                {
                    k = true;
                    pn = item;
                }
            if (k)
            {
                if(dgvDS.DataSource == null)
                    dgvDS.DataSource = li;
                for (int i = 0; i < li.Count; i++)
                    if (pn.MaPhieu == dgvDS.Rows[i].Cells[0].Value.ToString())
                    {
                        dgvDS.ClearSelection();
                        dgvDS.Rows[i].Cells[0].Selected = true;
                        dgvDS.CurrentCell = dgvDS.Rows[i].Cells[0];
                        txtMaPhieu.Text = dgvDS.Rows[i].Cells[0].Value.ToString();
                        txtTenNCC.Text = dgvDS.Rows[i].Cells[1].Value.ToString();
                        txtNgayNhap.Text = dgvDS.Rows[i].Cells[2].Value.ToString();
                        txtMaDH.Text = dgvDS.Rows[i].Cells[3].Value.ToString();
                        ShowData1();
                        txtTimPhieu.Clear();
                    }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã phiếu : " + txtTimPhieu.Text, "Thất bại");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime bd = dtpBD.Value;
            DateTime kt = dtpKT.Value;
            List<PhieuNhap> temporList = new List<PhieuNhap>();
            foreach (PhieuNhap item in li)
                if (bd.Date <= DateTime.ParseExact(item.NgayNhap, "dd/MM/yyyy", null) && DateTime.ParseExact(item.NgayNhap, "dd/MM/yyyy", null) <= kt.Date)
                {
                    temporList.Add(item);
                }
            dgvDS.DataSource = temporList;
        }

        #region HoverButton+
        private void btnRefresh_MouseMove(object sender, MouseEventArgs e)
        {
            btnRefresh.Image = Properties.Resources.icons8_refresh_48__1_;
            btnRefresh.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.Image = Properties.Resources.icons8_refresh_48;
            btnRefresh.Font = new Font("Arial", 12, FontStyle.Regular);
        }
        #endregion

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
            txtMaPhieu.Text = "...";
            txtTenNCC.Text = "...";
            txtNgayNhap.Text = "...";
            txtMaDH.Text = "...";
            dgvCT.DataSource = null;
            dgvDS.CurrentCell = null;
        }
    }
}
