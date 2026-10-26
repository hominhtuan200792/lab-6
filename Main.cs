namespace quanlyhocsinh
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void mnuLop_Click(object sender, EventArgs e)
        {

        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {

        }        
        namespace QuanLyHocSinh
    {
        public partial class frmMain : Form
        {
            public frmMain()
            {
                InitializeComponent();
                mnuDanhMuc.Enabled = false;        // chưa đăng nhập thì khóa
                mnuQuanLyHS.Enabled = false;
                lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }

            // frmLogin gọi hàm này khi đăng nhập thành công
            public void MoKhoaMenu()
            {
                mnuDanhMuc.Enabled = true;
                mnuQuanLyHS.Enabled = true;
            }

            // Mở form con, mỗi loại chỉ mở một cửa sổ
            private void MoFormCon<T>() where T : Form, new()
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f is T)
                    {
                        f.Activate();
                        return;
                    }
                }
                T con = new T();
                con.MdiParent = this;      // đang code ở form cha
                con.Show();                // form con chỉ dùng Show(), không dùng ShowDialog()
            }

            private void timer1_Tick(object? sender, EventArgs e)
            {
                lblThoiGian.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }

            private void mnuDangNhap_Click(object? sender, EventArgs e) { MoFormCon<frmLogin>(); }
            private void mnuLop_Click(object? sender, EventArgs e) { MoFormCon<frmLop>(); }
            private void mnuHoSoHS_Click(object? sender, EventArgs e) { MoFormCon<frmHocSinh>(); }
            private void mnuThoat_Click(object? sender, EventArgs e) { Application.Exit(); }

            private void mnuCascade_Click(object? sender, EventArgs e) { this.LayoutMdi(MdiLayout.Cascade); }
            private void mnuTileV_Click(object? sender, EventArgs e) { this.LayoutMdi(MdiLayout.TileVertical); }
            private void mnuTileH_Click(object? sender, EventArgs e) { this.LayoutMdi(MdiLayout.TileHorizontal); }
            private void mnuArrange_Click(object? sender, EventArgs e) { this.LayoutMdi(MdiLayout.ArrangeIcons); }
        }
    }
}
}
