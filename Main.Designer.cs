namespace quanlyhocsinh
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuLop = new ToolStripMenuItem();
            mnuQuanLyHS = new ToolStripMenuItem();
            mnuHoSoHS = new ToolStripMenuItem();
            mnuNhapDiem = new ToolStripMenuItem();
            cửaSổthêmToolStripMenuItem = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileV = new ToolStripMenuItem();
            mnuTileH = new ToolStripMenuItem();
            mnuArrange = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblThoiGian = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuDanhMuc, mnuQuanLyHS, cửaSổthêmToolStripMenuItem, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(85, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.ShortcutKeys = Keys.Control | Keys.L;
            mnuDangNhap.Size = new Size(224, 26);
            mnuDangNhap.Text = "Đăng nhập";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(224, 26);
            mnuThoat.Text = "Thoát";
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.DropDownItems.AddRange(new ToolStripItem[] { mnuLop });
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(90, 24);
            mnuDanhMuc.Text = "Danh mục";
            mnuDanhMuc.Click += mnuDanhMuc_Click;
            // 
            // mnuLop
            // 
            mnuLop.Name = "mnuLop";
            mnuLop.Size = new Size(224, 26);
            mnuLop.Text = "Lớp";
            // 
            // mnuQuanLyHS
            // 
            mnuQuanLyHS.DropDownItems.AddRange(new ToolStripItem[] { mnuHoSoHS, mnuNhapDiem });
            mnuQuanLyHS.Name = "mnuQuanLyHS";
            mnuQuanLyHS.Size = new Size(131, 24);
            mnuQuanLyHS.Text = "Quản lý học sinh";
            // 
            // mnuHoSoHS
            // 
            mnuHoSoHS.Name = "mnuHoSoHS";
            mnuHoSoHS.Size = new Size(224, 26);
            mnuHoSoHS.Text = "Hồ sơ học sinh";
            // 
            // mnuNhapDiem
            // 
            mnuNhapDiem.Name = "mnuNhapDiem";
            mnuNhapDiem.Size = new Size(224, 26);
            mnuNhapDiem.Text = "Nhập điểm";
            // 
            // cửaSổthêmToolStripMenuItem
            // 
            cửaSổthêmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileV, mnuTileH, mnuArrange });
            cửaSổthêmToolStripMenuItem.Name = "cửaSổthêmToolStripMenuItem";
            cửaSổthêmToolStripMenuItem.Size = new Size(116, 24);
            cửaSổthêmToolStripMenuItem.Text = "Cửa sổ (thêm)";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(190, 26);
            mnuCascade.Text = "Cascade";
            // 
            // mnuTileV
            // 
            mnuTileV.Name = "mnuTileV";
            mnuTileV.Size = new Size(190, 26);
            mnuTileV.Text = "Tile Vertical";
            // 
            // mnuTileH
            // 
            mnuTileH.Name = "mnuTileH";
            mnuTileH.Size = new Size(190, 26);
            mnuTileH.Text = "Tile Horizontal";
            // 
            // mnuArrange
            // 
            mnuArrange.Name = "mnuArrange";
            mnuArrange.Size = new Size(190, 26);
            mnuArrange.Text = "Arrange Icons";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(78, 24);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(72, 24);
            toolStripButton1.Text = "chiakhoa";
            toolStripButton1.Click += mnuDangNhap_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(51, 24);
            toolStripButton2.Text = "nguoi";
            toolStripButton2.Click += mnuLop_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblThoiGian });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblThoiGian
            // 
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(68, 20);
            lblThoiGian.Text = "ThoiGian";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Quản lý học sinh";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuLop;
        private ToolStripMenuItem mnuQuanLyHS;
        private ToolStripMenuItem mnuHoSoHS;
        private ToolStripMenuItem mnuNhapDiem;
        private ToolStripMenuItem cửaSổthêmToolStripMenuItem;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileV;
        private ToolStripMenuItem mnuTileH;
        private ToolStripMenuItem mnuArrange;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripButton toolStripButton2;
        private ToolStripStatusLabel lblThoiGian;
    }
}
