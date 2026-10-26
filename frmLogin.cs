using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


       
        namespace QuanLyHocSinh
        {
        public partial class frmLogin : Form
        {
            public frmLogin()
            {
                InitializeComponent();
            }

            private void btnDangNhap_Click(object? sender, EventArgs e)
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "123")
                {
                    if (this.MdiParent is frmMain main)
                        main.MoKhoaMenu();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }

            private void btnThoat_Click(object? sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

